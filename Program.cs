using System;
using System.Threading;

namespace CadastroCilente
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string opcao; // Criando a variável que armazena a opção escolhida pelo usuário

            Console.Clear(); // Limpa o console para a execução do programa
            Console.Write(@$"Iniciando... "); // Mensagenm de carregamento
            Thread.Sleep(600); // Para a execução do programa por 600ms (0,6 segundos)
            for (var i = 0; i < 10; i++) // Contador que adiciona os caracteres durante o carregamento. Para i < 10, incrementando seu valor a cada execução...
            {
                Console.Write("*"); // ...coloque um * no console
            }

            Console.ForegroundColor = ConsoleColor.DarkGreen; // Define a cor da fonte do console como verde escuro
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
..:::::::::::::::::::::::::::::::::::::::::::::::"); // Exibe a tela de inicialização do programa

     Console.ResetColor(); // Reseta a cor do console

    do // Começo do loop do menu. Faça...
    {
        Console.ForegroundColor = ConsoleColor.Cyan; // Define a cor da fonte do console como ciano
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
|____________________________________________|"); // Exibe o menu
       
        Console.ResetColor(); // Reseta a cor do console
        opcao = Console.ReadLine().ToLower(); // Faz com que a variável opcao receba o input do usuário convertido para minúsculo

        switch(opcao) { // Criando o switch case da opção do usuário
            case "f": // Caso seja f...
                Console.WriteLine("pessoa física"); //...escreve pessoa física no console
                PessoaFisica pf = new PessoaFisica(); // Cria uma nova pessoa física
                Endereco end = new Endereco(); // Cria um novo endereço

                // Definindo os atributos do endereço
                end.logradouro = "rua n";
                end.numero = 42;
                end.complemento = "Bem ali";
                end.enderecoComercial = false;
                
                // Define os atributos da pessoa (incluindo o endereço que criamos anteriormente)
                pf.endereco = end;
                pf.cpf = "64596045603496";
                pf.nome = "exemplo";
                pf.dataNascimento = new DateTime(2003, 05, 04);
                pf.rendimento = 5001;

                pf.validarDataNascimento(pf.dataNascimento); // Chama o método para validar a data de nascimento
                Console.WriteLine($"{end.logradouro}, n° {end.numero}"); // Mostra o logradouro e o número no console
                if(pf.validarDataNascimento(pf.dataNascimento) == true){ // Se o método de validação retornar verdadeiro...
                    Console.WriteLine($"Cadasto realizado com sucesso!"); // Mostra no console que o cadastro foi realizado com sucesso
                }else{ // Se não...
                    Console.WriteLine($"Erro: Você precisa ser maior de idade para se cadastrar"); // Mostra uma mensagem de erro no console
                }

                Console.WriteLine(pf.pagarImposto(pf.rendimento)); // Mostra o retorno do método de pagar imposto no console
                
                break;

            case "j": // Caso seja j...
                Console.WriteLine("pessoa jurídica"); //...escreve pessoa jurídica no console
                PessoaJuridica aaaa = new PessoaJuridica(); // Cria uma nova pessoa jurídica
                Endereco end1 = new Endereco(); // Cria um novo endereço

                // Define os atributos do endereço
                end1.logradouro = "rua x";
                end1.numero = 96;
                end1.complemento = "Em algum lugar";
                end1.enderecoComercial = true;

                // Define os atributos da pessoa (incluindo o endereço criado anteriormente)
                aaaa.razaoSocial = "abcd";
                aaaa.cnpj = "12345678000190";
                aaaa.endereco = end1;
                aaaa.rendimento = 5000;


                aaaa.validarCnpj(aaaa.cnpj); // Chama o método de validação de cnpj
                if(aaaa.validarCnpj(aaaa.cnpj)){ // Se o CNPJ informado for válido...
                    Console.WriteLine($"Cadastro realizado com sucesso!");  //...mostre no console que o cadastro foi realizado com sucesso
                }else{ //Se não...
                    Console.WriteLine($"Erro: O CNPJ informado é inválido"); //...mostra uma mensagem de erro no console
                }

                Console.WriteLine(aaaa.pagarImposto(aaaa.rendimento)); // Mostra o retorno do método de pagar imposto no console
                

                break;

            case "s": // Caso seja s...
                Console.WriteLine("Encerrando sistema"); // ...mostra no console a mensagem de encerramento do sistema
                Console.ResetColor(); // Reseta a cor do console
                break;
            default: // Define a saída padrão
                Console.WriteLine("Opção inválida, tente novamente"); // Mostra no console a mensagem de opção inválida
                break;
            }      
    }   while (opcao != "s"); // ...enquanto a opção selecionada for diferente de s
    }

    }
}