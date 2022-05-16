# global arg to make available for all stages
ARG buildProject=FortCode
ARG publishOutputDir=publishedOutput

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build


# redefine for use in stage
ARG buildProject
ARG publishOutputDir

WORKDIR /app

# copy everything else and build app
COPY . ./FortCode/
WORKDIR /app/FortCode/$buildProject
RUN dotnet publish -c Release -o $publishOutputDir


FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS runtime

# redefine for use in stage
ARG buildProject
ARG publishOutputDir

WORKDIR /app
COPY --from=build /app/FortCode/$buildProject/$publishOutputDir .
ENV ASPNETCORE_URLS="http://+"

RUN touch appExecutor.sh
RUN echo "dotnet ${buildProject}.dll" >> appExecutor.sh
RUN chmod +x appExecutor.sh
ENTRYPOINT ./appExecutor.sh
