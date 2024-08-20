using Comex.Menus;
using Comex.Modelos;

internal class MenuCriarProduto : Menu
{

    private readonly List<Produto> _produtos;

    public MenuCriarProduto(List<Produto> produtos)
    {
        _produtos = produtos;
    }
    public override void Executar()
    {
        base.Executar();
        ExibirTituloDaOpcao("Cadastro de produto");


        Console.Write("Nome: ");
        string nomeDoProduto = Console.ReadLine()!;

        Console.Write("Descrição: ");
        string descricaoDoProduto = Console.ReadLine()!;

        Console.Write("Preço unitário: ");
        float precoUnitarioDoProduto = float.Parse(Console.ReadLine()!);

        Console.Write("Quantidade: ");
        int quantidadeDoProduto = int.Parse(Console.ReadLine()!);

        Produto produto = new(nomeDoProduto, descricaoDoProduto, precoUnitarioDoProduto, quantidadeDoProduto);


        _produtos.Add(produto);

        Console.Write($"\nO produto {nomeDoProduto} foi registrado com sucesso");
        Thread.Sleep(2000);
        Console.Clear();

    }
}