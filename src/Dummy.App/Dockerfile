FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/Dummy.App/Dummy.App.csproj", "Dummy.App/"]
RUN dotnet restore "src/Dummy.App/Dummy.App.csproj"
COPY . .
WORKDIR "/src/Dummy.App"
RUN dotnet build "Dummy.App.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Dummy.App.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Dummy.App.dll"]
