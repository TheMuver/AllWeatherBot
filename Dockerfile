﻿FROM mcr.microsoft.com/dotnet/sdk:5.0 AS builder
WORKDIR /sources

COPY . .
WORKDIR /sources/WeatherBotApi/
RUN dotnet restore
RUN dotnet publish --output /app/ --configuration Release

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=builder /app .
CMD ASPNETCORE_URLS=http://*:$PORT dotnet WeatherBotApi.dll