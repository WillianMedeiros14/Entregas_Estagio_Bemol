
using Spectre.Console;

namespace BibliotecaProjeto.Modelos;

public class Biblioteca
{
    public List<Livro> Livros { get; set; }
    public List<Usuario> Usuarios { get; set; }

    public Biblioteca(List<Livro> livros, List<Usuario> usuario)
    {
        Livros = livros;
        Usuarios = usuario;
    }

    public void AdicionarLivro(Livro livro)
    {
        Livros.Add(livro);
    }

    public void RemoverLivro(Livro livro)
    {
        if (Livros.Contains(livro))
        {
            Livros.Remove(livro);
            AnsiConsole.MarkupLine($"[green]Livro removido com sucesso:[/] [yellow]{livro.Titulo}[/]");
        }
        else
        {
            AnsiConsole.MarkupLine("[red]O livro não foi encontrado na biblioteca.[/]");
        }
    }

    public void RegistrarUsuario(Usuario usuario)
    {
        Usuarios.Add(usuario);
    }

    public void ExibirLivrosDisponiveis()
    {

        List<Livro> livrosDisponiveis = Livros.Where(livro => !livro.EstaEmprestado).ToList();

        Livro livro = new Livro();

        livro.ExibirInformacoes(livrosDisponiveis);
    }

    public void ExibirTodosOsLivros()
    {
        Livro livro = new Livro();
        livro.ExibirInformacoes(Livros);
    }
}


