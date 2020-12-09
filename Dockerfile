FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Innoscripta.Pizza/Innoscripta.Pizza.csproj", "Innoscripta.Pizza/"]
RUN dotnet restore "Innoscripta.Pizza/Innoscripta.Pizza.csproj"
COPY . .
WORKDIR "/src/Innoscripta.Pizza"
RUN dotnet build "Innoscripta.Pizza.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Innoscripta.Pizza.csproj" -c Release -o /app/publish

FROM node:12 AS front
WORKDIR /src-front
COPY Innoscripta.Pizza/ClientApp/package*.json ./
RUN npm install
COPY Innoscripta.Pizza/ClientApp/ .
RUN npm run build

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
COPY --from=front /src-front/build ./ClientApp/build

ENTRYPOINT ["dotnet", "Innoscripta.Pizza.dll"]
#COPY ./entrypoint.sh .
#RUN chmod +x ./entrypoint.sh
#CMD /bin/bash ./entrypoint.sh
