
class Cliente
{
    public String Nome { get; set; }
    public String CPF { get; set; }
    public String Email { get; set; }
    public String Profissao { get; set; }
    public String Telefone { get; set; }
    public Endereco Endereco { get; set; }

    public void AdicionaEndereco(Endereco endereco)
    {
        this.Endereco = endereco;
    }
}
