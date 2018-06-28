FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk-nanoserver-1709 AS build
WORKDIR /src
COPY ImdsApi/ImdsApi.csproj ImdsApi/
RUN dotnet restore ImdsApi/ImdsApi.csproj
COPY . .
WORKDIR /src/ImdsApi
RUN dotnet build ImdsApi.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish ImdsApi.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ImdsApi.dll"]
