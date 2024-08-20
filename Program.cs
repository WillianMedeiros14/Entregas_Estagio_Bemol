
using Comex.Menus;
using Comex.Modelos;
using ScreenSound.Menus;

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


Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuCriarProduto(produtos));
opcoes.Add(2, new MenuListarProdutos(produtos));
opcoes.Add(3, new MenuListarClientes(listaDeClientes));
opcoes.Add(-1, new MenuSair());

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

    if (opcoes.ContainsKey(opcaoScolhidaNumerica))
    {

        Menu menuASerExibido = opcoes[opcaoScolhidaNumerica];
        menuASerExibido.Executar();
        if (opcaoScolhidaNumerica > 0) ExibirOpcoesDoMenu();
    }
    else
    {

        Console.Clear();
        Console.WriteLine("Opção inválida");

        ExibirOpcoesDoMenu();
    }

}

ExibirOpcoesDoMenu();