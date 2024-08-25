using Spectre.Console;
using Comex.Modelos;

namespace Comex.Menus
{
    internal class MenuPrincipal : Menu
    {
        private readonly Dictionary<int, Menu> opcoes;

        public MenuPrincipal(List<Produto> produtos, List<Cliente> clientes, List<Pedido> pedidos)
        {
            opcoes = new Dictionary<int, Menu>
            {
                { 1, new MenuCriarProduto(produtos) },
                { 2, new MenuListarProdutos(produtos) },
                { 3, new MenuCriarPedido(produtos, clientes, pedidos) },
                { 4, new MenuListarPedidos(pedidos) },
                { 5, new MenuListarClientes(clientes) },
                { 6, new MenuBuscaExternaProdutos(this) },
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
                "Criar Produto",
                "Listar Produtos",
                "Criar Pedido",
                "Listar Pedidos",
                "Listar Clientes",
                "Buscar Produtos Externos",
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
