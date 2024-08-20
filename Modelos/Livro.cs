namespace Comex.Modelos;

public class Livro : Produto, IIdentificavel
{
    public Livro(string nome, string descricao, float precoUnitario, int quantidade, String isbn, int totalDePaginas) : base(nome, descricao, precoUnitario, quantidade)
    {
        Isbn = isbn;
        TotalDePaginas = totalDePaginas;
    }

    public String Isbn { get; set; }
    public int TotalDePaginas { get; set; }

    public string Identificar()
    {
        return $"Nome: {Nome}, ISBN: {Isbn}";
    }
}