#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["YesSoftWepApp/YesSoftWepApp.csproj", "YesSoftWepApp/"]
RUN dotnet restore "YesSoftWepApp/YesSoftWepApp.csproj"
COPY . .
WORKDIR "/src/YesSoftWepApp"
RUN dotnet build "YesSoftWepApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "YesSoftWepApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "YesSoftWepApp.dll"]