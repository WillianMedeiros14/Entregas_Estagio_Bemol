using BibliotecaProjeto.Modelos;


internal class MenuRegistrarUsuario : Menu
{

    private readonly List<Usuario> _usuario;

    public MenuRegistrarUsuario(List<Usuario> usuario)
    {
        _usuario = usuario;
    }
    public override void Executar()
    {
        base.Executar();
        ExibirTituloDaOpcao("Cadastro de usuário");


        Console.Write("Nome: ");
        string nome = Console.ReadLine()!;

        Console.Write("CPF: ");
        string cpf = Console.ReadLine()!;


        Usuario usuario = new Usuario(
                   nome: nome,
                   cpf: cpf,
                   livrosEmprestados: new List<Livro>()
               );

        _usuario.Add(usuario);

        Console.Write($"\nO usuario {usuario.Nome} foi registrado com sucesso");
        Thread.Sleep(2000);
        Console.Clear();
    }
}