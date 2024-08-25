using Comex.Menus;
using Comex.Modelos;
using Spectre.Console;


internal class MenuListarPedidos : Menu
{
    private readonly List<Pedido> _pedidos;
    public MenuListarPedidos(List<Pedido> pedidos)
    {
        _pedidos = pedidos;
    }
    public override void Executar()
    {
        base.Executar();

        ExibirTituloDaOpcao("Exibindo todos os pedidos realizados");

        ExibirPedidos(_pedidos);

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }


    public void ExibirPedidos(List<Pedido> pedidos)
    {
        if (pedidos.Count == 0)
        {
            Console.WriteLine("Nenhum produto cadastrado.");
        }
        else
        {

            foreach (Pedido pedido in pedidos)
            {

                List<Cliente> listaDeClientes = new List<Cliente> { pedido.Cliente };
                MenuListarClientes listarClientes = new MenuListarClientes(listaDeClientes);
                listarClientes.ListarClientes(listaDeClientes, false);

                Console.WriteLine();

                var itemTable = new Table();
                itemTable.Title("Itens do Pedido");
                itemTable.AddColumn("Nome");
                itemTable.AddColumn("Preço Unitário");
                itemTable.AddColumn("Quantidade");
                itemTable.AddColumn("Subtotal");

                foreach (ItemDePedido itemPedido in pedido.Items)
                {
                    itemTable.AddRow(itemPedido.Produto.Nome,
                                     itemPedido.Produto.PrecoUnitario.ToString("C"),
                                     itemPedido.Quantidade.ToString(),
                                     itemPedido.Subtotal.ToString("C"));
                }

                AnsiConsole.Write(itemTable);

                Console.WriteLine($"Data: {pedido.Data}");
                Console.WriteLine($"Total: {pedido.Total:C}");

                Console.WriteLine(new string('-', 40));

            }

        }
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }


}