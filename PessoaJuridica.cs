
namespace CadastroCilente
{
    public class PessoaJuridica : Pessoa
    {
        public string cnpj { get; set; } // Criando o atributo CNPJ, que é uma string pública
        public string razaoSocial { get; set; } // Criando o atributo razão social, que também é uma string pública
        public override double pagarImposto(double rendimento){ // Sobrescrevendo o método de pagar imposto
            if(rendimento <= 5000){ // Se o rendimento for menor ou igual a 5000;
                return rendimento * 0.06; // ...retorne 6% do rendimento (ou rendimento . 0,06)
        }else if(rendimento <= 10000){ // Se o rendimento for menor ou igual a 10000...
                return rendimento * 0.08; // ...retorne 8% do rendimento (ou rendimento . 0,08)
        }else{ // Se não...
          return rendimento * 0.1; //...retorne 10% do rendimento (ou rendimento . 0,1)
        }
        } 
        
         public bool validarCnpj(string vcnpj){ // Criando o método de validação de CNPJ
            if(vcnpj.Length == 14 && vcnpj.Substring(vcnpj.Length - 6, 4) == "0001"){ // Se o tamanho da string recebida para o CNPJ for 14 e os 4 caracteres a partir da posição 6 sejam 0001...
                return true; //...retorne verdadeiro
            }
            return false; // Caso contrário, o método retorna falso
        
        
    }
    }
}