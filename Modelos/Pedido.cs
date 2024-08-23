namespace Comex.Modelos;
class Pedido
{
    public Cliente Cliente { get; set; }
    public DateTime Data { get; set; }
    public List<ItemDePedido> Items = new List<ItemDePedido>();

    public float Total { get; set; }

    public void AdicionarItem(ItemDePedido item)
    {
        Items.Add(item);
        Total = Total + item.Subtotal;
    }
}
