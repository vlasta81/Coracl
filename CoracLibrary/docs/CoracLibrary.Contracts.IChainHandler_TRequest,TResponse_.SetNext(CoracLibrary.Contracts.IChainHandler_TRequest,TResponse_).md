#### [CoracLibrary](CoracLibrary.md 'CoracLibrary')
### [CoracLibrary.Contracts](CoracLibrary.Contracts.md 'CoracLibrary.Contracts').[IChainHandler&lt;TRequest,TResponse&gt;](CoracLibrary.Contracts.IChainHandler_TRequest,TResponse_.md 'CoracLibrary.Contracts.IChainHandler<TRequest,TResponse>')

## IChainHandler<TRequest,TResponse>.SetNext(IChainHandler<TRequest,TResponse>) Method

Sets the next handler in the chain.

```csharp
void SetNext(CoracLibrary.Contracts.IChainHandler<TRequest,TResponse> nextHandler);
```
#### Parameters

<a name='CoracLibrary.Contracts.IChainHandler_TRequest,TResponse_.SetNext(CoracLibrary.Contracts.IChainHandler_TRequest,TResponse_).nextHandler'></a>

`nextHandler` [CoracLibrary.Contracts.IChainHandler&lt;](CoracLibrary.Contracts.IChainHandler_TRequest,TResponse_.md 'CoracLibrary.Contracts.IChainHandler<TRequest,TResponse>')[TRequest](CoracLibrary.Contracts.IChainHandler_TRequest,TResponse_.md#CoracLibrary.Contracts.IChainHandler_TRequest,TResponse_.TRequest 'CoracLibrary.Contracts.IChainHandler<TRequest,TResponse>.TRequest')[,](CoracLibrary.Contracts.IChainHandler_TRequest,TResponse_.md 'CoracLibrary.Contracts.IChainHandler<TRequest,TResponse>')[TResponse](CoracLibrary.Contracts.IChainHandler_TRequest,TResponse_.md#CoracLibrary.Contracts.IChainHandler_TRequest,TResponse_.TResponse 'CoracLibrary.Contracts.IChainHandler<TRequest,TResponse>.TResponse')[&gt;](CoracLibrary.Contracts.IChainHandler_TRequest,TResponse_.md 'CoracLibrary.Contracts.IChainHandler<TRequest,TResponse>')

The next handler to be set.