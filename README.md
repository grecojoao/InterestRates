# API - Taxa de Juros
[![NPM](https://img.shields.io/npm/l/react)](https://github.com/grecojoao/InterestRates/blob/master/LICENSE) 

## ⚡ Sobre o projeto

API taxa de juros é uma aplicação back-end desenvolvida para o fornecimento da taxa de juros a outras aplicações.

A aplicação consiste no Endpoint: "/taxajuros", que é responsável por retornar a taxa de juros.

https://interestrates.azurewebsites.net/taxajuros


![Alt Text](https://res.cloudinary.com/grecojoao/image/upload/v1621782901/taxajuros_vwocn5.gif)


## :rocket: Tecnologias
- C#, ASP.NET Core(5.0)
- Docker

## :bomb: Implantação em produção
- [Microsoft Azure](https://interestrates.azurewebsites.net/swagger)

## 📝 Como executar o projeto
Pré-requisitos: 
- ASP.NET Core Runtime 5.0.6 ou 
- SDK 5.0.203(desenvolvimento)

````bash
# clonar o repositório
git clone https://github.com/grecojoao/InterestRates.git

# entrar na pasta da API
cd InterestRates/InterestRates.API

# executar o projeto
dotnet watch run
````

- Windows: Docker Desktop WSL 2
- Linux: Docker Desktop

````bash
# clonar a imagem docker
docker pull grecojoao/interestratesapi

# executar a imagem docker
docker run grecojoao/interestratesapi
````
