FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["LeetCodeExam.csproj", "./"]
RUN dotnet restore "LeetCodeExam.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "LeetCodeExam.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LeetCodeExam.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LeetCodeExam.dll"]
