
using Spectre.Console;

namespace BibliotecaProjeto.Modelos;

public class Livro
{
    public String Titulo { get; set; }
    public String Autor { get; set; }
    public String ISBN { get; set; }
    public DateTime DataPublicacao { get; set; }
    public bool EstaEmprestado { get; set; }

    void Emprestar()
    {

    }

    void Devolver()
    {

    }

    public void ExibirInformacoes(List<Livro> livros)
    {
        if (livros.Count == 0)
        {
            Console.WriteLine("Nenhum produto cadastrado.");
        }
        else
        {
            var table = new Table();
            table.AddColumn("Titulo");
            table.AddColumn("Autor");
            table.AddColumn("ISBN");
            table.AddColumn("Data de Publicação");
            table.AddColumn("Está Emprestado");

            foreach (Livro livro in livros)
            {
                table.AddRow(
                    livro.Titulo,
                   livro.Autor,
                    livro.ISBN,
                   livro.DataPublicacao.ToString("dd/MM/yyyy"),
                   livro.EstaEmprestado ? "Sim" : "Não");
            }

            AnsiConsole.Write(table);
        }
    }

}


