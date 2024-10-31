#### [CoracLibrary](CoracLibrary.md 'CoracLibrary')
### [CoracLibrary](CoracLibrary.md 'CoracLibrary').[Coracl](CoracLibrary.Coracl.md 'CoracLibrary.Coracl')

## Coracl.Delegate<TRequest,TResponse>(TRequest) Method

Creates a new chain builder for handling the specified request.

```csharp
public CoracLibrary.Builders.ChainBuilder<TRequest,TResponse> Delegate<TRequest,TResponse>(TRequest request);
```
#### Type parameters

<a name='CoracLibrary.Coracl.Delegate_TRequest,TResponse_(TRequest).TRequest'></a>

`TRequest`

The type of the request.

<a name='CoracLibrary.Coracl.Delegate_TRequest,TResponse_(TRequest).TResponse'></a>

`TResponse`

The type of the response.
#### Parameters

<a name='CoracLibrary.Coracl.Delegate_TRequest,TResponse_(TRequest).request'></a>

`request` [TRequest](CoracLibrary.Coracl.Delegate_TRequest,TResponse_(TRequest).md#CoracLibrary.Coracl.Delegate_TRequest,TResponse_(TRequest).TRequest 'CoracLibrary.Coracl.Delegate<TRequest,TResponse>(TRequest).TRequest')

The request to be handled.

Implements [Delegate&lt;TRequest,TResponse&gt;(TRequest)](CoracLibrary.Contracts.ICoracl.Delegate_TRequest,TResponse_(TRequest).md 'CoracLibrary.Contracts.ICoracl.Delegate<TRequest,TResponse>(TRequest)')

#### Returns
[CoracLibrary.Builders.ChainBuilder&lt;](CoracLibrary.Builders.ChainBuilder_TRequest,TResponse_.md 'CoracLibrary.Builders.ChainBuilder<TRequest,TResponse>')[TRequest](CoracLibrary.Coracl.Delegate_TRequest,TResponse_(TRequest).md#CoracLibrary.Coracl.Delegate_TRequest,TResponse_(TRequest).TRequest 'CoracLibrary.Coracl.Delegate<TRequest,TResponse>(TRequest).TRequest')[,](CoracLibrary.Builders.ChainBuilder_TRequest,TResponse_.md 'CoracLibrary.Builders.ChainBuilder<TRequest,TResponse>')[TResponse](CoracLibrary.Coracl.Delegate_TRequest,TResponse_(TRequest).md#CoracLibrary.Coracl.Delegate_TRequest,TResponse_(TRequest).TResponse 'CoracLibrary.Coracl.Delegate<TRequest,TResponse>(TRequest).TResponse')[&gt;](CoracLibrary.Builders.ChainBuilder_TRequest,TResponse_.md 'CoracLibrary.Builders.ChainBuilder<TRequest,TResponse>')  
A chain builder for handling the request.