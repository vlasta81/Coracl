#### [CoracLibrary](CoracLibrary.md 'CoracLibrary')
### [CoracLibrary.Contracts](CoracLibrary.Contracts.md 'CoracLibrary.Contracts')

## ICommandHandler<TRequest,TResponse> Interface

Interface for handling commands with a request and response.

```csharp
public interface ICommandHandler<TRequest,TResponse>
```
#### Type parameters

<a name='CoracLibrary.Contracts.ICommandHandler_TRequest,TResponse_.TRequest'></a>

`TRequest`

The type of the request object.

<a name='CoracLibrary.Contracts.ICommandHandler_TRequest,TResponse_.TResponse'></a>

`TResponse`

The type of the response object.

| Methods | |
| :--- | :--- |
| [ExecuteAsync(TRequest)](CoracLibrary.Contracts.ICommandHandler_TRequest,TResponse_.ExecuteAsync(TRequest).md 'CoracLibrary.Contracts.ICommandHandler<TRequest,TResponse>.ExecuteAsync(TRequest)') | Executes the command asynchronously. |
