#### [CoracLibrary](CoracLibrary.md 'CoracLibrary')
### [CoracLibrary.Contracts](CoracLibrary.Contracts.md 'CoracLibrary.Contracts')

## IChainHandler<TRequest,TResponse> Interface

Defines a handler in a chain of responsibility pattern.

```csharp
public interface IChainHandler<TRequest,TResponse>
```
#### Type parameters

<a name='CoracLibrary.Contracts.IChainHandler_TRequest,TResponse_.TRequest'></a>

`TRequest`

The type of the request object.

<a name='CoracLibrary.Contracts.IChainHandler_TRequest,TResponse_.TResponse'></a>

`TResponse`

The type of the response object.

Derived  
&#8627; [ChainHandler&lt;TRequest,TResponse&gt;](CoracLibrary.Abstractions.ChainHandler_TRequest,TResponse_.md 'CoracLibrary.Abstractions.ChainHandler<TRequest,TResponse>')

| Methods | |
| :--- | :--- |
| [HandleAsync(TRequest)](CoracLibrary.Contracts.IChainHandler_TRequest,TResponse_.HandleAsync(TRequest).md 'CoracLibrary.Contracts.IChainHandler<TRequest,TResponse>.HandleAsync(TRequest)') | Handles the request asynchronously. |
| [SetNext(IChainHandler&lt;TRequest,TResponse&gt;)](CoracLibrary.Contracts.IChainHandler_TRequest,TResponse_.SetNext(CoracLibrary.Contracts.IChainHandler_TRequest,TResponse_).md 'CoracLibrary.Contracts.IChainHandler<TRequest,TResponse>.SetNext(CoracLibrary.Contracts.IChainHandler<TRequest,TResponse>)') | Sets the next handler in the chain. |
