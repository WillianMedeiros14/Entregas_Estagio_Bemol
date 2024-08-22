using Comex.Menus;
using Comex.Modelos;

internal class MenuListarProdutosExternos : Menu
{
    private readonly List<Produto> _produtos;

    public MenuListarProdutosExternos(List<Produto> produtos)
    {
        _produtos = produtos;
    }
    public override void Executar()
    {
        ExibirTituloDaOpcao("Exibindo todos os produtos cadastrados");

        if (_produtos.Count == 0)
        {
            Console.WriteLine("Nenhum produto cadastrado.");
        }
        else
        {
            foreach (var produto in _produtos)
            {
                Console.WriteLine($"Nome: {produto.Nome}");
                Console.WriteLine($"Descrição: {produto.Descricao}");
                Console.WriteLine($"Preço Unitário: {produto.PrecoUnitario}");
                Console.WriteLine($"Quantidade: {produto.Quantidade}");

                Console.WriteLine();
            }

        }

    }

}