
using Spectre.Console;

namespace Biblioteca.Modelos;

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

    void EmprestarLivro(List<Livro> livro)
    {

    }

    void DevolverLivro(List<Livro> livro)
    {

    }

    void ExibirHistoricoEmprestimos(List<Livro> livro)
    {

    }
}


