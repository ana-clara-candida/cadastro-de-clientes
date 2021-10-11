namespace CadastroCilente
{
    public abstract class Pessoa  //Criando a classe abstrata Pessoa
    {
        public string nome { get; set; } //Criando o atributo nome
        public Endereco endereco {get; set;} //Criando o atributo endereço
        public abstract void pagarImposto(float salario); //Criando o método pagar imposto
        
        
        
        
    }
}