using System;

namespace CadastroCilente
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica(); //Criando uma nova pessoa física
            Endereco end = new Endereco(); //Criando um novo endereço

//Definindo os atributos do endereço
            end.logradouro = "rua n";
            end.numero = 42;
            end.complemento = "Bem ali";
            end.enderecoComercial = false;
//Definindo os atributos da pessoa (incluindo o endereço que criamos anteriormente)
            pf.endereco = end;
            pf.cpf = "64596045603496";
            pf.nome = "exemplo";
            pf.dataNascimento = new DateTime(2003, 05, 04);

            pf.validarDataNascimento(pf.dataNascimento); //Chamando o método para validar a data de nascimento
            Console.WriteLine($"{end.logradouro}, n° {end.numero}"); //Mostra o logradouro e o número no console
            if(pf.validarDataNascimento(pf.dataNascimento) == true){ //Se o método de validação retornar verdadeiro...
                Console.WriteLine($"Cadasto realizado com sucesso!"); //Mostre no console que o cadastro foi realizado com sucesso
                
            }else{ //Se não..
                Console.WriteLine($"Erro: Você precisa ser maior de idade para se cadastrar"); //Mostre uma mensagem de erro no console
                
            }
            
            
            
            

        }
    }
}
