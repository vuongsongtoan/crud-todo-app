# Build stage
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copy csproj and restore dependencies (better caching)
COPY ["CRUDTodoApp.csproj", "."]
RUN dotnet restore "CRUDTodoApp.csproj"

# Copy source code and build
COPY . .
RUN dotnet publish "CRUDTodoApp.csproj" -c Release -o /app/publish --no-restore

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final

# Create non-root user for security
RUN groupadd -r todoapp && useradd --no-log-init -r -g todoapp todoapp

# Set working directory
WORKDIR /app

# Copy published app
COPY --from=build /app/publish .

# Change ownership to non-root user
RUN chown -R todoapp:todoapp /app
USER todoapp

# Configure environment
ENV ASPNETCORE_URLS=http://+:8080
ENV ASPNETCORE_ENVIRONMENT=Production

# Health check
HEALTHCHECK --interval=30s --timeout=3s --start-period=5s --retries=3 \
    CMD curl -f http://localhost:8080/health || exit 1

# Expose port
EXPOSE 8080

# Start application
ENTRYPOINT ["dotnet", "CRUDTodoApp.dll"]
