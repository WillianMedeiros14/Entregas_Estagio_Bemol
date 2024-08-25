using Comex.Menus;
using Comex.Modelos;
using Spectre.Console;

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



    internal void ListarClientes(List<Cliente> clientes, bool mostrarIdentificacao = true)
    {
        if (clientes.Count == 0)
        {
            Console.WriteLine("Nenhum cliente cadastrado.");
        }
        else
        {

            var table = new Table();

            table.Title("Clientes");
            table.Title("Cliente");
            table.AddColumn("Nome");
            table.AddColumn("CPF");
            table.AddColumn("E-mail");
            table.AddColumn("Profissão");
            table.AddColumn("Telefone");
            table.AddColumn("Rua");
            table.AddColumn("Número");
            table.AddColumn("Complemento");
            table.AddColumn("Bairro");
            table.AddColumn("Cidade");
            table.AddColumn("Estado");

            foreach (var cliente in clientes)
            {
                table.AddRow(cliente.Nome, cliente.CPF, cliente.Email, cliente.Profissao, cliente.Telefone,
                             cliente.Endereco.Rua, cliente.Endereco.Numero.ToString(), cliente.Endereco.Complemento,
                             cliente.Endereco.Bairro, cliente.Endereco.Cidade, cliente.Endereco.Estado);
            }

            AnsiConsole.Write(table);

            if (mostrarIdentificacao)
            {
                Console.WriteLine("\n -- Identificação");
                foreach (var cliente in clientes)
                {
                    Console.WriteLine(cliente.Identificar());
                }
            }
        }
    }

}