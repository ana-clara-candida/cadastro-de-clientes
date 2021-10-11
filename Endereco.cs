namespace CadastroCilente
{
    public class Endereco //criando a classe endereço
    {
        public string logradouro {get; set;} //criando o atributo logradouro, que é uma string pública
        public int numero {get; set;} //criando o atributo número, que é um inteiro público
        public string complemento {get; set;} //criando o atributo complemento, que é uma string pública
        public bool enderecoComercial {get; set;} //criando o atributo endereço comercial, que registra se um endereço é (verdadeiro) ou não (falso) um endereço comercial

    }
}