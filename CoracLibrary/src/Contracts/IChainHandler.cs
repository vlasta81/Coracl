
namespace CoracLibrary.Contracts
{
    /// <summary>
    /// Defines a handler in a chain of responsibility pattern.
    /// </summary>
    /// <typeparam name="TRequest">The type of the request object.</typeparam>
    /// <typeparam name="TResponse">The type of the response object.</typeparam>
    public interface IChainHandler<TRequest, TResponse>
    {
        /// <summary>
        /// Sets the next handler in the chain.
        /// </summary>
        /// <param name="nextHandler">The next handler to be set.</param>
        void SetNext(IChainHandler<TRequest, TResponse> nextHandler);

        /// <summary>
        /// Handles the request asynchronously.
        /// </summary>
        /// <param name="request">The request object to be handled.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response object.</returns>
        Task<TResponse?> HandleAsync(TRequest request);
    }
}
