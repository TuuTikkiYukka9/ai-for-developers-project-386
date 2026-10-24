FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

COPY *.slnx .
COPY Directory.Build.props .
COPY Api/Api.csproj Api/
COPY Client/Client.csproj Client/
COPY Orm/Orm.csproj Orm/
COPY Shared/Shared.csproj Shared/
COPY Api.Tests/Api.Tests.csproj Api.Tests/
COPY Client.Tests/Client.Tests.csproj Client.Tests/

RUN dotnet restore

COPY . .
RUN dotnet publish Api/Api.csproj -c Release -o /app/publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app
EXPOSE 8080

COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "BookingCalendar.Api.dll"]