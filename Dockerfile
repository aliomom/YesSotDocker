
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
RUN apt-get update && apt-get install git
RUN git clone https://github.com/aliomom/YesSotDocker.git
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
