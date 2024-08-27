## 💻 Projeto

Está aplicação foi criada para estudos em C# e docker. <br><br>

## ✅ Funcionalidades

- Registrar Usuário;
- Adicionar Livro;
- Exibir Livros Disponíveis (que não estão emprestados);
- Emprestar Livro;
- Devolver Livro;
  <br>

## 🎲 Executar

Para rodar o projeto com docker siga os passos abaixo:

- Para testar o projeto, é preciso ter o docker intalado em sua máquina.
- Depois de fazer o clone desse projeto, entre pelo terminal na pasta do projeto e rode os comando abaixo:

```bash
# Buildar o projeto
docker build -t biblioteca-dotnet .

#executar o projeto
docker run -it -p 80:80 biblioteca-dotnet
```

Para rodar o projeto sem o uso do docker siga os passos abaixo:

- Depois de fazer o clone desse projeto, entre em sua IDE de prefrência e execute normalmente aplicação

<br>

## 🚀 Principais recursos e tecnologias ultilizadas

- **[Documentação da linguagem C#](https://learn.microsoft.com/en-us/dotnet/csharp/)**.
- **[Docker](https://docs.docker.com/)**.
- **[Criar o Dockerfile para .NET](https://learn.microsoft.com/pt-br/dotnet/core/docker/build-container?tabs=windows&pivots=dotnet-8-0#create-the-dockerfile)**.
