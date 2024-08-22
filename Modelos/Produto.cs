using System.Text.Json.Serialization;

namespace Comex.Modelos;

public class Produto
{

    [JsonPropertyName("title")]
    public String Nome { get; set; }

    [JsonPropertyName("description")]
    public String Descricao { get; set; }

    [JsonPropertyName("price")]
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
