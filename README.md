# Booking Calendar

A Cal.com-like booking service built with ASP.NET Core, Blazor WebAssembly, and PostgreSQL.

[![hexlet-check](https://github.com/TuuTikkiYukka9/ai-for-developers-project-386/actions/workflows/hexlet-check.yml/badge.svg)](https://github.com/TuuTikkiYukka9/ai-for-developers-project-386/actions)

Educational project: https://ru.hexlet.io/programs/ai-for-developers

## Stack

- **Backend**: ASP.NET Core Web API (.NET 10)
- **Frontend**: Blazor WebAssembly (.NET 10)
- **Database**: PostgreSQL with Entity Framework Core
- **Architecture**: Clean architecture with Shared, Orm, Api, Client projects
- **Testing**: xUnit, bUnit, Microsoft.AspNetCore.Mvc.Testing

## Project Structure

```
BookingCalendar.sln
├── Api/              # ASP.NET Core Web API
├── Client/           # Blazor WebAssembly
├── Orm/              # EF Core data models & DbContext
├── Shared/           # Shared DTOs, interfaces, constants
├── Api.Tests/        # API integration tests
└── Client.Tests/     # Blazor component tests (bUnit)
```

## Getting Started

### Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- PostgreSQL (for full functionality)

### Installation

```bash
git clone https://github.com/TuuTikkiYukka9/ai-for-developers-project-386.git
cd ai-for-developers-project-386
dotnet restore
```

### Running the Projects

**Terminal 1 - API (runs on http://localhost:5000):**
```bash
dotnet run --project Api/BookingCalendar.Api.csproj
```

**Terminal 2 - Client (runs on http://localhost:5001):**
```bash
dotnet run --project Client/BookingCalendar.Client.csproj
```

### Running Tests

```bash
# Run all tests
dotnet test

# Run specific test project
dotnet test Api.Tests/BookingCalendar.Api.Tests.csproj
dotnet test Client.Tests/BookingCalendar.Client.Tests.csproj
```

## Development

### Database Migrations

```bash
# Add migration
dotnet ef migrations add <Name> --project Orm/BookingCalendar.Orm.csproj --startup-project Api/BookingCalendar.Api.csproj

# Update database
dotnet ef database update --project Orm/BookingCalendar.Orm.csproj --startup-project Api/BookingCalendar.Api.csproj
```

### Solution Management

```bash
# Add project to solution
dotnet sln add <ProjectPath>

# List projects in solution
dotnet sln list
```

---

<details>
<summary>Hexlet Auto-tests</summary>

Tests run on every commit. The `.github/workflows/hexlet-check.yml` file handles this — do not delete or rename it.

</details>

## About Hexlet

[Hexlet](https://ru.hexlet.io/) — programming school with hands-on programs, mentor support, and real projects for your portfolio.