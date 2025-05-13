# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copia o csproj e restaura dependências
COPY ["ConsolidationApi.csproj", "./"]
RUN dotnet restore "ConsolidationApi.csproj"

# Copia o restante do código e publica em Release
COPY . .
RUN dotnet publish -c Release -o /app

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Copia artefatos compilados
COPY --from=build /app .

# Ponto de entrada
ENTRYPOINT ["dotnet", "ConsolidationApi.dll"]