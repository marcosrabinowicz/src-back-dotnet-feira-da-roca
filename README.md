# 🐴 Feira da Roça API (.NET + EF Core + SQLite)

API RESTful desenvolvida com ASP.NET Core, Entity Framework Core e SQLite, no melhor estilo raiz do interior.  
Gerencia **feirantes** e os **produtos** que cada um vende.

---

## 🚀 Funcionalidades atuais

- Cadastro, listagem, edição e exclusão de **Feirantes**
- Cadastro, listagem, edição e exclusão de **Produtos**
- Relacionamento 1:N: **Um Feirante → Muitos Produtos**
- Banco de dados **SQLite** persistente
- Código limpo com async/await e boas práticas

---

## 🔧 Tecnologias utilizadas

- .NET 9 (preview)
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
Acesse a API com Postman ou Insomnia

Exemplo de cadastro de produto:

json
Copiar
Editar
POST /produtos
{
  "nome": "Queijo Minas Frescal",
  "preco": 22.90,
  "feiranteId": 1
}
📘 Próximos passos
 Separar em camadas (Controller → Service → Repository)

 Adicionar validações com DataAnnotations

 Documentar com Swagger

 Implementar paginação e filtros avançados

 Criar testes automatizados com xUnit

 Subir para deploy no GitHub Pages + GitHub Actions (ou outro)

 Criar um frontend Angular para consumo da API

🤠 Autor
Desenvolvido com 💙 por Marcos Rabinowicz
Feito na roça, com café coado, queijo na chapa e .NET na alma ☕🐴