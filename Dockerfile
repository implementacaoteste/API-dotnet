# Usa a imagem oficial do SDK do ASP.NET Core para compilar o aplicativo
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /app

COPY . ./
RUN dotnet restore

RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/out ./

ENV ASPNETCORE_URLS http://*:5000
EXPOSE 5000

# Inicia o aplicativo
ENTRYPOINT ["dotnet", "API/API.dll"]

