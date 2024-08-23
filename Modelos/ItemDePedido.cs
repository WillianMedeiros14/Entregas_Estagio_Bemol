namespace Comex.Modelos;
class ItemDePedido
{
    public Produto Produto { get; set; }
    public int Quantidade { get; set; }
    public float PrecoUnitario => Produto.PrecoUnitario;
    public float Subtotal => Quantidade * PrecoUnitario;

}
