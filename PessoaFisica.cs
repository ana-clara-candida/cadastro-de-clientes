using System;

namespace CadastroCilente
{
    public class PessoaFisica : Pessoa // Criando a classe Pessoa Física, que herda atributos da Pessoa
    {
        public string cpf { get; set; } // Criando o atributo CPF, que é uma string pública
        public DateTime dataNascimento { get; set; } // Criando o atributo data de nascimento, que é uma data pública
        public override void pagarImposto(float salario){ // Sobrescrevendo o método de pagar imposto

        }
        
      public bool validarDataNascimento(DateTime dataNasc){ // Criando o método booleano para validação da data de nascimento

        DateTime dataAtual = DateTime.Today; // Criando a variável que guardará a data atual
        double anos = (dataAtual - dataNasc).TotalDays/365; // Idade do cliente em anos. Armazena o resultado da subtração entre a data atual e a data de nascimento em dias divido por 365
        if (anos >= 18){ // Se a idade do cliente for maior ou igual a 18...
            return true; // Retorne verdadeiro
            
        }
        return false; // Caso contrário, retorne falso

      }  
        
        
    }
}