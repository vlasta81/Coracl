
namespace CoracLibrary.Exceptions
{
    /// <summary>
    /// Represents errors that occur during the execution of a chain of operations.
    /// </summary>
    public class ChainExecutionException(string message, Exception? innerException = null) : Exception(message, innerException) { }
}
