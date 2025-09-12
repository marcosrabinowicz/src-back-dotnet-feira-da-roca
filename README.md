# 🐴 Feira da Roça API (.NET + EF Core + SQLite)

API RESTful desenvolvida com ASP.NET Core, Entity Framework Core e SQLite, no melhor estilo raiz do interior.  
Gerencia **feirantes** e os **produtos** que cada um vende.

---

## 🚀 Funcionalidades atuais

- Cadastro, listagem, edição e exclusão de **Feirantes**
- Cadastro, listagem, edição e exclusão de **Produtos**
- Relacionamento 1:N: **Um Feirante → Muitos Produtos**
- Banco de dados **SQLite** persistente
- Camadas organizadas: `Controller → Service → Repository`
- Testes via **Postman Collection** incluída no projeto

---

## 🔧 Tecnologias utilizadas

- .NET 8 (preview)
- ASP.NET Core Web API
- Entity Framework Core
- SQLite
- C# moderno (records, construtores enxutos)

---

## 📦 Endpoints principais

### Feirantes

- `GET /feirantes`
- `GET /feirantes/{id}`
- `POST /feirantes`
- `PUT /feirantes/{id}`
- `DELETE /feirantes/{id}`

### Produtos

- `GET /produtos`
- `GET /produtos/{id}`
- `POST /produtos`
- `PUT /produtos/{id}`
- `DELETE /produtos/{id}`

---

## 🧪 Como testar

1. Rode o projeto com:

   ```bash
   dotnet run

   ```

2. Use o Postman com a collection:
   feira-da-roca-api.postman_collection.json

✅ Estrutura do Projeto

FeiraDaRoca/
├── Controllers/
├── Services/
├── Repositories/
├── Models/
├── Data/
├── Program.cs
├── feira-da-roca-api.postman_collection.json
└── README.md

🧱 Conclusão do Ciclo 4 – Estradão Batido

- Separação completa em camadas (Service, Repository)
- Teste bem-sucedido do endpoint GET /produtos
- Refatoração limpa e funcional da lógica de negócio
- Tudo funcionando com persistência em SQLite
- Testado com Postman

🐞 Pendências para próximos ciclos

- Corrigir o problema do campo Feirante vindo null após POST /produtos
- Corrigir GET /feirantes para incluir produtos na resposta (Include)
- Adicionar documentação Swagger
- Adicionar validações com DataAnnotations

🛠️ Próximos passos

- Separar camadas de Feirante (service e repository)
- Implementar filtros e paginação (ex: por cidade)
- Criar testes automatizados com xUnit
- Criar DTOs ou usar AutoMapper
- Criar frontend simples em React ou Vue

🤠 Autor
Desenvolvido com 💙 por Marcos Rabinowicz
Feito na roça, com café coado, queijo na chapa e .NET na alma ☕🐴
