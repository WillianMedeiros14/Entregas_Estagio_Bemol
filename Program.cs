using BibliotecaProjeto.Modelos;

Livro livro1 = new Livro();
livro1.Titulo = "Dom Quixote";
livro1.Autor = "Miguel de Cervantes";
livro1.ISBN = "978-3-16-148410-0";
livro1.DataPublicacao = new DateTime(1605, 1, 16);
livro1.EstaEmprestado = true;

Livro livro2 = new Livro();
livro2.Titulo = "O Hobbit";
livro2.Autor = "J.R.R. Tolkien";
livro2.ISBN = "978-0-395-19395-8";
livro2.DataPublicacao = new DateTime(1937, 9, 21);
livro2.EstaEmprestado = false;


List<Livro> livrosEmprestados = new List<Livro>{
    livro1,
};

Usuario usuario = new Usuario(
           nome: "João Silva",
           cpf: "123.456.789-00",
           livrosEmprestados: livrosEmprestados
       );



Biblioteca biblioteca = new Biblioteca();

biblioteca.AdicionarLivro(livro1);
biblioteca.AdicionarLivro(livro2);
biblioteca.RegistrarUsuario(usuario);
// biblioteca.ExibirLivrosDisponiveis();


biblioteca.ExibirTodosOsLivros();
biblioteca.RemoverLivro(livro2);
biblioteca.ExibirTodosOsLivros();
