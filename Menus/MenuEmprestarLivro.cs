using BibliotecaProjeto.Modelos;
using Spectre.Console;

internal class MenuEmprestarLivro : Menu
{
    private readonly List<Livro> _livros;
    private readonly List<Usuario> _usuarios;

    public MenuEmprestarLivro(List<Livro> livros, List<Usuario> usuarios)
    {
        _livros = livros;
        _usuarios = usuarios;
    }

    public override void Executar()
    {
        base.Executar();
        ExibirTituloDaOpcao("Emprestar Livro");

        Console.Write("Digite o CPF do Usuário: ");
        string cpf = Console.ReadLine()!;

        Usuario? usuario = _usuarios.FirstOrDefault(u => u.CPF == cpf);

        if (usuario != null)
        {
            usuario.ExibirNomeECpf();

            if (usuario.LivrosEmprestados.Count >= 3)
            {
                Console.WriteLine("Este usuário já tem 3 livros emprestados. Não é possível emprestar mais livros.");
                return;
            }

            List<Livro> livrosDisponiveis = _livros.Where(l => !l.EstaEmprestado).ToList();

            livrosDisponiveis.Add(new Livro { Titulo = "Cancelar", Autor = "" });

            if (!livrosDisponiveis.Any())
            {
                Console.WriteLine("Não há livros disponíveis para empréstimo.");
                Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
                return;
            }

            Livro? livroSelecionado = AnsiConsole.Prompt(
                new SelectionPrompt<Livro>()
                .Title("\nSelecione um livro para emprestar:\n\n[yellow]Pressione [blue]<espaço>[/] para selecionar uma opção,\n[green]<enter>[/] para confirmar,\nA opção [red]<Cancelar>[/] faz cancelar o empréstimo[/]\n\n")
                    .PageSize(10)
                    .MoreChoicesText("[grey](Use as setas para cima e para baixo para mover)[/]")
                    .UseConverter(l => l.Titulo == "Cancelar" ? "[red]Cancelar[/]" : $"{l.Titulo} ({l.Autor})")
                    .AddChoices(livrosDisponiveis));

            if (livroSelecionado?.Titulo == "Cancelar")
            {
                Console.WriteLine("\nOperação de empréstimo cancelada.");
                Console.WriteLine("\n\nDigite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
                return;
            }


            if (livroSelecionado != null)
            {
                usuario.EmprestarLivro(livroSelecionado);
                livroSelecionado.EstaEmprestado = true;
                Console.WriteLine($"\nO livro '{livroSelecionado.Titulo}' foi emprestado com sucesso.");
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
