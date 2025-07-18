In this project:

**("I created the EntryNumber Column with UNIQUE Constraint, And added a surrogate key "id" as the the primary key of the table") --> As requested in the task that only EntryDate & EntryDescroption Are Required and the rest can be null !")**

- I followed a **3-layered architecture**: Presentation Layer, Business Logic Layer, and Data Access Layer - to ensure decoupling, maintainability, and testability.
- I applied design patterns including:
  - **Repository** – for maintainability, testability, and extensibility.
  - **Unit of Work** – to share a single `DbContext` instance and minimize repository registration.
  - **Dependency Injection** – to enforce the Inversion of Control (IoC) principle.
- I used tools and libraries such as:
  - **Entity Framework Core**
  - **Lazy Loading Proxies**
  - **AutoMapper**
  - **Swagger UI** (based on OpenAPI Specification v1).
  - **EF Core Power Tools**
- Enabled **CORS** to allow secure AJAX calls from the frontend.
- Focused on applying **SOLID principles** and **clean code** practices across all layers.
- Implemented **validation** based on business rules for all endpoints, with proper **exception handling** in controllers.
- Used a consistent **ResponseDTO** structure to ensure stability and predictability in client responses.
- Used **DTOs** across all endpoints to separate internal models from exposed data and prevent over-posting.
- Implemented **async operations** to ensure non-blocking I/O, better thread pool usage, and improved scalability.
- Used **Database-First approach** to scaffold entities directly from the existing SQL Server schema.
- Avoided using `IQueryable` as no filtering was required in the project scope.
- Used **EF Core Database-First approach** to scaffold entities directly from the existing SQL Server schema.
- Made A Global Using On Each Layer to Prevent Redundent Using Statments In Each File.
- A **SQL Server database backup (.bak)** is included in the **Data Access Layer (DAL)** for convenience.
