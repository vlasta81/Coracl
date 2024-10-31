#### [CoracLibrary](CoracLibrary.md 'CoracLibrary')
### [CoracLibrary.Abstractions](CoracLibrary.Abstractions.md 'CoracLibrary.Abstractions')

## ChainHandler<TRequest,TResponse> Class

Represents an abstract base class for a handler in a chain of responsibility pattern.

```csharp
public abstract class ChainHandler<TRequest,TResponse> :
CoracLibrary.Contracts.IChainHandler<TRequest, TResponse>
```
#### Type parameters

<a name='CoracLibrary.Abstractions.ChainHandler_TRequest,TResponse_.TRequest'></a>

`TRequest`

The type of the request object.

<a name='CoracLibrary.Abstractions.ChainHandler_TRequest,TResponse_.TResponse'></a>

`TResponse`

The type of the response object.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ChainHandler<TRequest,TResponse>

Implements [CoracLibrary.Contracts.IChainHandler&lt;](CoracLibrary.Contracts.IChainHandler_TRequest,TResponse_.md 'CoracLibrary.Contracts.IChainHandler<TRequest,TResponse>')[TRequest](CoracLibrary.Abstractions.ChainHandler_TRequest,TResponse_.md#CoracLibrary.Abstractions.ChainHandler_TRequest,TResponse_.TRequest 'CoracLibrary.Abstractions.ChainHandler<TRequest,TResponse>.TRequest')[,](CoracLibrary.Contracts.IChainHandler_TRequest,TResponse_.md 'CoracLibrary.Contracts.IChainHandler<TRequest,TResponse>')[TResponse](CoracLibrary.Abstractions.ChainHandler_TRequest,TResponse_.md#CoracLibrary.Abstractions.ChainHandler_TRequest,TResponse_.TResponse 'CoracLibrary.Abstractions.ChainHandler<TRequest,TResponse>.TResponse')[&gt;](CoracLibrary.Contracts.IChainHandler_TRequest,TResponse_.md 'CoracLibrary.Contracts.IChainHandler<TRequest,TResponse>')

| Methods | |
| :--- | :--- |
| [HandleAsync(TRequest)](CoracLibrary.Abstractions.ChainHandler_TRequest,TResponse_.HandleAsync(TRequest).md 'CoracLibrary.Abstractions.ChainHandler<TRequest,TResponse>.HandleAsync(TRequest)') | Handles the request asynchronously. If the current handler cannot process the request,<br/>it delegates the request to the next handler in the chain. |

| Explicit Interface Implementations | |
| :--- | :--- |
| [CoracLibrary.Contracts.IChainHandler&lt;TRequest,TResponse&gt;.SetNext(IChainHandler&lt;TRequest,TResponse&gt;)](CoracLibrary.Abstractions.ChainHandler_TRequest,TResponse_.CoracLibrary.Contracts.IChainHandler_TRequest,TResponse_.SetNext(CoracLibrary.Contracts.IChainHandler_TRequest,TResponse_).md 'CoracLibrary.Abstractions.ChainHandler<TRequest,TResponse>.CoracLibrary.Contracts.IChainHandler<TRequest,TResponse>.SetNext(CoracLibrary.Contracts.IChainHandler<TRequest,TResponse>)') | Sets the next handler in the chain. |
