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
RUN dotnet publish Client/Client.csproj -c Release -o /app/publish --no-restore

FROM nginx:alpine AS final
COPY --from=build /app/publish/wwwroot /usr/share/nginx/html
COPY Client/nginx.conf /etc/nginx/conf.d/default.conf
EXPOSE 8080
CMD ["nginx", "-g", "daemon off;"]