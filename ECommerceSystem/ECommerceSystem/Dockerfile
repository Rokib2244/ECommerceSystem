FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
RUN apt-get update && apt-get install -y nodejs
COPY ["ECommerceSystem/*.csproj", "ECommerceSystem/"]
COPY ["ECommerceSystem.Data/*.csproj", "ECommerceSystem.Data/"]
COPY ["ECommerceSystem.Common/*.csproj", "ECommerceSystem.Common/"]
COPY ["ECommerceSystem.Membership/*.csproj", "ECommerceSystem.Membership/"]
COPY ["ECommerceSystem.Training/*.csproj", "ECommerceSystem.Training/"]
RUN dotnet restore "ECommerceSystem/ECommerceSystem.csproj"
COPY . .
WORKDIR "/src/ECommerceSystem"
RUN dotnet build "ECommerceSystem.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "ECommerceSystem.csproj" -c Release -o /app

FROM build AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ECommerceSystem.dll"]