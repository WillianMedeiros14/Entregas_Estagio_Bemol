using System.Text.Json;
using Comex.Filtros;
using Comex.Menus;
using Comex.Modelos;

internal class MenuBuscaExternaProdutos : Menu
{
    private readonly Menu MenuPrincipal;
    private readonly Dictionary<int, Action> opcoes;

    public MenuBuscaExternaProdutos(Menu menuPrincipal)
    {
        MenuPrincipal = menuPrincipal;

        opcoes = new Dictionary<int, Action>
        {
            { 1, ListarProdutosExternos },
            { 2,  ListarProdutosExternosPorNome},
            { 3,  ListarProdutosExternosPorPreco},
            { -1, VoltarAoMenuPrincipal }
        };
    }

    private void ListarProdutosExternos()
    {
        base.Executar();
        Task.Run(async () => await ListarTodosOsProdutosExternos()).Wait();
    }

    private void ListarProdutosExternosPorNome()
    {
        base.Executar();
        Task.Run(async () => await ListarTodosOsProdutosExternosPorNome()).Wait();
    }

    private void ListarProdutosExternosPorPreco()
    {
        base.Executar();
        Task.Run(async () => await ListarTodosOsProdutosExternosPorPreco()).Wait();
    }

    public override void Executar()
    {
        while (true)
        {
            base.Executar();
            ExibirTituloDaOpcao("Buscar produtos externos");

            ExibirOpcoesDoMenu();

            string opcaoEscolhida = Console.ReadLine()!;
            int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

            if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
            {
                opcoes[opcaoEscolhidaNumerica].Invoke();
                if (opcaoEscolhidaNumerica == -1)
                {
                    break;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Opção inválida");
            }
        }
    }

    private async Task ListarTodosOsProdutosExternos()
    {
        HttpClient httpClient = new();

        Console.WriteLine("Buscando todos os produtos...");

        string resposta = await httpClient.GetStringAsync("https://fakestoreapi.com/products");
        List<Produto>? produtos = JsonSerializer.Deserialize<List<Produto>>(resposta);



        Console.Clear();

        MenuListarProdutosExternos listarProdutosMenu = new MenuListarProdutosExternos(produtos);
        listarProdutosMenu.Executar();

        Console.WriteLine("\nDigite uma tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
    }


    private async Task ListarTodosOsProdutosExternosPorNome()
    {
        HttpClient httpClient = new();

        Console.WriteLine("Buscando todos os produtos...");

        string resposta = await httpClient.GetStringAsync("https://fakestoreapi.com/products");
        List<Produto>? produtos = JsonSerializer.Deserialize<List<Produto>>(resposta);

        LinqOrder.ExibirListaDeProdutosOrdenados(produtos);

        Console.WriteLine("\nDigite uma tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
    }


    private async Task ListarTodosOsProdutosExternosPorPreco()
    {
        HttpClient httpClient = new();

        Console.WriteLine("Buscando todos os produtos...");

        string resposta = await httpClient.GetStringAsync("https://fakestoreapi.com/products");
        List<Produto>? produtos = JsonSerializer.Deserialize<List<Produto>>(resposta);

        LinqOrder.ExibirListaDeProdutosOrdenadosPorPreco(produtos);

        Console.WriteLine("\nDigite uma tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
    }


    private void ExibirOpcoesDoMenu()
    {
        Console.WriteLine("\nDigite o número da opção:");
        Console.WriteLine("1: Listar todos os produtos");
        Console.WriteLine("2: Listar todos os produtos ordenados por nome");
        Console.WriteLine("3: Listar todos os produtos ordenados por preço");
        Console.WriteLine("-1: Voltar ao menu principal");

        Console.Write("\nDigite a sua opção: ");
    }
    private void VoltarAoMenuPrincipal()
    {
        Console.Clear();
        MenuPrincipal.Executar();
    }
}
