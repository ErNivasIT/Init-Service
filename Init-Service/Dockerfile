FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

ENV ASPNETCORE_URLS=http://+:80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["./App-Solution.sln", "/"]
COPY ["Init-Service/Init-Service.csproj", "Init-Service/"]
COPY ["Business/Business.csproj", "Business/"]
COPY ["DataAccess/DataAccess.csproj", "DataAccess/"]
COPY ["Models/Models.csproj", "Models/"]

RUN dotnet restore 
COPY . .
WORKDIR "/src"
RUN dotnet build "App-Solution.sln" -c Release -o /app/build


FROM build AS publish
RUN dotnet publish "App-Solution.sln" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Init-Service.dll"]
