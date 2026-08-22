# PresentShop

> An online gift shop where customers can choose from curated present boxes or build their own using available products.

---

## Tech Stack

| Layer | Technology |
|-------|-----------|
| Backend | .NET 10, ASP.NET Core Web API |
| Authentication | ASP.NET Core Identity |
| Database | MSSQL, Entity Framework Core |
| Frontend | React |
| Testing | xUnit |

---

## Project Structure

- **PresentShop.API** — HTTP layer. Handles requests and returns JSON responses
  - `Controllers/` — API endpoints
  - `Middleware/` — Global error handling, CORS
  - `Program.cs` — App configuration and dependency injection

- **PresentShop.Core** — Heart of the application. Pure C# with no external dependencies
  - `Entities/` — Domain models (Box, Item, Cart, Order)
  - `Interfaces/` — Repository and service contracts
  - `DTOs/` — Data shapes for API responses and requests

- **PresentShop.Infrastructure** — Data access layer. Implements Core interfaces
  - `Data/` — AppDbContext and migrations
  - `Repositories/` — Database query implementations
  - `Services/` — Business logic implementations

- **PresentShop.Tests** — Unit tests for services and repositories

---

## Key Feature — Volume Logic

Each item in the shop has three physical dimensions (length, width, height).
Each box has a maximum volume capacity defined by its size (XS through XXL).
The system automatically calculates whether selected items fit inside the chosen box,
preventing impossible orders.

> Planned for a future release: visual packing representation showing exactly
> how items are arranged inside the box based on their physical dimensions.

---

## Getting Started

Coming soon)
