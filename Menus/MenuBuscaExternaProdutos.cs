using Comex.Menus;
using Comex.Modelos;

internal class MenuBuscaExternaProdutos : Menu
{
    private readonly Menu MenuPrincipal;

    public MenuBuscaExternaProdutos(Menu menuPrincipal)
    {
        MenuPrincipal = menuPrincipal;
    }

    public override void Executar()
    {
        base.Executar();
        ExibirTituloDaOpcao("Buscar produtos externos");

        Dictionary<int, Action> opcoes = new();
        opcoes.Add(1, ListarTodosOsProdutos);
        opcoes.Add(-1, VoltarAoMenuPrincipal);

        Console.WriteLine("\nDigite o número da opção:");
        Console.WriteLine("1: Listar todos os produtos");
        Console.WriteLine("-1: Voltar ao menu principal");

        Console.Write("\nDigite a sua opção: ");
        string opcaoEscolhida = Console.ReadLine()!;
        int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

        if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
        {
            opcoes[opcaoEscolhidaNumerica].Invoke();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Opção inválida");
            Executar();
        }
    }

    private void ListarTodosOsProdutos()
    {
        Console.WriteLine("Listando todos os produtos...");


    }

    private void VoltarAoMenuPrincipal()
    {
        Console.Clear();
        MenuPrincipal.Executar();
    }
}
