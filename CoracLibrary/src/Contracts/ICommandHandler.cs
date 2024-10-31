
namespace CoracLibrary.Contracts
{
    /// <summary>
    /// Interface for handling commands with a request and response.
    /// </summary>
    /// <typeparam name="TRequest">The type of the request object.</typeparam>
    /// <typeparam name="TResponse">The type of the response object.</typeparam>
    public interface ICommandHandler<TRequest, TResponse>
    {
        /// <summary>
        /// Executes the command asynchronously.
        /// </summary>
        /// <param name="request">The request object.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response object.</returns>
        Task<TResponse> ExecuteAsync(TRequest request);
    }
}
