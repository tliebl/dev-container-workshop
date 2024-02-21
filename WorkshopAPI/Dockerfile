FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS build
RUN dotnet tool install -g dotnet-reportgenerator-globaltool
ENV PATH="${PATH}:/root/.dotnet/tools"
WORKDIR /app
COPY ["./WorkshopAPI.csproj", "."]
RUN dotnet restore "./WorkshopAPI.csproj"
COPY . .

# Publish dotnet artifacts to /app/out directory
RUN dotnet publish -c release -o /app/out -v minimal

FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine
RUN apk add icu-libs
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false

# Set up the Timezone details for the Container.
RUN apk add --no-cache tzdata
ENV TZ UTC
RUN ln -snf /usr/share/zoneinfo/$TZ /etc/localtime && echo $TZ > /etc/timezone
WORKDIR /app
COPY --from=build /app/out ./
ENTRYPOINT [ "dotnet", "WorkshopAPI.dll" ]
