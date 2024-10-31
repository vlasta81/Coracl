using CoracLibrary.Contracts;
using CoracLibrary.Exceptions;
using Microsoft.Extensions.DependencyInjection;

namespace CoracLibrary.Builders
{
    /// <summary>
    /// A builder class for creating and executing a chain of responsibility pattern.
    /// </summary>
    /// <typeparam name="TRequest">The type of the request object.</typeparam>
    /// <typeparam name="TResponse">The type of the response object.</typeparam>
    public sealed class ChainBuilder<TRequest, TResponse>
    {
        private readonly TRequest _request;
        private readonly IServiceProvider _serviceProvider;
        private IChainHandler<TRequest, TResponse>? _chain;
        private IChainHandler<TRequest, TResponse>? _tempChain;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChainBuilder{TRequest, TResponse}"/> class.
        /// </summary>
        /// <param name="request">The request object to be handled.</param>
        /// <param name="serviceProvider">The service provider for resolving dependencies.</param>
        public ChainBuilder(TRequest request, IServiceProvider serviceProvider)
        {
            _request = request;
            _serviceProvider = serviceProvider;
        }

        /// <summary>
        /// Sets the next handler in the chain.
        /// </summary>
        /// <typeparam name="TChain">The type of the next handler.</typeparam>
        /// <returns>The current instance of <see cref="ChainBuilder{TRequest, TResponse}"/>.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the handler is null.</exception>
        public ChainBuilder<TRequest, TResponse> SetNext<TChain>() where TChain : IChainHandler<TRequest, TResponse>
        {
            TChain? handler = _serviceProvider.GetRequiredService<TChain>();
            ArgumentNullException.ThrowIfNull(handler);
            if (_chain is null)
            {
                _chain = handler;
                _tempChain = handler;
            }
            else
            {
                _tempChain?.SetNext(handler);
                _tempChain = handler;
            }
            return this;
        }

        /// <summary>
        /// Executes the chain of handlers asynchronously.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response object.</returns>
        /// <exception cref="ChainExecutionException">Thrown when an error occurs during the execution of the chain.</exception>
        /// <remarks>
        /// This method executes the chain of responsibility pattern. It processes the request through the chain of handlers.
        /// If any handler in the chain returns a response, the process is terminated and the response is returned.
        /// If the chain does not return any response, a command corresponding to the implementation of <see cref="ICommandHandler{TRequest, TResponse}"/> is executed.
        /// The chain can also be interrupted by returning null from a handler, in which case the command is executed.
        /// </remarks>
        public async Task<TResponse> ExecuteAsync()
        {
            try
            {
                if (_chain is not null)
                {
                    TResponse? chainResult = await _chain.HandleAsync(_request);
                    if (chainResult is not null)
                    {
                        return chainResult;
                    }
                }
                ICommandHandler<TRequest, TResponse>? command = _serviceProvider.GetRequiredService<ICommandHandler<TRequest, TResponse>>();
                ArgumentNullException.ThrowIfNull(command);
                TResponse? commandResult = await command.ExecuteAsync(_request);
                return commandResult;
            }
            catch (Exception ex) when (ex is not OperationCanceledException)
            {
                throw new ChainExecutionException($"Error executing chain for request type {typeof(TRequest).Name}", ex);
            }
        }
    }
}
