
using Spectre.Console;

namespace BibliotecaProjeto.Modelos;

public class Usuario
{
    public String Nome { get; set; }

    public String CPF { get; set; }
    public List<Livro> LivrosEmprestados { get; set; }

    public Usuario(String nome, String cpf, List<Livro> livrosEmprestados)
    {
        LivrosEmprestados = livrosEmprestados;
        Nome = nome;
        CPF = cpf;
    }

    public void EmprestarLivro(List<Livro> livro)
    {

    }

    public void DevolverLivro(List<Livro> livros)
    {

    }

    public void ExibirHistoricoEmprestimos(List<Livro> livros)
    {

    }

    public void ExibirNomeECpf()
    {
        var table = new Table();
        table.Border(TableBorder.Rounded);

        table.AddColumn("[green]Nome[/]");
        table.AddColumn("[green]CPF[/]");

        table.AddRow(Nome, CPF);

        AnsiConsole.Write(table);
    }
}


