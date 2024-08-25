using System.Text.Json;
using Comex.Filtros;
using Comex.Menus;
using Comex.Modelos;
using Spectre.Console;

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

            int opcaoEscolhida = int.Parse(ExibirOpcoesDoMenu());


            if (opcoes.ContainsKey(opcaoEscolhida))
            {
                opcoes[opcaoEscolhida].Invoke();
                if (opcaoEscolhida == -1)
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
        try
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
        catch (System.Exception ex)
        {
            Console.WriteLine($"Temos um problema: {ex.Message}");

            Console.WriteLine("\nDigite uma tecla para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
        }
    }


    private async Task ListarTodosOsProdutosExternosPorNome()
    {
        try
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
        catch (System.Exception ex)
        {
            Console.WriteLine($"Temos um problema: {ex.Message}");

            Console.WriteLine("\nDigite uma tecla para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
        }
    }


    private async Task ListarTodosOsProdutosExternosPorPreco()
    {
        try
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
        catch (System.Exception ex)
        {
            Console.WriteLine($"Temos um problema: {ex.Message}");

            Console.WriteLine("\nDigite uma tecla para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
        }
    }

    private string ExibirOpcoesDoMenu()
    {

        var opcoes = new[]
          {
                "Listar todos os produtos",
                "Listar todos os produtos ordenados por nome",
                "Listar todos os produtos ordenados por preço",
                "Voltar ao menu principal",

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
    private void VoltarAoMenuPrincipal()
    {
        Console.Clear();
        MenuPrincipal.Executar();
    }
}
