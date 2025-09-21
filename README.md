# Feira da Roça API

API simples para gerenciamento de Feirantes e Produtos, desenvolvida em
**.NET 8**, utilizando **EF Core** com **SQLite**.

------------------------------------------------------------------------

## 🚜 Arquitetura

O projeto segue o padrão de camadas: - **Controller** → recebe as
requisições HTTP. - **Service** → orquestra regras de negócio. -
**Repository** → acesso ao banco de dados via EF Core. - **DbContext** →
configuração do SQLite e entidades.

------------------------------------------------------------------------

## 📂 Estrutura do Projeto

    FeiraDaRoca/
     ┣ Controllers/
     ┣ Data/
     ┣ Models/
     ┣ Repositories/
     ┣ Services/
     ┣ Program.cs
     ┗ README.md

------------------------------------------------------------------------

## ✅ Funcionalidades

### Feirantes

-   `GET /feirantes` → lista todos os feirantes.
-   `GET /feirantes/{id}` → busca feirante por id.
-   `GET /feirantes/cidade/{cidade}` → lista feirantes por cidade.
-   `POST /feirantes` → cadastra novo feirante.
-   `PUT /feirantes/{id}` → atualiza feirante existente.
-   `DELETE /feirantes/{id}` → remove feirante.

### Produtos

-   `GET /produtos` → lista todos os produtos (com feirante).
-   `GET /produtos/{id}` → busca produto por id (com feirante).
-   `POST /produtos` → cadastra novo produto.
-   `PUT /produtos/{id}` → atualiza produto existente.
-   `DELETE /produtos/{id}` → remove produto.

------------------------------------------------------------------------

## 🐞 Bugs corrigidos

-   Carregamento dos relacionamentos corrigido com `.Include`:
    -   Produtos agora trazem Feirante.
    -   Feirantes agora trazem Produtos.

------------------------------------------------------------------------

## 📌 Próximos Passos

-   Criar **DTOs** para controlar dados retornados em cada endpoint.
-   Implementar **testes automatizados** com xUnit.
-   Adicionar **filtros e paginação** quando houver frontend.
-   Preparar **deploy** no site da Neshama Tech.

------------------------------------------------------------------------

## 🚀 Como rodar

1.  Clone o repositório:

``` bash
git clone https://github.com/seu-usuario/feira-da-roca-api.git
```

2.  Restaure os pacotes:

``` bash
dotnet restore
```

3.  Aplique as migrations:

``` bash
dotnet ef database update
```

4.  Rode a aplicação:

``` bash
dotnet run
```

5.  Acesse o Swagger:

```{=html}
<!-- -->
```
    https://localhost:5001/swagger

------------------------------------------------------------------------

## ☕ Estilo Burrinho.NET

Simples, direto, como um café no copo americano. Cada endpoint faz a sua
parte: entrada → processamento → saída.
