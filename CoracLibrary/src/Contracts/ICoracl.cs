using CoracLibrary.Builders;

namespace CoracLibrary.Contracts
{
    /// <summary>
    /// Interface for Coracl operations.
    /// </summary>
    public interface ICoracl
    {
        /// <summary>
        /// Delegates a request to a chain of handlers.
        /// </summary>
        /// <typeparam name="TRequest">The type of the request.</typeparam>
        /// <typeparam name="TResponse">The type of the response.</typeparam>
        /// <param name="request">The request to be processed.</param>
        /// <returns>A ChainBuilder instance to configure the chain of handlers.</returns>
        ChainBuilder<TRequest, TResponse> Delegate<TRequest, TResponse>(TRequest request);
    }
}
