FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 63005
EXPOSE 44325

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY AspNet21-Swagger/AspNet21-Swagger.csproj AspNet21-Swagger/
RUN dotnet restore AspNet21-Swagger/AspNet21-Swagger.csproj
COPY . .
WORKDIR /src/AspNet21-Swagger
RUN dotnet build AspNet21-Swagger.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish AspNet21-Swagger.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "AspNet21-Swagger.dll"]
