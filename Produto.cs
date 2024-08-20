

class Produto
{
    public String Nome { get; set; }
    public String Descricao { get; set; }
    public float PrecoUnitario { get; set; }
    public int Quantidade { get; set; }

    public Produto(string nome, string descricao, float precoUnitario, int quantidade)
    {
        Nome = nome;
        Descricao = descricao;
        PrecoUnitario = precoUnitario;
        Quantidade = quantidade;
    }
}