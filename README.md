# BRQ API Candidatos 0.0.1

- Infelizmente não tivemos tempo hábil para hospedar a API em uma cloud publica, mas para facilitar os testes publicamos uma imagem no DockerHub com o banco populado com 7 candidatos, para rodar a imagem faça os seguntes comandos:
`docker pull fbadaro/fiap.coffecup:brq-api`
`docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=Pwd@1234!" -p 1433:1433 -d fbadaro/fiap.coffecup:brq-api`
- Dentro da pasta Files contém o arquivo .json com toda documentação da API para ser importada para o Postman (https://www.postman.com/) e pronta para utilização, também há uma documentação da API funcionando.
- Já existe também os endpoints para criação de 7 Candidatos para testes na documentação da API.
- O projeto está feito com .net6 (https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
