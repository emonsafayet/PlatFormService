FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
ENV ASPNETCORE_URLS=http://+:80  
EXPOSE 80
# Copy csproj and restore as distinct layers

COPY ["PlatFormService/*.csproj", "PlatFormService/"]
RUN dotnet restore "PlatFormService/PlatFormService.csproj"

# Copy everything else and build

COPY . .
WORKDIR "/src/PlatFormService"
RUN dotnet build "PlatFormService.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "PlatFormService.csproj" -c Release -o /app

FROM build AS final
WORKDIR /app
COPY --from=publish /app .

ENTRYPOINT ["dotnet", "PlatFormService.dll"]

