namespace CadastroCilente
{
    public class PessoaJuridica : Pessoa
    {
        public string cnpj { get; set; } //Criando o atributo CNPJ, que é uma string pública
        public string razaoSocial { get; set; } //Criando o atributo razão social, que também é uma string pública
        public override void pagarImposto(float salario){ //Sobrescrevendo o método pagar imposto

        }
        
        
        
        
    }
}