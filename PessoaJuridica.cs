
namespace CadastroCilente
{
    public class PessoaJuridica : Pessoa
    {
        public string cnpj { get; set; } // Criando o atributo CNPJ, que é uma string pública
        public string razaoSocial { get; set; } // Criando o atributo razão social, que também é uma string pública
        public override double pagarImposto(double rendimento){ // Sobrescrevendo o método pagar imposto
            if(rendimento <= 5000){
                return rendimento * 0.06;
        }else if(rendimento > 5000 && rendimento <= 10000){
                return rendimento * 0.08;
        }else{
          return rendimento * 0.1;
        }
        } 
        
         public bool validarCnpj(string vcnpj){
            if(vcnpj.Length == 14 && vcnpj.Substring(vcnpj.Length - 6, 4) == "0001"){
                return true;
            }
            return false;
        
        
    }
    }
}