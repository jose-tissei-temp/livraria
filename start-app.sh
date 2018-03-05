cd Livraria.UI/
echo "Para utilizar esse script é necessario ter instalado em seu ambiente os seguintes componentes:"
echo "- nodejs"
echo "- npm"
echo "- @angular-cli"
echo "----------------------------------------------------"
echo "Instalando pacotes..."
npm install
echo "----------------------------------------------------"
echo "Iniciando aplicacao..."
ng serve
read -p "Press any key to continue... " -n1 -s