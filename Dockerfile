# Build stage
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copy csproj and restore dependencies
COPY BookStack.Web/BookStack.Web.csproj BookStack.Web/
RUN dotnet restore "BookStack.Web/BookStack.Web.csproj"

# Copy everything else and build
COPY BookStack.Web/ BookStack.Web/
WORKDIR "/src/BookStack.Web"
RUN dotnet build "BookStack.Web.csproj" -c Release -o /app/build

# Publish stage
FROM build AS publish
RUN dotnet publish "BookStack.Web.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

# Copy published app
COPY --from=publish /app/publish .

# Set environment to production
ENV ASPNETCORE_ENVIRONMENT=Production
ENV ASPNETCORE_URLS=http://+:8080

# Create directory for SQLite database
RUN mkdir -p /app/data

ENTRYPOINT ["dotnet", "BookStack.Web.dll"]
