using System;
using System.Threading;

namespace CadastroCilente
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string opcao;

            Console.Clear();
            Console.Write(@$"Iniciando...");
            Thread.Sleep(600);
            for (var i = 0; i < 10; i++)
            {
                Console.Write("*");
            }

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@$"
                                                                                 
                   8                 o                      8        
                   8                 8                      8        
.oPYo. .oPYo. .oPYo8 .oPYo. .oPYo.  o8P oPYo. .oPYo.   .oPYo8 .oPYo. 
8    ' .oooo8 8    8 .oooo8 Yb..     8  8  `' 8    8   8    8 8oooo8 
8    . 8    8 8    8 8    8   'Yb.   8  8     8    8   8    8 8.     
`YooP' `YooP8 `YooP' `YooP8 `YooP'   8  8     `YooP'   `YooP' `Yooo' 
:.....::.....::.....::.....::.....:::..:..:::::.....::::.....::.....:
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                                                 
                                                 
.oPYo. .oPYo. .oPYo. .oPYo. .oPYo. .oPYo. .oPYo. 
8    8 8oooo8 Yb..   Yb..   8    8 .oooo8 Yb..   
8    8 8.       'Yb.   'Yb. 8    8 8    8   'Yb. 
8YooP' `Yooo' `YooP' `YooP' `YooP' `YooP8 `YooP' 
8 ....::.....::.....::.....::.....::.....::.....:
8 :::::::::::::::::::::::::::::::::::::::::::::::
..:::::::::::::::::::::::::::::::::::::::::::::::");

     Console.ResetColor();

    
  
    do
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(@$"
++++++++++++++++++++++++++++++++++++++++++++++
|       Selecione uma das opções abaixo:     |
|--------------------------------------------|
|                                            |
|   'f' - cadastrar uma pessoa física        |
|   'j' - cadastrar uma pessoa jurídica      |
|                                            |
|                                            |
|   's' - sair do programa                   |
|____________________________________________|"); 
        Console.ResetColor();


        opcao = Console.ReadLine().ToLower();
        switch(opcao)
        {
            case "f":
                Console.WriteLine("pessoa física");
                PessoaFisica pf = new PessoaFisica(); // Criando uma nova pessoa física
                Endereco end = new Endereco(); // Criando um novo endereço

                // Definindo os atributos do endereço
                end.logradouro = "rua n";
                end.numero = 42;
                end.complemento = "Bem ali";
                end.enderecoComercial = false;
                
                // Definindo os atributos da pessoa (incluindo o endereço que criamos anteriormente)
                pf.endereco = end;
                pf.cpf = "64596045603496";
                pf.nome = "exemplo";
                pf.dataNascimento = new DateTime(2003, 05, 04);
                pf.rendimento = 5001;

                pf.validarDataNascimento(pf.dataNascimento); // Chamando o método para validar a data de nascimento
                Console.WriteLine($"{end.logradouro}, n° {end.numero}"); // Mostra o logradouro e o número no console
                if(pf.validarDataNascimento(pf.dataNascimento) == true){ // Se o método de validação retornar verdadeiro...
                    Console.WriteLine($"Cadasto realizado com sucesso!"); // Mostre no console que o cadastro foi realizado com sucesso
                }else{ // Se não..
                    Console.WriteLine($"Erro: Você precisa ser maior de idade para se cadastrar"); // Mostre uma mensagem de erro no console
                }

                Console.WriteLine(pf.pagarImposto(pf.rendimento));
                

                break;
            case "j":
                Console.WriteLine("pessoa jurídica");
                PessoaJuridica aaaa = new PessoaJuridica(); // Criando uma nova pessoa jurídica
                Endereco end1 = new Endereco(); // Criando um novo endereço

                // Definindo os atributos do endereço
                end1.logradouro = "rua x";
                end1.numero = 96;
                end1.complemento = "Em algum lugar";
                end1.enderecoComercial = true;

                // Definindo os atributos da pessoa (incluindo o endereço criado anteriormente)
                aaaa.razaoSocial = "abcd";
                aaaa.cnpj = "12345678000190";
                aaaa.endereco = end1;
                aaaa.rendimento = 5000;


                aaaa.validarCnpj(aaaa.cnpj);
                if(aaaa.validarCnpj(aaaa.cnpj)){
                    Console.WriteLine($"Cadastro realizado com sucesso!");   
                }else{
                    Console.WriteLine($"Erro: O CNPJ informado é inválido");
                }

                Console.WriteLine(aaaa.pagarImposto(aaaa.rendimento));
                

                break;
            case "s":
                Console.WriteLine("Encerrando sistema");
                Console.ResetColor();
                break;
            default:
                Console.WriteLine("Opção inválida, tente novamente");
                break;
            }      
    }   while (opcao != "s");
    }

    }
}