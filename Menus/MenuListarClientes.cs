using Comex.Menus;
using Comex.Modelos;

internal class MenuListarClientes : Menu
{
    private readonly List<Cliente> _clientes;
    public MenuListarClientes(List<Cliente> clientes)
    {
        _clientes = clientes;
    }
    public override void Executar()
    {
        base.Executar();

        ExibirTituloDaOpcao("Exibindo todos os clientes cadastrados");

        ListarClientes(_clientes);

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }

    internal void ListarClientes(List<Cliente> clientes)
    {
        if (_clientes.Count == 0)
        {
            Console.WriteLine("Nenhum cliente cadastrado.");
        }
        else
        {

            foreach (var cliente in clientes)
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
        }

    }
}