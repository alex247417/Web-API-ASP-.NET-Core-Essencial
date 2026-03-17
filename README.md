# 🌐 Web API ASP.NET Core Essencial

API REST completa construída com **ASP.NET Core (.NET 8 / .NET 9)**, cobrindo os principais conceitos de desenvolvimento back-end moderno com C#. Projeto baseado no curso **Web API ASP.NET Core Essencial** do professor Macoratti.

## 🚀 Tecnologias

- C# / .NET 8 e .NET 9
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- JWT Authentication
- Swagger / OpenAPI
- AutoMapper

## ✨ O que foi implementado

- **CRUD completo** com Entity Framework e Code First
- **Autenticação JWT** — login, geração e validação de token
- **Filtros e paginação** de resultados
- **Tratamento de erros** global com middleware
- **DTOs e AutoMapper** para separação de camadas
- **Documentação Swagger** com suporte a autenticação

## 📦 Como rodar localmente

```bash
# Clone o repositório
git clone https://github.com/alex247417/Web-API-ASP-.NET-Core-Essencial.git
cd Web-API-ASP-.NET-Core-Essencial

# Restaure os pacotes
dotnet restore

# Configure a connection string em appsettings.json
# "ConnectionStrings": { "DefaultConnection": "sua_string_aqui" }

# Aplique as migrations
dotnet ef database update

# Execute
dotnet run
```

Acesse `https://localhost:5001/swagger` para explorar e testar os endpoints.

## 🗂 Estrutura do projeto

```
WebAPI/
├── Controllers/       # Endpoints da API
├── Models/            # Entidades
├── DTOs/              # ViewModels e mapeamentos
├── Repository/        # Padrão Repository
├── Data/              # DbContext e migrations
├── Filters/           # Filtros de ação
└── Program.cs
```

## 🔐 Autenticação

A API utiliza **JWT Bearer Token**. Para acessar endpoints protegidos:

1. Faça POST em `/api/auth/login` com suas credenciais
2. Copie o token retornado
3. Clique em **Authorize** no Swagger e cole `Bearer {token}`

## 👨‍💻 Autor

**Alecsandro da Silva Negrão Pascoal**  
[LinkedIn](https://linkedin.com/in/alecsandro-silva-dev) · [GitHub](https://github.com/alex247417)
