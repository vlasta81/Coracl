#### [CoracLibrary](CoracLibrary.md 'CoracLibrary')
### [CoracLibrary.Builders](CoracLibrary.Builders.md 'CoracLibrary.Builders').[ChainBuilder&lt;TRequest,TResponse&gt;](CoracLibrary.Builders.ChainBuilder_TRequest,TResponse_.md 'CoracLibrary.Builders.ChainBuilder<TRequest,TResponse>')

## ChainBuilder<TRequest,TResponse>.ExecuteAsync() Method

Executes the chain of handlers asynchronously.

```csharp
public System.Threading.Tasks.Task<TResponse> ExecuteAsync();
```

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TResponse](CoracLibrary.Builders.ChainBuilder_TRequest,TResponse_.md#CoracLibrary.Builders.ChainBuilder_TRequest,TResponse_.TResponse 'CoracLibrary.Builders.ChainBuilder<TRequest,TResponse>.TResponse')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
A task that represents the asynchronous operation. The task result contains the response object.

#### Exceptions

[ChainExecutionException](CoracLibrary.Exceptions.ChainExecutionException.md 'CoracLibrary.Exceptions.ChainExecutionException')  
Thrown when an error occurs during the execution of the chain.

### Remarks
This method executes the chain of responsibility pattern. It processes the request through the chain of handlers.  
If any handler in the chain returns a response, the process is terminated and the response is returned.  
If the chain does not return any response, a command corresponding to the implementation of [ICommandHandler&lt;TRequest,TResponse&gt;](CoracLibrary.Contracts.ICommandHandler_TRequest,TResponse_.md 'CoracLibrary.Contracts.ICommandHandler<TRequest,TResponse>') is executed.  
The chain can also be interrupted by returning null from a handler, in which case the command is executed.