using Comex.Menus;
using Comex.Modelos;

internal class MenuCriarPedido : Menu
{
    private readonly List<Produto> _produtos;
    private readonly List<Cliente> _clientes;
    public readonly List<Pedido> _pedidos;

    public MenuCriarPedido(List<Produto> produtos, List<Cliente> clientes, List<Pedido> pedidos)
    {
        _produtos = produtos;
        _clientes = clientes;
        _pedidos = pedidos;
    }

    public override void Executar()
    {
        base.Executar();
        ExibirTituloDaOpcao("Criação de pedido");

        Console.Write("Digite o nome do Cliente: ");
        string nomeDoCliente = Console.ReadLine()!;

        List<Cliente> clienteFiltrado = _clientes.Where(p => p.Nome.Contains(nomeDoCliente)).Take(1).ToList();



        if (clienteFiltrado.Any())
        {
            MenuListarClientes listarCliente = new MenuListarClientes(clienteFiltrado);
            listarCliente.ListarClientes(clienteFiltrado);

            Pedido pedido = new Pedido(clienteFiltrado[0], DateTime.Now);

            bool adicionarMaisItens;
            do
            {
                Console.Write("\nDigite o nome do produto: ");
                string nomeDoProduto = Console.ReadLine()!;

                List<Produto> produtoFiltrado = _produtos.Where(p => p.Nome.Contains(nomeDoProduto)).Take(1).ToList();

                if (produtoFiltrado.Any())
                {

                    MenuListarProdutos listarProduto = new MenuListarProdutos(produtoFiltrado);
                    listarProduto.ExibirProdutos(produtoFiltrado);

                    Console.Write("\nDigite a quantidade de items: ");
                    int quantidade = int.Parse(Console.ReadLine()!);

                    ItemDePedido itemPedido = new ItemDePedido
                    {
                        Produto = produtoFiltrado[0],
                        Quantidade = quantidade,
                    };

                    pedido.AdicionarItem(itemPedido);


                    Console.WriteLine($"\nItem '{itemPedido.Produto.Nome}' adicionado ao pedido com sucesso!");
                }
                else
                {
                    Console.WriteLine("Nenhum produto encontrado com o nome especificado.");
                }


                Console.Write("\nDeseja adicionar mais itens ao pedido? (S/N): ");
                string resposta = Console.ReadLine()!.ToUpper();
                adicionarMaisItens = resposta == "S";

            } while (adicionarMaisItens);

            _pedidos.Add(pedido);

            Console.WriteLine("\n - Resumo do Pedido -\n");
            Console.WriteLine($"Cliente: {pedido.Cliente.Nome}");
            Console.WriteLine($"Data: {pedido.Data}");
            Console.WriteLine($"Total: {pedido.Total:C}");

            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Nenhum cliente encontrado com o nome especificado.");
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
        }

        Console.Clear();
    }
}
