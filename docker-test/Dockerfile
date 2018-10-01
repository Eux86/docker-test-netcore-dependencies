FROM microsoft/dotnet:2.1-runtime

COPY ./out /out
WORKDIR /out
ENTRYPOINT ["dotnet", "docker-test.dll"]