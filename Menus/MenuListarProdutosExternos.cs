using Comex.Menus;
using Comex.Modelos;
using Spectre.Console;

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
            AnsiConsole.MarkupLine("[red]Nenhum produto cadastrado.[/]");
        }
        else
        {
            var table = new Table();
            table.AddColumn("Nome");
            table.AddColumn("Descrição");
            table.AddColumn("Preço Unitário");
            table.AddColumn("Quantidade");

            foreach (var produto in _produtos)
            {
                table.AddRow(
                    produto.Nome,
                    produto.Descricao,
                    produto.PrecoUnitario.ToString("C"),
                    produto.Quantidade.ToString()
                );
                table.AddRow(" ");
            }


            AnsiConsole.Write(table);
        }
    }
}
