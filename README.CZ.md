**C**hain **o**f **R**esponsibility **a** **C**ommand **L**ibrary

# CORACL (CoracLibrary)

Jednoduchá .NET 8 knihovna implementující vzory *Chain of Responsibility* a *Command*.

## Hlavní funkce

- Implementace návrhového vzoru *Chain of Responsibility*
- Podpora asynchronního zpracování
- Fluent API pro snadnou konfiguraci řetězce
- Automatická registrace handlerů pomocí dependency injection
- Implementace návrhového vzoru *Command* pro finální zpracování požadavku

## Stažení

Aktuální knihovna ke stažení zde: **DOWNLOAD**.

## Instalace

Ve Visual Studiu přidejte referenci na dll knihovnu **CoracLibrary.dll**.

## Použití

### Program.cs

```
using CoracLibrary.Extensions;

... // váš předchozí kód...

builder.Services.AddCoracl(typeof(Program).Assembly);

... // pokračování vašeho kódu...
```

### Kontroler

```
using CoracLibrary.Contracts;

... // váš předchozí kód...

    [ApiController]    
    public class HomeController : ControllerBase
    {

        private readonly ICoracl _coracl;

        public HomeController(ICoracl coracl)
        {
            _coracl = coracl;
        }

        [HttpGet]
        [Route("api/home")]
        public async Task<MyRequest, MyResponse> Home(MyRequest request)
        {
            return await _coracl
                .Delegate<MyRequest, MyResponse>(request)
                .SetNext<ValidationChain>()
                .ExecuteAsync();
        }
    }
        
... // pokračování vašeho kódu...
```

## Chain of Responsibility and Command

### ChainHandler

- Každý handler může vrátit odpověď nebo předat požadavek dalšímu v řadě.
- Každý handler implementuje **ChainHandler<TRequest, TResponse>**.
	- **TRequest** třída požadavku, která prochází řetězcem.
	- **TResponse** třída odpovědi, kterou řetězec vrací.
- Každý handler přepisuje metodu **HandleAsync** z abstraktní třídy **ChainHandler**.
- Volání dalšího článku v řetězci: (viz. příklad) **return await base.HandleAsync(request);**.
- Řetězec může být také přerušen v libovolném článku, pokud handler vrátí null. Poté se provede příkaz a vrátí se odpověď.

```
using CoracLibrary.Abstractions;

// váš předchozí kód...

public class ValidationChain : ChainHandler<MyRequest, MyResponse>
{
    public override async Task<MyResponse?> HandleAsync(MyRequest request)
    {
        if (string.IsNullOrEmpty(request.Data))
        {
            return Task.Run(() => new ValidationErrorResponse 
            { 
                Errors = new[] { "Data cannot be empty" } 
            });
        }
        return await base.HandleAsync(request);
    }
}

// pokračování vašeho kódu...

```

### Command

- Každý handler musí vrátit odpověď.
- Každý handler implementuje **ICommand<TRequest, TResponse>**.
	- **TRequest** třída požadavku, která prochází řetězcem.
	- **TResponse** třída odpovědi, kterou řetězec vrací.

```
using CoracLibrary.Contracts;

// váš předchozí kód...

public class MyRequestCommand : ICommand<MyRequest, MyResponse>
{
    public async Task<MyResponse?> ExecuteAsync(MyRequest request)
    {
		return Task.Run(() => new MyResponse { 
			ProcessedData = $"Processed: {request.Data}" 
		});
    }
}

// pokračování vašeho kódu...

```

### Coracl

#### Vytvoření řetězce a spuštění příkazu

- Metoda **.Delegate<TRequest, TResponse>()** zahajuje vytvoření řetězce.
	- **TRequest** třída požadavku, která prochází řetězcem.
	- **TResponse** třída odpovědi, kterou řetězec vrací.
- Metoda **.SetNext\<TChain\>()** nastaví článek řetězce (metoda se může opakovat).
	- **TChain** třída článku řetězce.
- Metoda **.ExecuteAsync()** spustí celý řetězec. Pokud řetězec vrátí nějakou odpověď, řetězec se přeruší (včetně "command") a odpověď se vrátí. V případě, že řetězec nic nevrací, provede se "command", který odpovídá třídám zadaných v **.Delegate<TRequest, TResponse>()** a implementaci handleru **ICommand<TRequest, TResponse>**.

```
// váš předchozí kód...

return await _coracl
    .Delegate<MyRequest, MyResponse>(new MyRequest())
    .SetNext<ValidationChain>()
    ...
    .ExecuteAsync();

// pokračování vašeho kódu...

```

## Autor

(c) 2024 vlasta81

## Licence

MIT
