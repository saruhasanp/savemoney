#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# Build Stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Copy only the .csproj file to restore dependencies
COPY SaveMoney.API.csproj ./
RUN dotnet restore SaveMoney.API.csproj

# Copy the rest of the source code
COPY . ./
RUN dotnet publish -c $BUILD_CONFIGURATION -o /app

# Runtime Stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app .

# Expose the ports
EXPOSE 8080
EXPOSE 8081


ENTRYPOINT ["dotnet", "SaveMoney.API.dll"]


##See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.
#
#FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
#USER app
#WORKDIR /app
#EXPOSE 8080
#EXPOSE 8081
#
#FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
#ARG BUILD_CONFIGURATION=Release
#WORKDIR /src
#COPY ["SaveMoney.API/SaveMoney.API.csproj", "SaveMoney.API/"]
#RUN dotnet restore "./SaveMoney.API/SaveMoney.API.csproj"
#COPY . .
#WORKDIR "/src/SaveMoney.API"
#RUN dotnet build "./SaveMoney.API.csproj" -c $BUILD_CONFIGURATION -o /app/build
#
#FROM build AS publish
#ARG BUILD_CONFIGURATION=Release
#RUN dotnet publish "./SaveMoney.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "SaveMoney.API.dll"]