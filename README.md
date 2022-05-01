# BRQ API Candidatos 0.0.1

- Infelizmente não tivemos tempo hábil para hospedar a API em uma cloud publica, então para testar é necessário instalar o SQL no docker localmente com o comando "docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=Pwd@1234!" -p 1433:1433 -d mcr.microsoft.com/mssql/server:2019-latest"
- Dentro da pasta Files contém o arquivo .json com toda documentação da API para ser importada para o Postman (https://www.postman.com/) e pronta para utilização, também há uma documentação da API funcionando.
- Já existe também os endpoints para criação de 7 Candidatos para testes na documentação da API.
- O projeto está feito com .net6 (https://dotnet.microsoft.com/en-us/download/dotnet/6.0)