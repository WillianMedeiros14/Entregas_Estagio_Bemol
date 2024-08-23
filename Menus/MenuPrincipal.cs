using Comex.Modelos;

namespace Comex.Menus;
internal class MenuPrincipal : Menu
{
    private readonly Dictionary<int, Menu> opcoes;

    public MenuPrincipal(List<Produto> produtos, List<Cliente> clientes)
    {

        opcoes = new Dictionary<int, Menu>
            {
                { 1, new MenuCriarProduto(produtos) },
                { 2, new MenuListarProdutos(produtos) },
                { 3, new MenuCriarPedido(produtos, clientes) },
                { 4, new MenuCriarPedido(produtos, clientes) },
                { 5, new MenuListarClientes(clientes) },
                { 6, new MenuBuscaExternaProdutos(this) },
                { -1, new MenuSair() }
            };
    }

    public override void Executar()
    {
        while (true)
        {
            ExibirOpcoesDoMenu();

            string opcaoEscolhida = Console.ReadLine()!;
            int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

            if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
            {
                Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
                menuASerExibido.Executar();

                if (opcaoEscolhidaNumerica == -1)
                {
                    break;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Opção inválida\n");
            }
        }
    }

    private void ExibirOpcoesDoMenu()
    {
        Console.WriteLine("\nDigite o número da opção:");
        Console.WriteLine("1: Criar Produto");
        Console.WriteLine("2: Listar Produtos");
        Console.WriteLine("3: Criar Pedido");
        Console.WriteLine("4: Listar Pedios");
        Console.WriteLine("5: Listar Clientes");
        Console.WriteLine("6: Buscar Produtos Externos");
        Console.WriteLine("-1: Sair");
        Console.Write("\nDigite a sua opção: ");
    }
}
