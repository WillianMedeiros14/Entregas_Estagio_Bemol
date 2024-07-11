
string mensagemDeBoasVindas = "Bem-vindos ao Comex.";

Console.WriteLine(mensagemDeBoasVindas);

List<string> listaDeProdutos = new List<string> { "Arroz", "Feijão" };

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite o número da opção:");
    Console.WriteLine("1: Criar Produto");
    Console.WriteLine("2: Listar Produtos");
    Console.WriteLine("-1: Sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoScolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoScolhidaNumerica)
    {
        case 1:
            CriarProduto();
            break;
        case 2:
            ListarProdutos();
            break;
        case -1:
            Console.WriteLine("Até logo");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

void CriarProduto()
{
    Console.Clear();

    ExibirTitutoDaOpcao("Cadastro de produto");

    Console.Write("Digite o nome de um produto que deseja registrar: ");

    string nomeDoProduto = Console.ReadLine()!;

    listaDeProdutos.Add(nomeDoProduto);

    Console.Write($"O produto {nomeDoProduto} foi registrado com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ListarProdutos()
{
    Console.Clear();
    ExibirTitutoDaOpcao("Exibindo todos os produtos cadastrados");
    for (int i = 0; i < listaDeProdutos.Count; i++)
    {
        Console.WriteLine($"{listaDeProdutos[i]}");
    }

    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal");

    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();

}

void ExibirTitutoDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.Write(asteriscos + "\n");
    Console.Write(titulo);
    Console.Write("\n" + asteriscos + "\n\n");
}

ExibirOpcoesDoMenu();