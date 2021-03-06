using System;

namespace CadastroCilente
{
    public class PessoaFisica : Pessoa // Criando a classe Pessoa Física, que herda atributos da Pessoa
    {
        public string cpf { get; set; } // Criando o atributo CPF, que é uma string pública
        public DateTime dataNascimento { get; set; } // Criando o atributo data de nascimento, que é uma data pública
        public override double pagarImposto(double rendimento){ // Sobrescrevendo o método de pagar imposto
        if(rendimento <= 1500){ // Se o rendimento for menor ou igual a 1500...
        return 0; // Retorne 0
        }else if(rendimento <= 5000){ // Se o rendimento for menor ou igual a 5000...
          return rendimento * .03; // Retorne 3% do rendimento (ou rendimento . 0,03) 
        }else{ // Se não...
         return .05 * rendimento; // Retorne 5% do rendimento (ou rendimento . 0,05)
        }

        }
        public bool validarDataNascimento (DateTime dataNasc){ // Criando o método booleano para validação da data de nascimento

        DateTime dataAtual = DateTime.Today; // Criando a variável que guardará a data atual
        double anos = (dataAtual - dataNasc).TotalDays/365; // Idade do cliente em anos. Armazena o resultado da subtração entre a data atual e a data de nascimento em dias divido por 365
        if (anos >= 18){ // Se a idade do cliente for maior ou igual a 18...
            return true; // Retorne verdadeiro
            
        }
        return false; // Caso contrário, retorne falso

      }  
     }
        
      
        
        
    }
  
