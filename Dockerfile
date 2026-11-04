FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY CvBuilder.sln .
COPY CvBuilder/*.csproj ./CvBuilder/
RUN dotnet restore
COPY . .
WORKDIR /src/CvBuilder
RUN dotnet publish -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
ENV ASPNETCORE_URLS=http://+:10000
EXPOSE 10000
ENTRYPOINT ["dotnet", "CvBuilder.dll"]
