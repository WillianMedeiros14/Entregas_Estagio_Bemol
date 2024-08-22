using Comex.Menus;
using Comex.Modelos;

internal class MenuListarProdutos : Menu
{
    private readonly List<Produto> _produtos;
    public MenuListarProdutos(List<Produto> produtos)
    {
        _produtos = produtos;
    }
    public override void Executar()
    {
        base.Executar();

        ExibirTituloDaOpcao("Exibindo todos os produtos cadastrados");

        ExibirProdutos(_produtos);

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }


    public void ExibirProdutos(List<Produto> produtos)
    {
        if (_produtos.Count == 0)
        {
            Console.WriteLine("Nenhum produto cadastrado.");
        }
        else
        {
            foreach (var produto in produtos)
            {
                Console.WriteLine($"Nome: {produto.Nome}");
                Console.WriteLine($"Descrição: {produto.Descricao}");
                Console.WriteLine($"Preço Unitário: {produto.PrecoUnitario}");
                Console.WriteLine($"Quantidade: {produto.Quantidade}");

                if (produto is Livro livro)
                {
                    Console.WriteLine($"ISBN: {livro.Isbn}");
                    Console.WriteLine($"Total de Páginas: {livro.TotalDePaginas}");
                }

                if (produto is ProdutoEletronico produtoEletronico)
                {
                    Console.WriteLine($"Voltagem: {produtoEletronico.Voltagem}");
                    Console.WriteLine($"Potência: {produtoEletronico.Potencia}");
                }


                Console.WriteLine();
            }

        }
    }
}