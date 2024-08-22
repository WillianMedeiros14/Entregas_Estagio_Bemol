using Comex.Modelos;

namespace Comex.Filtros;

internal class LinqOrder
{
    public static void ExibirListaDeProdutosOrdenados(List<Produto> produtos)
    {
        var produtosOrdenados = produtos.OrderBy(produto => produto.Nome).Select(produto => produto.Nome).Distinct().ToList();

        Console.WriteLine($"Lista de Produtos ordenados por nome\n");
        foreach (var produto in produtosOrdenados)
        {
            Console.WriteLine($"- {produto}");
        }
    }

    public static void ExibirListaDeProdutosOrdenadosPorPreco(List<Produto> produtos)
    {
        var produtosOrdenados = produtos.OrderBy(produto => produto.PrecoUnitario).Distinct().ToList();

        Console.WriteLine($"Lista de Produtos ordenados por preço\n");
        foreach (var produto in produtosOrdenados)
        {
            Console.WriteLine($"- {produto.Nome} = {produto.PrecoUnitario}");
        }
    }
}