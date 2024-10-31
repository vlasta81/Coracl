#### [CoracLibrary](CoracLibrary.md 'CoracLibrary')
### [CoracLibrary.Contracts](CoracLibrary.Contracts.md 'CoracLibrary.Contracts').[IChainHandler&lt;TRequest,TResponse&gt;](CoracLibrary.Contracts.IChainHandler_TRequest,TResponse_.md 'CoracLibrary.Contracts.IChainHandler<TRequest,TResponse>')

## IChainHandler<TRequest,TResponse>.HandleAsync(TRequest) Method

Handles the request asynchronously.

```csharp
System.Threading.Tasks.Task<TResponse?> HandleAsync(TRequest request);
```
#### Parameters

<a name='CoracLibrary.Contracts.IChainHandler_TRequest,TResponse_.HandleAsync(TRequest).request'></a>

`request` [TRequest](CoracLibrary.Contracts.IChainHandler_TRequest,TResponse_.md#CoracLibrary.Contracts.IChainHandler_TRequest,TResponse_.TRequest 'CoracLibrary.Contracts.IChainHandler<TRequest,TResponse>.TRequest')

The request object to be handled.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TResponse](CoracLibrary.Contracts.IChainHandler_TRequest,TResponse_.md#CoracLibrary.Contracts.IChainHandler_TRequest,TResponse_.TResponse 'CoracLibrary.Contracts.IChainHandler<TRequest,TResponse>.TResponse')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
A task that represents the asynchronous operation. The task result contains the response object.