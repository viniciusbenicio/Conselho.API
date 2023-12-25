# Conselho API

O **Conselho API** é uma Web API desenvolvida em C# utilizando .NET 6, com o propósito de consumir APIs externas. Ela gera conselhos de vida aleatórios através da [Advice Slip API](https://api.adviceslip.com/) e realiza a tradução destes conselhos do inglês para o português utilizando a [MyMemory Translation API](https://mymemory.translated.net/doc/spec.php). Os conselhos traduzidos são enviados por e-mail utilizando o serviço [SendGrid](https://sendgrid.com/). Esta API permite que você crie um usuário informando Nome e E-mail.

## Índice

- [Visão Geral](#visão-geral)
- [Motivação](#motivação)
- [Construído Com](#construído-com)
- [Recursos](#recursos)
- [Como Usar](#como-usar)
- [Exemplos](#exemplos)
- [Desenvolvedor](#desenvolvedor)

## 📚 Visão Geral

O Conselho API possibilita a geração de conselhos consumindo duas APIs de terceiros, a [Advice Slip API](https://api.adviceslip.com/) e a [MyMemory Translation API](https://mymemory.translated.net/doc/spec.php). Os conselhos traduzidos para o português são enviados automaticamente por e-mail utilizando o serviço de envio de e-mails [SendGrid](https://sendgrid.com/). **É importante destacar que os conselhos gerados não devem ser levados totalmente a sério, pois podem ser aleatórios e não fazer sentido para todos os usuários.**

## 🚀 Motivação

Este projeto tem como objetivo aplicar técnicas e consolidar aprendizados adquiridos em diversos cursos na área de programação, especialmente em C#/.NET.

## ⚙️ Construído Com

- .NET 6
- SQL Server
- Swagger
- Entity Framework
- AspNetCore
- Newtonsoft.Json
- RestSharp
- SendGrid

## 🔧 Recursos

- **Criação de Usuário:** Crie um usuário informando nome e e-mail.
- **Atualização de Usuário:** Atualize um usuário existente.
- **Consulta de Usuário:** Consulte os usuários cadastrados.
- **Remoção de Usuários:** Exclua os usuários cadastrados.

## 📝 Como Usar

Realize o download do arquivo e abra-o utilizando o Postman para realizar as requisições.

## 🌐 Exemplos

![Exemplo 1](link-da-imagem-1)
![Exemplo 2](link-da-imagem-2)
![Exemplo 3](link-da-imagem-3)

## 👨‍💻 Desenvolvedor

- Vinicius Benicio de Santana: [LinkedIn](https://www.linkedin.com/in/viniciusbenicio/)
