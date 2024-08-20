
using Comex.Modelos;

string mensagemDeBoasVindas = "Bem-vindos ao Comex.";

Console.WriteLine(mensagemDeBoasVindas);

List<string> listaDeProdutos = new List<string> { "Arroz", "Feijão" };

List<Cliente> listaDeClientes = new List<Cliente>();

Cliente cliente1 = new();
Endereco endereco1 = new();

cliente1.Nome = "Willian da Silva Medeiros";
cliente1.CPF = "000-000-000-00";
cliente1.Email = "willian@gmail.com";
cliente1.Profissao = "Desenvolverdor";
cliente1.Telefone = "992154878";

endereco1.Rua = "Vera Cruz Principal";
endereco1.Numero = 100;
endereco1.Complemento = "Sem complemento";
endereco1.Bairro = "Vera Cruz";
endereco1.Cidade = "Maués";
endereco1.Estado = "AM";

cliente1.AdicionaEndereco(endereco1);

listaDeClientes.Add(cliente1);

List<Produto> produtos = new List<Produto>();
produtos.Add(new Produto("Farinha", "Farinha da Vera Cruz", 10.5f, 2));
produtos.Add(new Livro("A Fúria dos Reis. As Crônicas de Gelo e Fogo - Livro 2", "Edição comemorativa. Novo formato 16x23cm e nova capa, criada pelo ilustrador francês Marc Simonetti. De um dos maiores mestres da fantasia surge um épico magistral, poderoso como você jamais viu. ", 30.0f, 5, "854410293X", 656));
produtos.Add(new ProdutoEletronico("Smartphone", "Celular com tela touch", 1200.0f, 15, 110, 20));

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite o número da opção:");
    Console.WriteLine("1: Criar Produto");
    Console.WriteLine("2: Listar Produtos");
    Console.WriteLine("3: Listar Clientes");
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
        case 3:
            ListarClientes();
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

    Console.Write("Nome: ");
    string nomeDoProduto = Console.ReadLine()!;

    Console.Write("Descrição: ");
    string descricaoDoProduto = Console.ReadLine()!;

    Console.Write("Preço unitário: ");
    float precoUnitarioDoProduto = float.Parse(Console.ReadLine()!);

    Console.Write("Quantidade: ");
    int quantidadeDoProduto = int.Parse(Console.ReadLine()!);

    Produto produto = new(nomeDoProduto, descricaoDoProduto, precoUnitarioDoProduto, quantidadeDoProduto);


    produtos.Add(produto);

    Console.Write($"\nO produto {nomeDoProduto} foi registrado com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ListarProdutos()
{
    Console.Clear();
    ExibirTitutoDaOpcao("Exibindo todos os produtos cadastrados");

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

    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal");

    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();

}

void ListarClientes()
{
    Console.Clear();
    ExibirTitutoDaOpcao("Exibindo todos os clientes cadastrados");

    foreach (var cliente in listaDeClientes)
    {
        Console.WriteLine($"Nome: {cliente.Nome}");
        Console.WriteLine($"CPF: {cliente.CPF}");
        Console.WriteLine($"E-mail: {cliente.Email}");
        Console.WriteLine($"Profissão: {cliente.Profissao}");
        Console.WriteLine($"Telefone: {cliente.Telefone}");
        Console.WriteLine($"Profissão: {cliente.Profissao}");

        Console.WriteLine($"Rua: {cliente.Endereco.Rua}");
        Console.WriteLine($"Número: {cliente.Endereco.Numero}");
        Console.WriteLine($"Complemento: {cliente.Endereco.Complemento}");
        Console.WriteLine($"Bairro: {cliente.Endereco.Bairro}");
        Console.WriteLine($"Cidade: {cliente.Endereco.Cidade}");
        Console.WriteLine($"Estado: {cliente.Endereco.Estado}");

        Console.WriteLine($"\n -- Indentificação");
        Console.WriteLine(cliente.Identificar());
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