using Comex.Menus;
using Comex.Modelos;

internal class MenuCriarPedido : Menu
{
    private readonly List<Produto> _produtos;
    private readonly List<Cliente> _clientes;

    public MenuCriarPedido(List<Produto> produtos, List<Cliente> clientes)
    {
        _produtos = produtos;
        _clientes = clientes;
    }
    public override void Executar()
    {
        base.Executar();
        ExibirTituloDaOpcao("Criação de pedido");

        Console.Write("Digite o nome do produto: ");
        string nomeDoProduto = Console.ReadLine()!;

        var produtoFiltrado = _produtos.Where(p => p.Nome.Contains(nomeDoProduto)).Take(1).ToList();

        if (produtoFiltrado.Any())
        {
            Console.Clear();
            Console.WriteLine(" - Detalhes do produto -\n");

            MenuListarProdutos listarProduto = new MenuListarProdutos(produtoFiltrado);
            listarProduto.ExibirProdutos(produtoFiltrado);


            Console.Write("\nDigite o nome do Cliente: ");
            string nomeDoCliente = Console.ReadLine()!;

            var clienteFiltrado = _clientes.Where(p => p.Nome.Contains(nomeDoCliente)).Take(1).ToList();

            if (clienteFiltrado.Any())
            {
                Console.WriteLine("\n - Detalhes do Cliente -\n");

                MenuListarClientes listarCliente = new MenuListarClientes(clienteFiltrado);
                listarCliente.ListarClientes(clienteFiltrado);

                Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
                Console.ReadKey();
            }

        }
        else
        {
            Console.WriteLine("Nenhum produto encontrado com o nome especificado.");
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }


        // Console.Write("Nome: ");
        // string nomeDoProduto = Console.ReadLine()!;        

        // Console.Write("Descrição: ");
        // string descricaoDoProduto = Console.ReadLine()!;

        // Console.Write("Preço unitário: ");
        // float precoUnitarioDoProduto = float.Parse(Console.ReadLine()!);

        // Console.Write("Quantidade: ");
        // int quantidadeDoProduto = int.Parse(Console.ReadLine()!);

        // Produto produto = new(nomeDoProduto, descricaoDoProduto, precoUnitarioDoProduto, quantidadeDoProduto);


        // _produtos.Add(produto);

        // Console.Write($"\nO produto {nomeDoProduto} foi registrado com sucesso");
        // Thread.Sleep(2000);
        Console.Clear();

    }
}