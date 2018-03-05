echo "Para utilizar esse script é necessario ter instalado em seu ambiente os seguintes componentes:"
echo "- Ferramentas para compilação do dotnet core"
echo "- Visual Studio 2017"
echo "- dotnet core sdk 2.1.x"
echo "- dotnet cli 2.1.x"
echo "- iis express"
echo "É necessário ja ter executado as migrations."
echo "---------------------------------------------"
echo "Caso não consiga executar pelo script você pode utilizar o visual studio:"
echo '- Defina o ambiente como desenvolvimento com o comando: setx ASPNETCORE_ENVIRONMENT "Development"'
echo "- Execute a aplicação utilizando o IIS Express."
echo "---------------------------------------------"
echo "Restaurando pacotes nuget..."
dotnet restore
echo "---------------------------------------------"
echo "Setando variavel de ambiente ASPNETCORE_ENVIRONMENT..."
setx ASPNETCORE_ENVIRONMENT "Development"
echo "---------------------------------------------"
echo "Executando a aplicacao..."
dotnet run --project Livraria.WebApi/Livraria.WebApi.csproj

read -p "Press any key to continue... " -n1 -s