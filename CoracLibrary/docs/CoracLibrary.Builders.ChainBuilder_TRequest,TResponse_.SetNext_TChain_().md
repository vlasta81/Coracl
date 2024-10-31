#### [CoracLibrary](CoracLibrary.md 'CoracLibrary')
### [CoracLibrary.Builders](CoracLibrary.Builders.md 'CoracLibrary.Builders').[ChainBuilder&lt;TRequest,TResponse&gt;](CoracLibrary.Builders.ChainBuilder_TRequest,TResponse_.md 'CoracLibrary.Builders.ChainBuilder<TRequest,TResponse>')

## ChainBuilder<TRequest,TResponse>.SetNext<TChain>() Method

Sets the next handler in the chain.

```csharp
public CoracLibrary.Builders.ChainBuilder<TRequest,TResponse> SetNext<TChain>()
    where TChain : CoracLibrary.Contracts.IChainHandler<TRequest, TResponse>;
```
#### Type parameters

<a name='CoracLibrary.Builders.ChainBuilder_TRequest,TResponse_.SetNext_TChain_().TChain'></a>

`TChain`

The type of the next handler.

#### Returns
[CoracLibrary.Builders.ChainBuilder&lt;](CoracLibrary.Builders.ChainBuilder_TRequest,TResponse_.md 'CoracLibrary.Builders.ChainBuilder<TRequest,TResponse>')[TRequest](CoracLibrary.Builders.ChainBuilder_TRequest,TResponse_.md#CoracLibrary.Builders.ChainBuilder_TRequest,TResponse_.TRequest 'CoracLibrary.Builders.ChainBuilder<TRequest,TResponse>.TRequest')[,](CoracLibrary.Builders.ChainBuilder_TRequest,TResponse_.md 'CoracLibrary.Builders.ChainBuilder<TRequest,TResponse>')[TResponse](CoracLibrary.Builders.ChainBuilder_TRequest,TResponse_.md#CoracLibrary.Builders.ChainBuilder_TRequest,TResponse_.TResponse 'CoracLibrary.Builders.ChainBuilder<TRequest,TResponse>.TResponse')[&gt;](CoracLibrary.Builders.ChainBuilder_TRequest,TResponse_.md 'CoracLibrary.Builders.ChainBuilder<TRequest,TResponse>')  
The current instance of [ChainBuilder&lt;TRequest,TResponse&gt;](CoracLibrary.Builders.ChainBuilder_TRequest,TResponse_.md 'CoracLibrary.Builders.ChainBuilder<TRequest,TResponse>').

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
Thrown when the handler is null.