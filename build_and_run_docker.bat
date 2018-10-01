dotnet restore
dotnet publish -c Release -o out
cd ./docker-test
docker build -t docker-test .
docker run --rm docker-test docker-te