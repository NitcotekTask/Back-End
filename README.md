In this project:

- I used the 3 layered-archticture: BusinesLogicLayer - Presentation Layer - Data Acess Layer for decoupling and maintainability/testability
- I used Design patterns like: Repositories "For Maintainability And Testability and extensability" - UnitOfWork "For Sharing Only one DbContext and reducing Repos Registration" - Dependency Injection "For Applying Inversion Of Control".
- I used tools like : EF Core - Lazy Loading Proxies - AutoMapper - SwaggerUI that uses OpenAPI Documentation v1
- Enabled CORS for AJAX Calls
- I paid attention to be using SOLID Prinicpals and clean code across all the project
- I added validation throw all end points according to business rules & made exceptions handling in the controller
- Response DTO to ensure stability in response to the client side
- Used DTOs for all end points to ensure clean data sending to the client
- Used Async Operations To Ensure non blocking method calling and safe release of threads to thread pool so server can serve more requests, and for logic that needs concurrency
- There was no need to use IQueryable as there was no filtering happens on data.
- ConnectionString is found in appsettings.json
