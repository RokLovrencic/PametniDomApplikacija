# Use the official .NET SDK as the base image for building
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /app

EXPOSE 80

EXPOSE 443

# Copy the project files and restore dependencies
COPY . .
RUN dotnet restore

RUN dotnet dev-certs https

# Build the application
RUN dotnet build -c Release -o out

# Run the application using the built artifacts
CMD ["dotnet", "run", "--project", "PametniDomApplikacija.csproj"]
