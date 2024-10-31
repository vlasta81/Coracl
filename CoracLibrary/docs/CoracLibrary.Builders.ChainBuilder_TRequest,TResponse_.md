#### [CoracLibrary](CoracLibrary.md 'CoracLibrary')
### [CoracLibrary.Builders](CoracLibrary.Builders.md 'CoracLibrary.Builders')

## ChainBuilder<TRequest,TResponse> Class

A builder class for creating and executing a chain of responsibility pattern.

```csharp
public sealed class ChainBuilder<TRequest,TResponse>
```
#### Type parameters

<a name='CoracLibrary.Builders.ChainBuilder_TRequest,TResponse_.TRequest'></a>

`TRequest`

The type of the request object.

<a name='CoracLibrary.Builders.ChainBuilder_TRequest,TResponse_.TResponse'></a>

`TResponse`

The type of the response object.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ChainBuilder<TRequest,TResponse>

| Constructors | |
| :--- | :--- |
| [ChainBuilder(TRequest, IServiceProvider)](CoracLibrary.Builders.ChainBuilder_TRequest,TResponse_.ChainBuilder(TRequest,System.IServiceProvider).md 'CoracLibrary.Builders.ChainBuilder<TRequest,TResponse>.ChainBuilder(TRequest, System.IServiceProvider)') | Initializes a new instance of the [ChainBuilder&lt;TRequest,TResponse&gt;](CoracLibrary.Builders.ChainBuilder_TRequest,TResponse_.md 'CoracLibrary.Builders.ChainBuilder<TRequest,TResponse>') class. |

| Methods | |
| :--- | :--- |
| [ExecuteAsync()](CoracLibrary.Builders.ChainBuilder_TRequest,TResponse_.ExecuteAsync().md 'CoracLibrary.Builders.ChainBuilder<TRequest,TResponse>.ExecuteAsync()') | Executes the chain of handlers asynchronously. |
| [SetNext&lt;TChain&gt;()](CoracLibrary.Builders.ChainBuilder_TRequest,TResponse_.SetNext_TChain_().md 'CoracLibrary.Builders.ChainBuilder<TRequest,TResponse>.SetNext<TChain>()') | Sets the next handler in the chain. |
