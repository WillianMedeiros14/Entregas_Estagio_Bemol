using BibliotecaProjeto.Modelos;
using Spectre.Console;

internal class MenuDevolverLivro : Menu
{
    private readonly List<Livro> _livros;
    private readonly List<Usuario> _usuarios;

    public MenuDevolverLivro(List<Livro> livros, List<Usuario> usuarios)
    {
        _livros = livros;
        _usuarios = usuarios;
    }

    public override void Executar()
    {
        base.Executar();
        ExibirTituloDaOpcao("Devolver Livro");

        Console.Write("Digite o CPF do Usuário: ");
        string cpf = Console.ReadLine()!;

        Usuario? usuario = _usuarios.FirstOrDefault(u => u.CPF == cpf);

        if (usuario != null)
        {
            usuario.ExibirNomeECpf();

            if (usuario.LivrosEmprestados.Any())
            {

                List<Livro> livros = new List<Livro>(usuario.LivrosEmprestados)
                {
                    new Livro { Titulo = "Cancelar", Autor = "" }
                };

                MultiSelectionPrompt<Livro>? prompt = new MultiSelectionPrompt<Livro>()
                    .Title("Selecione os livros para devolver:")
                    .PageSize(10)
                    .MoreChoicesText("[grey](Use as setas para cima e para baixo para mover)[/]")
                    .InstructionsText("[yellow]Pressione [blue]<espaço>[/] para selecionar uma opção,\n[green]<enter>[/] para confirmar,\nA opção [red]<Cancelar>[/] faz cancelar a devolução[/]\n\n")
                    .UseConverter(l => l.Titulo == "Cancelar" ? "[red]Cancelar[/]" : $"{l.Titulo} ({l.Autor})")
                    .AddChoices(livros);


                List<Livro>? livrosParaDevolver = AnsiConsole.Prompt(prompt);


                if (livrosParaDevolver.Any(l => l.Titulo == "Cancelar"))
                {
                    Console.WriteLine("\nOperação de devolução cancelada.");
                }
                else if (livrosParaDevolver.Any())
                {
                    foreach (var livroParaDevolver in livrosParaDevolver)
                    {
                        usuario.LivrosEmprestados.Remove(livroParaDevolver);

                        Livro? livroNaBiblioteca = _livros.FirstOrDefault(l => l.Titulo == livroParaDevolver.Titulo && l.Autor == livroParaDevolver.Autor);
                        if (livroNaBiblioteca != null)
                        {
                            livroNaBiblioteca.EstaEmprestado = false;
                        }

                        Console.WriteLine($"\nO livro '{livroParaDevolver.Titulo}' foi devolvido com sucesso.");
                    }
                }
                else
                {
                    Console.WriteLine("Nenhum livro selecionado para devolução.");
                }
            }
            else
            {
                Console.WriteLine("Este usuário não possui livros emprestados.");
            }
        }
        else
        {
            Console.WriteLine("Usuário não encontrado. Verifique o CPF digitado.");
        }

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}
