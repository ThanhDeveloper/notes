- The mediator pattern is a behavioral design pattern that allows for loose coupling between objects by using a mediator object to coordinate communication between them.
- With MediatR, developers can easily implement the mediator pattern in their codebase by defining commands and queries as simple C# classes, and then registering them with the Mediator.
- Commands represent actions that should be performed by the system, while queries represent requests for data.
- Separation of logical and business execution

=> Send request => command handler (inherit IRequest interface)=> execute action

![image](https://user-images.githubusercontent.com/48196420/221787067-a62255b8-b36d-4ae0-9870-e9ce83a49680.png)
