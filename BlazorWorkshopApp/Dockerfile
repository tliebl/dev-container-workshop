FROM nginx:alpine AS base
EXPOSE 80
EXPOSE 443

# Stage 1: Build the application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy csproj and restore as distinct layers
COPY ["BlazorWorkshopApp.csproj", "BlazorWorkshopApp/"]
RUN dotnet restore "BlazorWorkshopApp/BlazorWorkshopApp.csproj"

WORKDIR "/src/BlazorWorkshopApp"
# Copy everything else and build
COPY . .
RUN dotnet build "BlazorWorkshopApp.csproj" -c Release -o /app/build

# Publish
RUN dotnet publish "BlazorWorkshopApp.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Stage 2: Serve the application using Nginx
FROM base AS final
# Copy static assets from builder stage
COPY --from=build /app/publish/wwwroot /usr/share/nginx/html
COPY --from=build /src/BlazorWorkshopApp/container_setup/nginx.conf /etc/nginx/nginx.conf
COPY --from=build /src/BlazorWorkshopApp/container_setup/setup.sh /usr/share/nginx/html/setup.sh

CMD /bin/sh /usr/share/nginx/html/setup.sh
