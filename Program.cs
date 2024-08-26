using Biblioteca.Modelos;

Livro livro = new Livro(
            titulo: "Dom Quixote",
            autor: "Miguel de Cervantes",
            isbn: "978-3-16-148410-0",
            dataPublicacao: new DateTime(1605, 1, 16),
            estaEmprestado: false
        );

livro.ExibirInformacoes();