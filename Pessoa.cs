namespace CadastroCilente
{
    public abstract class Pessoa  // criando a classe abstrata Pessoa
    {
        public string nome { get; set; } // criando o atributo de nome
        public string endereco { get; set; } // criando o atributo de endereço
        public bool enderecoComercial { get; set; } // criando o atributo que verifica se o endereço é comercial ou não
        public void pagarImposto(){ // criando o método para pagar imposto

        }
        
        
        
        
        
    }
}
