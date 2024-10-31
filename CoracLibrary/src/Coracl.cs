using CoracLibrary.Builders;
using CoracLibrary.Contracts;

namespace CoracLibrary
{
    /// <summary>
    /// Represents the main entry point for the Corac library.
    /// </summary>
    public sealed class Coracl : ICoracl
    {
        private readonly IServiceProvider _serviceProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="Coracl"/> class.
        /// </summary>
        /// <param name="serviceProvider">The service provider to resolve dependencies.</param>
        public Coracl(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        /// <summary>
        /// Creates a new chain builder for handling the specified request.
        /// </summary>
        /// <typeparam name="TRequest">The type of the request.</typeparam>
        /// <typeparam name="TResponse">The type of the response.</typeparam>
        /// <param name="request">The request to be handled.</param>
        /// <returns>A chain builder for handling the request.</returns>
        public ChainBuilder<TRequest, TResponse> Delegate<TRequest, TResponse>(TRequest request)
        {
            return new ChainBuilder<TRequest, TResponse>(request, _serviceProvider);
        }
    }
}
