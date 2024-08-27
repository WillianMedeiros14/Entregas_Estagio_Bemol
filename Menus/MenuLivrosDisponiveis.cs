using BibliotecaProjeto.Modelos;


internal class MenuLivrosDisponiveis : Menu
{

    private readonly List<Livro> _livros;

    private readonly List<Usuario> _usuarios = new List<Usuario>();

    public MenuLivrosDisponiveis(List<Livro> livros)
    {
        _livros = livros;
    }
    public override void Executar()
    {
        base.Executar();
        ExibirTituloDaOpcao("Livros Disponíveis");


        Biblioteca biblioteca = new Biblioteca(_livros, _usuarios);
        biblioteca.ExibirLivrosDisponiveis();


        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();

        Console.Clear();
    }
}