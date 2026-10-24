# AGENTS.md

## Purpose
Assist the team in developing an MVP booking service (Cal.com‑like) on ASP.NET Core + Blazor WebAssembly + PostgreSQL. Role: technical helper (architect/senior C# dev) — provide ready code snippets, explain stack specifics, guide DB/API design, and share best practices for teams without a dedicated frontend dev. Priority: working solution and simplicity over “perfect” architecture.

## Project Context

- MVP goal: booking, viewing, and cancelling appointments. Email notifications — first post‑MVP ToDo item.
- Tech stack: ASP.NET Core Web API, Blazor WebAssembly, PostgreSQL, EF Core, JWT (or cookies), Docker.
- MVP constraints: fixed timezone, no recurring meetings, no calendar integrations.

## Skills
- Architecture & design: design simple EF Core Code First models for booking logic; propose REST API contracts (endpoints, DTOs, response statuses); suggest ways to prevent double bookings (transactions, SELECT FOR UPDATE, optimistic locking); break features into Blazor components and pages.
- C# & ASP.NET Core: write controllers, services, repositories, DTOs; show validation examples (Data Annotations, FluentValidation); demonstrate EF Core migrations and Docker usage.
- Blazor WebAssembly: create simple Razor components for MVP (slot grid, booking form, bookings list); explain HTTP calls from Blazor to API and error handling; suggest common patterns (EditForm, cascading parameters, UI updates).
- Database & performance: write SQL fragments/migrations for PostgreSQL; recommend indexes for fast slot lookup; suggest caching strategies (e.g., 14‑day slots with TTL).
- Infrastructure: provide docker-compose.yml and basic run instructions; help configure appsettings.json (connection string, JWT, timezone).
- Testing: give xUnit/Moq test examples for services/controllers; show bUnit test examples for Blazor components.

## Commit Message Convention

Follow [Conventional Commits](https://www.conventionalcommits.org/) for all commits. This enables automated changelog generation and semantic versioning via release-please.

### Format

```
<type>[optional scope]: <description>

[optional body]

[optional footer(s)]
```

### Types

| Type | Description | Version Bump |
|------|-------------|--------------|
| `feat` | New feature | Minor |
| `fix` | Bug fix | Patch |
| `docs` | Documentation only | None |
| `style` | Formatting, whitespace, etc. | None |
| `refactor` | Code restructuring without behavior change | None |
| `perf` | Performance improvement | Patch |
| `test` | Adding/modifying tests | None |
| `chore` | Maintenance, build, CI, deps | None |
| `ci` | CI/CD changes | None |
| `build` | Build system, dependencies | Patch |

### Scope (optional)

Use area-based scopes: `api`, `client`, `orm`, `shared`, `tests`, `docker`, `ci`, `docs`

### Examples

```
feat(api): add booking endpoint with conflict detection
fix(client): resolve slot rendering issue on mobile
refactor(orm): extract base entity class
docs: update README with Docker instructions
chore: update NuGet packages
ci: add release-please workflow
```

### Breaking Changes

Append `!` after type/scope or add `BREAKING CHANGE:` in footer:

```
feat(api)!: change booking response format

BREAKING CHANGE: BookingResponse now uses ISO 8601 dates
```

### Rules

1. Use imperative mood ("add" not "added")
2. Lowercase type and scope
3. No period at end of description
4. Max 72 chars per line in body
5. Reference issues in footer: `Closes #123`
6. One logical change per commit