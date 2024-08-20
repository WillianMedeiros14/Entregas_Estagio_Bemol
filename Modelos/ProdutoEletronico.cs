namespace Comex.Modelos;

public class ProdutoEletronico : Produto
{
    public ProdutoEletronico(string nome, string descricao, float precoUnitario, int quantidade, double voltagem, double potencia) : base(nome, descricao, precoUnitario, quantidade)
    {
        Voltagem = voltagem;
        Potencia = potencia;
    }

    public double Voltagem { get; set; }
    public double Potencia { get; set; }
}