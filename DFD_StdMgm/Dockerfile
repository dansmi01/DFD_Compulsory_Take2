FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["DFD_StdMgm/DFD_StdMgm.csproj", "DFD_StdMgm/"]
RUN dotnet restore "DFD_StdMgm/DFD_StdMgm.csproj"
COPY . .
WORKDIR "/src/DFD_StdMgm"
RUN dotnet build "DFD_StdMgm.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "DFD_StdMgm.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DFD_StdMgm.dll"]
