namespace CadastroCilente
{
    public class Endereco // Criando a classe endereço
    {
        public string logradouro {get; set;} // Criando o atributo logradouro, que é uma string pública
        public int numero {get; set;} // Criando o atributo número, que é um inteiro público
        public string complemento {get; set;} // Criando o atributo complemento, que é uma string pública
        public bool enderecoComercial {get; set;} // Criando o atributo endereço comercial, que registra se um endereço é (verdadeiro) ou não (falso) um endereço comercial

    }
}