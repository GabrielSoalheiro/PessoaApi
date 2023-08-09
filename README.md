# API de CRUD de Pessoa e Livro em ASP.NET

Esta é uma API simples desenvolvida em ASP.NET que oferece operações de CRUD (Criar, Ler, Atualizar, Deletar) para entidades de Pessoa e Livro.

## Funcionalidades

- Cadastro de Pessoas: Adicione informações sobre indivíduos, como nome, idade e informações de contato.

- Cadastro de Livros: Registre informações sobre livros, incluindo título, autor e gênero.

- Listagem de Pessoas e Livros: Recupere uma lista de todas as pessoas e livros cadastrados.

- Atualização de Informações: Atualize os detalhes de uma pessoa ou livro existente.

- Remoção de Registros: Remova registros de pessoas e livros da base de dados.

## Endpoints da API

A API oferece os seguintes endpoints:

- `GET /api/pessoas`: Retorna a lista de todas as pessoas cadastradas.
- `GET /api/pessoas/{id}`: Retorna os detalhes da pessoa com o ID especificado.
- `POST /api/pessoas`: Cria uma nova pessoa com base nos dados fornecidos.
- `PUT /api/pessoas/{id}`: Atualiza os detalhes da pessoa com o ID especificado.
- `DELETE /api/pessoas/{id}`: Remove a pessoa com o ID especificado.

- `GET /api/livros`: Retorna a lista de todos os livros cadastrados.
- `GET /api/livros/{id}`: Retorna os detalhes do livro com o ID especificado.
- `POST /api/livros`: Cria um novo livro com base nos dados fornecidos.
- `PUT /api/livros/{id}`: Atualiza os detalhes do livro com o ID especificado.
- `DELETE /api/livros/{id}`: Remove o livro com o ID especificado.

## Uso

Certifique-se de ter o ambiente de desenvolvimento ASP.NET configurado em sua máquina. Clone este repositório e, a partir do diretório raiz, execute a aplicação.

```bash
dotnet run
