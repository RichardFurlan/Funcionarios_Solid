# Estágio 1: Construção da aplicação .NET
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 5000

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Funcionarios_Solid.csproj", "."]
RUN dotnet restore "./Funcionarios_Solid.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "Funcionarios_Solid.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Funcionarios_Solid.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Estágio 2: Configuração do contêiner final
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Funcionarios_Solid.dll"]
