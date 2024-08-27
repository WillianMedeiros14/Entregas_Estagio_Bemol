using BibliotecaProjeto.Modelos;
using Spectre.Console;


namespace BibliotecaProjeto.Menus
{
    internal class MenuPrincipal : Menu
    {
        private readonly Dictionary<int, Menu> opcoes;

        public MenuPrincipal(List<Usuario> usuarios, List<Livro> livros)
        {
            opcoes = new Dictionary<int, Menu>
            {
                { 1, new MenuRegistrarUsuario(usuarios) },
                { 2, new MenuAdicionarLivro(livros) },
                { 3, new MenuLivrosDisponiveis(livros)},
                { 4, new MenuDevolverLivro(livros, usuarios) },
                { 5, new MenuDevolverLivro(livros, usuarios) },
                { -1, new MenuSair() }
            };
        }

        public override void Executar()
        {
            while (true)
            {
                int opcaoEscolhida = int.Parse(ExibirOpcoesDoMenu());


                if (opcoes.ContainsKey(opcaoEscolhida))
                {

                    Menu menuASerExibido = opcoes[opcaoEscolhida];
                    menuASerExibido.Executar();

                    if (opcaoEscolhida == -1)
                    {
                        break;
                    }

                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Opção inválida\n");
                    }
                }
            }
        }

        private string ExibirOpcoesDoMenu()
        {

            var opcoes = new[]
            {
                "Registrar Usuário",
                "Adicionar Livro",
                "Exibir Livros Disponíveis",
                "Emprestar Livros",
                "Devolver Livro;",
                "Sair"
            };


            string escolha = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Selecione uma opção:")
                    .AddChoices(opcoes)
            );


            var opcaoEscolhida = opcoes.ToList().IndexOf(escolha) + 1;
            if (opcaoEscolhida == opcoes.Length)
            {
                opcaoEscolhida = -1;
            }

            return opcaoEscolhida.ToString();
        }
    }
}
