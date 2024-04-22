# CataoMaketin
É uma aplicação desenvolvida em .NET 8 com intúito de praticar os conhecimentos adquirido no curso de .Net

## Tecnologias Utilizadas
- !.NET - SDK.
- !Entity Framework - SGBD.
- !xUnit - realizar os testes de unidade e de integração.
- !MySQL - Salvar os dados.
- !Docker - Container para subir uma imagem do mysql.
- !Swagger - Especificação Swagger/OpenAPI, é um formato de descrição de API para APIs REST que permite descrever toda a API.
- !Visual Studio Code com a extensão __C# Dev Kit__ - Editor de código.

Regras de Regras de negócio

## Produtos
[] Ser possível cadastrar um produto
[] Ser possível atualizar um produto
[] Ser possível excluir um produto
[] Ser possível obter uma lista de produtos
[] Ser possível obter um produto por Id

## Categorias
[] Ser possível cadastrar uma categria
[] Ser possível atualizar uma categria
[] Ser possível excluir uma categria
[] Ser possível obter uma lista de categorias
[] Ser possível obter uma categria por Id


# Comando para Entityframeworkd
Criar mirations
```dotnet ef migrations add 'nome'```

Remove a migração dos arquivos
```dotnet ef migrations remove 'nome'```

Gera as tabelas na base de dados
```dotnet ef database update```

