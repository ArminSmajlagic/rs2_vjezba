#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Seminarski_RS2/Seminarski_RS2.csproj", "Seminarski_RS2/"]
RUN dotnet restore "Seminarski_RS2/Seminarski_RS2.csproj"
COPY . .
WORKDIR "/src/Seminarski_RS2"
RUN dotnet build "Seminarski_RS2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Seminarski_RS2.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Seminarski_RS2.dll"]