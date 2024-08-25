using Comex.Menus;
using Comex.Modelos;

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
                listarClientes.ListarClientes(listaDeClientes);

                Console.WriteLine();

                foreach (ItemDePedido itemPedido in pedido.Items)
                {
                    Console.WriteLine($"Nome: {itemPedido.Produto.Nome}");
                    Console.WriteLine($"Preço unitário: {itemPedido.Produto.PrecoUnitario}");
                    Console.WriteLine($"Quantidade: {itemPedido.Quantidade}");
                    Console.WriteLine($"Subtotal: {itemPedido.Subtotal}");

                    Console.WriteLine();
                }

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