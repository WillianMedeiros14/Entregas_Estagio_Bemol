
using Comex.Menus;
using Comex.Modelos;

string mensagemDeBoasVindas = "Bem-vindos ao Comex.";

Console.WriteLine(mensagemDeBoasVindas);

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
produtos.Add(new Produto("Arroz", "Arroz Parboilizado, da marca Tio João, em embalagem com 1 quilo.", 8.39f, 3));
produtos.Add(new Livro("A Fúria dos Reis. As Crônicas de Gelo e Fogo - Livro 2", "Edição comemorativa. Novo formato 16x23cm e nova capa, criada pelo ilustrador francês Marc Simonetti. De um dos maiores mestres da fantasia surge um épico magistral, poderoso como você jamais viu. ", 30.0f, 5, "854410293X", 656));
produtos.Add(new ProdutoEletronico("Smartphone", "Celular com tela touch", 1200.0f, 15, 110, 20));

List<Pedido> pedidos = new List<Pedido>();

Pedido pedido1 = new Pedido(cliente1, DateTime.Now);

ItemDePedido itemPedido1 = new ItemDePedido
{
    Produto = produtos[0],
    Quantidade = 3,
};

ItemDePedido itemPedido2 = new ItemDePedido
{
    Produto = produtos[1],
    Quantidade = 1,
};


pedido1.AdicionarItem(itemPedido1);
pedido1.AdicionarItem(itemPedido2);

pedidos.Add(pedido1);

MenuPrincipal menuPrincipal = new MenuPrincipal(produtos, listaDeClientes, pedidos);
menuPrincipal.Executar();