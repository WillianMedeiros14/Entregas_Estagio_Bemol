using BibliotecaProjeto.Modelos;


internal class MenuAdicionarLivro : Menu
{

    private readonly List<Livro> _livros;

    public MenuAdicionarLivro(List<Livro> livros)
    {
        _livros = livros;
    }
    public override void Executar()
    {
        base.Executar();
        ExibirTituloDaOpcao("Cadastro de livro");


        Console.Write("Titulo: ");
        string titulo = Console.ReadLine()!;

        Console.Write("Autor: ");
        string autor = Console.ReadLine()!;

        Console.Write("ISBN: ");
        string isbn = Console.ReadLine()!;

        Console.Write("Data de Publicação: ");
        string dataPublicacao = Console.ReadLine()!;

        DateTime dataPublicacaoFormatada = DateTime.ParseExact(dataPublicacao, "dd/MM/yyyy", null);


        Livro livro = new Livro();
        livro.Titulo = titulo;
        livro.Autor = autor;
        livro.ISBN = isbn;
        livro.DataPublicacao = dataPublicacaoFormatada;
        livro.EstaEmprestado = false;


        _livros.Add(livro);

        Console.Write($"\nO livro {livro.Titulo} foi registrado com sucesso");
        Thread.Sleep(2000);
        Console.Clear();
    }
}