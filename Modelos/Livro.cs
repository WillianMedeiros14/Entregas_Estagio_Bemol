
using Spectre.Console;

namespace Biblioteca.Modelos;

public class Livro
{
    public String Titulo { get; set; }
    public String Autor { get; set; }
    public String ISBN { get; set; }
    public DateTime DataPublicacao { get; set; }
    public bool EstaEmprestado { get; set; }
    public Livro(string titulo, string autor, String isbn, DateTime dataPublicacao, bool estaEmprestado)
    {
        Titulo = titulo;
        Autor = autor;
        ISBN = isbn;
        DataPublicacao = dataPublicacao;
        EstaEmprestado = estaEmprestado;
    }

    void Emprestar()
    {

    }

    void Devolver()
    {

    }

    public void ExibirInformacoes()
    {
        var table = new Table();
        table.AddColumn("Titulo");
        table.AddColumn("Autor");
        table.AddColumn("ISBN");
        table.AddColumn("Data de Publicação");
        table.AddColumn("Está Emprestado");

        table.AddRow(
            Titulo,
            Autor,
            ISBN,
            DataPublicacao.ToString("dd/MM/yyyy"),
            EstaEmprestado ? "Sim" : "Não");

        AnsiConsole.Write(table);
    }

}


