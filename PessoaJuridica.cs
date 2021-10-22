
namespace CadastroCilente
{
    public class PessoaJuridica : Pessoa
    {
        public string cnpj { get; set; } // Criando o atributo CNPJ, que é uma string pública
        public string razaoSocial { get; set; } // Criando o atributo razão social, que também é uma string pública
        public override void pagarImposto(float salario){ // Sobrescrevendo o método pagar imposto

        }
        
         public bool validarCnpj(string vcnpj){
            if(vcnpj.Length == 14 && vcnpj.Substring(vcnpj.Length - 4) == "0001"){
                return true;
            }
            return false;
        
        
    }
    }
}