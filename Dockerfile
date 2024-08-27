
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /App

COPY . ./

RUN dotnet restore "biblioteca.csproj"

RUN dotnet publish "biblioteca.csproj" -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /App

COPY --from=build-env /App/out .

ARG PORT_BUILD=80
ENV ASPNETCORE_URLS=http://*:$PORT_BUILD

EXPOSE $PORT_BUILD

ENTRYPOINT ["dotnet", "biblioteca.dll"]
