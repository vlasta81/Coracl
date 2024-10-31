#### [CoracLibrary](CoracLibrary.md 'CoracLibrary')
### [CoracLibrary.Abstractions](CoracLibrary.Abstractions.md 'CoracLibrary.Abstractions').[ChainHandler&lt;TRequest,TResponse&gt;](CoracLibrary.Abstractions.ChainHandler_TRequest,TResponse_.md 'CoracLibrary.Abstractions.ChainHandler<TRequest,TResponse>')

## ChainHandler<TRequest,TResponse>.HandleAsync(TRequest) Method

Handles the request asynchronously. If the current handler cannot process the request,  
it delegates the request to the next handler in the chain.

```csharp
public virtual System.Threading.Tasks.Task<TResponse?> HandleAsync(TRequest request);
```
#### Parameters

<a name='CoracLibrary.Abstractions.ChainHandler_TRequest,TResponse_.HandleAsync(TRequest).request'></a>

`request` [TRequest](CoracLibrary.Abstractions.ChainHandler_TRequest,TResponse_.md#CoracLibrary.Abstractions.ChainHandler_TRequest,TResponse_.TRequest 'CoracLibrary.Abstractions.ChainHandler<TRequest,TResponse>.TRequest')

The request object to be handled.

Implements [HandleAsync(TRequest)](CoracLibrary.Contracts.IChainHandler_TRequest,TResponse_.HandleAsync(TRequest).md 'CoracLibrary.Contracts.IChainHandler<TRequest,TResponse>.HandleAsync(TRequest)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TResponse](CoracLibrary.Abstractions.ChainHandler_TRequest,TResponse_.md#CoracLibrary.Abstractions.ChainHandler_TRequest,TResponse_.TResponse 'CoracLibrary.Abstractions.ChainHandler<TRequest,TResponse>.TResponse')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
A task that represents the asynchronous operation. The task result contains the response object.