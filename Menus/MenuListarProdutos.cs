using Comex.Menus;
using Comex.Modelos;
using Spectre.Console;


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
        if (produtos.Count == 0)
        {
            Console.WriteLine("Nenhum produto cadastrado.");
        }
        else
        {
            var table = new Table();

            table.Title("Produtos");
            table.AddColumn("Nome");
            table.AddColumn("Descrição");
            table.AddColumn("Preço Unitário");
            table.AddColumn("Quantidade");
            table.AddColumn("Tipo");
            table.AddColumn("Detalhes");

            foreach (var produto in produtos)
            {
                string tipoProduto = "";
                string detalhesProduto = "";

                if (produto is Livro livro)
                {
                    tipoProduto = "Livro";
                    detalhesProduto = $"ISBN: {livro.Isbn}, Páginas: {livro.TotalDePaginas}";
                }
                else if (produto is ProdutoEletronico produtoEletronico)
                {
                    tipoProduto = "Produto Eletrônico";
                    detalhesProduto = $"Voltagem: {produtoEletronico.Voltagem}, Potência: {produtoEletronico.Potencia}";
                }
                else
                {
                    tipoProduto = "Produto";
                    detalhesProduto = "";
                }

                table.AddRow(produto.Nome, produto.Descricao, produto.PrecoUnitario.ToString("C"),
                             produto.Quantidade.ToString(), tipoProduto, detalhesProduto);

                table.AddRow(" ");
            }

            AnsiConsole.Write(table);
        }
    }


}