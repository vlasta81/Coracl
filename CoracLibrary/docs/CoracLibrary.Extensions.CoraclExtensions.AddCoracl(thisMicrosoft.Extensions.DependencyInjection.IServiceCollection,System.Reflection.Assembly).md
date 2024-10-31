#### [CoracLibrary](CoracLibrary.md 'CoracLibrary')
### [CoracLibrary.Extensions](CoracLibrary.Extensions.md 'CoracLibrary.Extensions').[CoraclExtensions](CoracLibrary.Extensions.CoraclExtensions.md 'CoracLibrary.Extensions.CoraclExtensions')

## CoraclExtensions.AddCoracl(this IServiceCollection, Assembly) Method

Adds Coracl services to the specified IServiceCollection.

```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddCoracl(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, System.Reflection.Assembly assembly);
```
#### Parameters

<a name='CoracLibrary.Extensions.CoraclExtensions.AddCoracl(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Reflection.Assembly).services'></a>

`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')

The IServiceCollection to add services to.

<a name='CoracLibrary.Extensions.CoraclExtensions.AddCoracl(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Reflection.Assembly).assembly'></a>

`assembly` [System.Reflection.Assembly](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.Assembly 'System.Reflection.Assembly')

The assembly to scan for types implementing ICommandHandler and IChainHandler interfaces.

#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The IServiceCollection with Coracl services added.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
Thrown if the services parameter is null.