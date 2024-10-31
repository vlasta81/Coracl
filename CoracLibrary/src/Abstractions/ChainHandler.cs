using CoracLibrary.Contracts;

namespace CoracLibrary.Abstractions
{
    /// <summary>
    /// Represents an abstract base class for a handler in a chain of responsibility pattern.
    /// </summary>
    /// <typeparam name="TRequest">The type of the request object.</typeparam>
    /// <typeparam name="TResponse">The type of the response object.</typeparam>
    public abstract class ChainHandler<TRequest, TResponse> : IChainHandler<TRequest, TResponse>
    {
        private IChainHandler<TRequest, TResponse>? _nextHandler;

        /// <summary>
        /// Sets the next handler in the chain.
        /// </summary>
        /// <param name="nextHandler">The next handler to be set.</param>
        void IChainHandler<TRequest, TResponse>.SetNext(IChainHandler<TRequest, TResponse> nextHandler)
        {
            _nextHandler = nextHandler;
        }

        /// <summary>
        /// Handles the request asynchronously. If the current handler cannot process the request,
        /// it delegates the request to the next handler in the chain.
        /// </summary>
        /// <param name="request">The request object to be handled.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response object.</returns>
        public virtual async Task<TResponse?> HandleAsync(TRequest request)
        {
            return _nextHandler is not null ? await _nextHandler.HandleAsync(request) : default;
        }
    }
}
