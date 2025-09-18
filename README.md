# 🐴 Feira da Roça API – Continuação do Projeto (Ciclo 5 em diante)

Este README documenta a continuação do projeto **Feira da Roça API**, agora estruturado com camadas organizadas e recursos mais avançados.

---

## ✅ Estado atual do projeto

- CRUD completo para **Feirantes** e **Produtos**
- Relacionamento 1:N entre `Feirante` e `Produto`
- Banco de dados **SQLite** com EF Core
- Camadas implementadas:
  - Controller → Service → Repository
- Validações com DataAnnotations aplicadas
- Swagger documentando todos os endpoints
- Testes realizados com Postman (collection incluída)
- Código versionado no GitHub com histórico limpo

---

## 🐞 Bugs registrados para resolver

- [ ] `POST /produtos` retorna `Feirante: null` mesmo com `FeiranteId` válido
- [ ] `GET /feirantes` não carrega produtos se não usar `.Include(f => f.Produtos)`
  - Corrigido com `ReferenceHandler.IgnoreCycles` no `Program.cs`

---

## 📌 Próximos passos (a partir deste ciclo)

- [ ] Criar filtros nos endpoints (`?cidade=...`, `?feiranteId=...`)
- [ ] Implementar paginação (`page`, `pageSize`)
- [ ] Adicionar testes automatizados com xUnit
- [ ] Incluir comentários XML para melhorar o Swagger
- [ ] Preparar o deploy da API para uso público
- [ ] (Opcional) Criar frontend em React/Vue para consumo da API

---

## 🚀 Como rodar

```bash
dotnet restore
dotnet ef database update
dotnet run
```

Acesse o Swagger:

```
http://localhost:5000/swagger
```

---

## 📫 Contato

Desenvolvido por **Marcos Rabinowicz – Neshama Tech**  
Com carinho, simplicidade e código raiz 🐴☕

---

## ✅ Coleção do postman

Acesse o arquivo:

feira-da-roca-api.postman_collection.json
