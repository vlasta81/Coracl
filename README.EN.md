**C**hain **o**f **R**esponsibility **a**nd **C**ommand **L**ibrary

# CORACL (CoracLibrary)

A simple .NET 8 library implementing the *Chain of Responsibility* and *Command* patterns.

## Main Features

- Implementation of the *Chain of Responsibility* design pattern
- Support for asynchronous processing
- Fluent API for easy chain configuration
- Automatic handler registration using dependency injection
- Implementation of the *Command* design pattern for final request processing

## Download

The current library can be downloaded here: **DOWNLOAD**.

## Installation

In Visual Studio, add a reference to the dll library **CoracLibrary.dll**.

## Usage

### Program.cs

```
using CoracLibrary.Extensions;

... // your previous code...

builder.Services.AddCoracl(typeof(Program).Assembly);

... // your next code...
```

### Controller

```
using CoracLibrary.Contracts;

... // your previous code...

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
        
... // your next code...
```

## Chain of Responsibility and Command

### ChainHandler

- Each handler can return a response or pass the request to the next in line.
- Each handler implements **ChainHandler<TRequest, TResponse>**.
	- **TRequest** is the request class that passes through the chain.
	- **TResponse** is the response class that the chain returns.
- Each handler overrides the **HandleAsync** method from the abstract **ChainHandler** class.
- To call the next link in the chain: (see example) **return await base.HandleAsync(request);**.
- The chain can also be interrupted at any link if the handler returns null. The command is then executed and the response is returned.

```
using CoracLibrary.Abstractions;

// your previous code...

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

// your next code...

```

### Command

- Each handler must return a response.
- Each handler implements **ICommand<TRequest, TResponse>**.
	- **TRequest** is the request class that passes through the chain.
	- **TResponse** is the response class that the chain returns.

```
using CoracLibrary.Contracts;

// your previous code...

public class MyRequestCommand : ICommand<MyRequest, MyResponse>
{
    public async Task<MyResponse?> ExecuteAsync(MyRequest request)
    {
		return Task.Run(() => new MyResponse { 
			ProcessedData = $"Processed: {request.Data}" 
		});
    }
}

// your next code...

```

### Coracl

#### Creating a Chain and Executing a Command

- The **.Delegate<TRequest, TResponse>()** method initiates the creation of the chain.
	- **TRequest** is the request class that passes through the chain.
	- **TResponse** is the response class that the chain returns.
- The **.SetNext\<TChain\>()** method sets the chain link (the method can be repeated).
	- **TChain** is the chain link class.
- The **.ExecuteAsync()** method runs the entire chain. If the chain returns a response, the chain (including the command) is interrupted and the response is returned. If the chain returns nothing, the command corresponding to the classes specified in **.Delegate<TRequest, TResponse>()** and the handler implementation **ICommand<TRequest, TResponse>** is executed.

```
// your previous code...

return await _coracl
    .Delegate<MyRequest, MyResponse>(new MyRequest())
    .SetNext<ValidationChain>()
    ...
    .ExecuteAsync();

// your next code...

```

## Author

(c) 2024 vlasta81

## License

MIT
