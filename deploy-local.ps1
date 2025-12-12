# BookStack Local Docker Deployment Script
# This script builds and runs BookStack in Docker locally

Write-Host "=====================================" -ForegroundColor Cyan
Write-Host "  BookStack Docker Deployment" -ForegroundColor Cyan
Write-Host "=====================================" -ForegroundColor Cyan
Write-Host ""

# Check if Docker is running
Write-Host "Checking Docker..." -ForegroundColor Yellow
docker --version
if ($LASTEXITCODE -ne 0) {
    Write-Host "Error: Docker is not installed or not running" -ForegroundColor Red
    Write-Host "Please install Docker Desktop from https://www.docker.com/products/docker-desktop" -ForegroundColor Red
    exit 1
}

Write-Host "Docker is ready!" -ForegroundColor Green
Write-Host ""

# Create data directory for SQLite
Write-Host "Creating data directory..." -ForegroundColor Yellow
if (-not (Test-Path ".\data")) {
    New-Item -ItemType Directory -Path ".\data" | Out-Null
}
Write-Host "Data directory ready!" -ForegroundColor Green
Write-Host ""

# Build Docker image
Write-Host "Building Docker image..." -ForegroundColor Yellow
docker build -t bookstack:latest .
if ($LASTEXITCODE -ne 0) {
    Write-Host "Error: Failed to build Docker image" -ForegroundColor Red
    exit 1
}
Write-Host "Docker image built successfully!" -ForegroundColor Green
Write-Host ""

# Stop existing container if running
Write-Host "Stopping existing container (if any)..." -ForegroundColor Yellow
docker stop bookstack-container 2>$null
docker rm bookstack-container 2>$null
Write-Host ""

# Run container
Write-Host "Starting BookStack container..." -ForegroundColor Yellow
docker run -d `
    --name bookstack-container `
    -p 8080:8080 `
    -v "${PWD}/data:/app/data" `
    -e ASPNETCORE_ENVIRONMENT=Production `
    bookstack:latest

if ($LASTEXITCODE -ne 0) {
    Write-Host "Error: Failed to start container" -ForegroundColor Red
    exit 1
}

Write-Host ""
Write-Host "=====================================" -ForegroundColor Green
Write-Host "  BookStack is now running!" -ForegroundColor Green
Write-Host "=====================================" -ForegroundColor Green
Write-Host ""
Write-Host "Access the application at: http://localhost:8080" -ForegroundColor Cyan
Write-Host ""
Write-Host "Useful commands:" -ForegroundColor Yellow
Write-Host "  - View logs:     docker logs -f bookstack-container" -ForegroundColor White
Write-Host "  - Stop app:      docker stop bookstack-container" -ForegroundColor White
Write-Host "  - Start app:     docker start bookstack-container" -ForegroundColor White
Write-Host "  - Remove app:    docker stop bookstack-container && docker rm bookstack-container" -ForegroundColor White
Write-Host ""

# Wait a moment and show logs
Start-Sleep -Seconds 3
Write-Host "Container logs:" -ForegroundColor Yellow
docker logs bookstack-container
