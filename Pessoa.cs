namespace CadastroCilente
{
     public abstract class Pessoa  // Criando a classe abstrata Pessoa
    {
        public string nome { get; set; } // Criando o atributo nome
        public Endereco endereco {get; set;} // Criando o atributo endereço
        public double rendimento {get;set;}
        public abstract double pagarImposto (double rendimento);
            
    }
}
        
