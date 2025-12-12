#!/bin/bash
# BookStack Local Docker Deployment Script
# This script builds and runs BookStack in Docker locally

echo "====================================="
echo "  BookStack Docker Deployment"
echo "====================================="
echo ""

# Check if Docker is running
echo "Checking Docker..."
docker --version
if [ $? -ne 0 ]; then
    echo "Error: Docker is not installed or not running"
    echo "Please install Docker from https://www.docker.com/products/docker-desktop"
    exit 1
fi

echo "Docker is ready!"
echo ""

# Create data directory for SQLite
echo "Creating data directory..."
mkdir -p ./data
echo "Data directory ready!"
echo ""

# Build Docker image
echo "Building Docker image..."
docker build -t bookstack:latest .
if [ $? -ne 0 ]; then
    echo "Error: Failed to build Docker image"
    exit 1
fi
echo "Docker image built successfully!"
echo ""

# Stop existing container if running
echo "Stopping existing container (if any)..."
docker stop bookstack-container 2>/dev/null
docker rm bookstack-container 2>/dev/null
echo ""

# Run container
echo "Starting BookStack container..."
docker run -d \
    --name bookstack-container \
    -p 8080:8080 \
    -v "$(pwd)/data:/app/data" \
    -e ASPNETCORE_ENVIRONMENT=Production \
    bookstack:latest

if [ $? -ne 0 ]; then
    echo "Error: Failed to start container"
    exit 1
fi

echo ""
echo "====================================="
echo "  BookStack is now running!"
echo "====================================="
echo ""
echo "Access the application at: http://localhost:8080"
echo ""
echo "Useful commands:"
echo "  - View logs:     docker logs -f bookstack-container"
echo "  - Stop app:      docker stop bookstack-container"
echo "  - Start app:     docker start bookstack-container"
echo "  - Remove app:    docker stop bookstack-container && docker rm bookstack-container"
echo ""

# Wait a moment and show logs
sleep 3
echo "Container logs:"
docker logs bookstack-container
