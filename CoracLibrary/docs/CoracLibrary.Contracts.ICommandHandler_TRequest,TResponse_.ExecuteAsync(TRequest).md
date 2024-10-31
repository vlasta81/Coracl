#### [CoracLibrary](CoracLibrary.md 'CoracLibrary')
### [CoracLibrary.Contracts](CoracLibrary.Contracts.md 'CoracLibrary.Contracts').[ICommandHandler&lt;TRequest,TResponse&gt;](CoracLibrary.Contracts.ICommandHandler_TRequest,TResponse_.md 'CoracLibrary.Contracts.ICommandHandler<TRequest,TResponse>')

## ICommandHandler<TRequest,TResponse>.ExecuteAsync(TRequest) Method

Executes the command asynchronously.

```csharp
System.Threading.Tasks.Task<TResponse> ExecuteAsync(TRequest request);
```
#### Parameters

<a name='CoracLibrary.Contracts.ICommandHandler_TRequest,TResponse_.ExecuteAsync(TRequest).request'></a>

`request` [TRequest](CoracLibrary.Contracts.ICommandHandler_TRequest,TResponse_.md#CoracLibrary.Contracts.ICommandHandler_TRequest,TResponse_.TRequest 'CoracLibrary.Contracts.ICommandHandler<TRequest,TResponse>.TRequest')

The request object.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TResponse](CoracLibrary.Contracts.ICommandHandler_TRequest,TResponse_.md#CoracLibrary.Contracts.ICommandHandler_TRequest,TResponse_.TResponse 'CoracLibrary.Contracts.ICommandHandler<TRequest,TResponse>.TResponse')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
A task that represents the asynchronous operation. The task result contains the response object.