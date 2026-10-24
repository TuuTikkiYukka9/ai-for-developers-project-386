# Simple Booking Service (MVP) — Blazor WASM

Упрощённый сервис бронирования времени (аналог Cal.com) на стеке ASP.NET Core + Blazor WebAssembly.  
MVP: бронирование, просмотр и отмена записей. Email‑рассылка запланирована как первый этап после MVP.

## Цели
- Быстрый запуск MVP для демонстрации концепции.
- Единый язык C# для бэкенда и фронтенда.
- Простая архитектура, удобная для команды без выделенного фронтенд‑разработчика.
- Лёгкое расширение: часовые пояса, календари, повторные встречи.

## Функционал MVP
- Создание/редактирование типов встреч (название, длительность).
- Настройка доступности по дням недели.
- Просмотр свободных слотов на 14 дней вперёд.
- Бронирование встречи (имя, email).
- Просмотр списка бронирований.
- Отмена бронирования.

## ToDo (приоритеты)
1. Email‑рассылка (подтверждение и отмена).
2. Выбор часового пояса владельцем.
3. Интеграция с Google/Outlook календарём.
4. Повторные встречи (recurrence).
5. Расширенные уведомления (SMS, Telegram).

## Стек
- Backend: ASP.NET Core Web API (C#)
- Frontend: Blazor WebAssembly (C#)
- Shared: DTO и общие типы
- Database: PostgreSQL + Entity Framework Core
- Auth: JWT (владелец), гость — без авторизации
- Deployment: Docker, docker-compose, Nginx
- Testing: xUnit, Moq, bUnit

## Структура проекта
- `src/BookingService.Api` — API контроллеры, сервисы, конфигурация.
- `src/BookingService.Client` — Blazor компоненты, страницы, логика UI.
- `src/BookingService.Data` — EF Core DbContext, миграции, модели БД.
- `src/BookingService.Shared` — DTO, контракты API, общие типы.
- `tests/` — модульные и интеграционные тесты.

## Быстрый старт

1. Установите Docker Desktop.
2. В корне проекта выполните:
   ```bash
   docker compose up -d
