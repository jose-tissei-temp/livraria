echo "Para utilizar esse script é necessario ter instalado em seu ambiente os seguintes componentes:"
echo "- Ferramentas para compilação do dotnet core"
echo "- Visual Studio 2017"
echo "- dotnet core sdk 2.1.x"
echo "- dotnet cli 2.1.x"
echo "- iis express"
echo "Também é necessário ja ter executado as migrations."
dotnet restore
dotnet run --project Livraria.WebApi/Livraria.WebApi.csproj

read -p "Press any key to continue... " -n1 -s