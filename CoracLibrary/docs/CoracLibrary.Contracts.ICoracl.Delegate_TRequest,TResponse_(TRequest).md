#### [CoracLibrary](CoracLibrary.md 'CoracLibrary')
### [CoracLibrary.Contracts](CoracLibrary.Contracts.md 'CoracLibrary.Contracts').[ICoracl](CoracLibrary.Contracts.ICoracl.md 'CoracLibrary.Contracts.ICoracl')

## ICoracl.Delegate<TRequest,TResponse>(TRequest) Method

Delegates a request to a chain of handlers.

```csharp
CoracLibrary.Builders.ChainBuilder<TRequest,TResponse> Delegate<TRequest,TResponse>(TRequest request);
```
#### Type parameters

<a name='CoracLibrary.Contracts.ICoracl.Delegate_TRequest,TResponse_(TRequest).TRequest'></a>

`TRequest`

The type of the request.

<a name='CoracLibrary.Contracts.ICoracl.Delegate_TRequest,TResponse_(TRequest).TResponse'></a>

`TResponse`

The type of the response.
#### Parameters

<a name='CoracLibrary.Contracts.ICoracl.Delegate_TRequest,TResponse_(TRequest).request'></a>

`request` [TRequest](CoracLibrary.Contracts.ICoracl.Delegate_TRequest,TResponse_(TRequest).md#CoracLibrary.Contracts.ICoracl.Delegate_TRequest,TResponse_(TRequest).TRequest 'CoracLibrary.Contracts.ICoracl.Delegate<TRequest,TResponse>(TRequest).TRequest')

The request to be processed.

#### Returns
[CoracLibrary.Builders.ChainBuilder&lt;](CoracLibrary.Builders.ChainBuilder_TRequest,TResponse_.md 'CoracLibrary.Builders.ChainBuilder<TRequest,TResponse>')[TRequest](CoracLibrary.Contracts.ICoracl.Delegate_TRequest,TResponse_(TRequest).md#CoracLibrary.Contracts.ICoracl.Delegate_TRequest,TResponse_(TRequest).TRequest 'CoracLibrary.Contracts.ICoracl.Delegate<TRequest,TResponse>(TRequest).TRequest')[,](CoracLibrary.Builders.ChainBuilder_TRequest,TResponse_.md 'CoracLibrary.Builders.ChainBuilder<TRequest,TResponse>')[TResponse](CoracLibrary.Contracts.ICoracl.Delegate_TRequest,TResponse_(TRequest).md#CoracLibrary.Contracts.ICoracl.Delegate_TRequest,TResponse_(TRequest).TResponse 'CoracLibrary.Contracts.ICoracl.Delegate<TRequest,TResponse>(TRequest).TResponse')[&gt;](CoracLibrary.Builders.ChainBuilder_TRequest,TResponse_.md 'CoracLibrary.Builders.ChainBuilder<TRequest,TResponse>')  
A ChainBuilder instance to configure the chain of handlers.