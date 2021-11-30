using System;
using System.Collections.Generic;
using System.Threading;

namespace CadastroCilente
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PessoaFisica> listapf = new List<PessoaFisica>();
            List<PessoaJuridica> listaj = new List<PessoaJuridica>();
            
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
|  Pessoa física:                            |
|                                            |
|   'cf' - cadastrar                         |
|   'lf' - listar                            |
|   'rf' - remover                           |
|--------------------------------------------|                           
| Pessoa jurídica:                           |
|                                            |
|   'cj' - cadstrar                          |
|   'lj' - listar                            |
|   'rj' - remover                           |   
|--------------------------------------------|
|   's' - sair do programa                   |
|____________________________________________|"); // Exibe o menu
       
        Console.ResetColor(); // Reseta a cor do console
        opcao = Console.ReadLine().ToLower(); // Faz com que a variável opcao receba o input do usuário convertido para minúsculo

        switch(opcao) { // Criando o switch case da opção do usuário
            case "cf": // Caso seja f...
                Console.WriteLine("pessoa física"); //...escreve pessoa física no console
                PessoaFisica pf = new PessoaFisica(); // Cria uma nova pessoa física
                Endereco end = new Endereco(); // Cria um novo endereço

                // Cadastra os atributos da pessoa 
                Console.WriteLine("Informe o nome: ");
                pf.nome = Console.ReadLine();
                Console.WriteLine("Informe o CPF: ");
                pf.cpf = Console.ReadLine();
                Console.WriteLine("Informe a data de nascimento (aaaa-mm-dd): ");
                pf.dataNascimento = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Informe o rendimento: ");
                pf.rendimento = Convert.ToDouble(Console.ReadLine());

                // Cadastra o endereço
                Console.WriteLine("Iniciaremos o cadastro do seu endereço.");
                Console.WriteLine("Informe o nome da rua: ");
                end.logradouro = Console.ReadLine();
                Console.WriteLine("Informe o número: ");
                end.numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Informe o complemento (opcional, pressione ENTER para pular): ");
                end.complemento = Console.ReadLine();
                Console.WriteLine("Esse endereço é comercial? (s/n)");
                string endcom = Console.ReadLine().ToLower();
                if (endcom == "s"){
                    end.enderecoComercial = true;
                }else{
                    end.enderecoComercial = false;
                }
            
                pf.endereco = end; // Aribui o endereço criado à pessoa física

                pf.validarDataNascimento(pf.dataNascimento); // Chama o método para validar a data de nascimento
                if(pf.validarDataNascimento(pf.dataNascimento) == true){ // Se o método de validação retornar verdadeiro...
                    Console.WriteLine($"Cadasto realizado com sucesso!"); // Mostra no console que o cadastro foi realizado com sucesso
                    listapf.Add(pf);
                    Console.WriteLine(pf.pagarImposto(pf.rendimento)); // Mostra o retorno do método de pagar imposto no console

                }else{ // Se não...
                    Console.WriteLine($"Erro: Você precisa ser maior de idade para se cadastrar"); // Mostra uma mensagem de erro no console
                }

                break;
            case "lf":
                foreach (var item in listapf)
                {
                    Console.WriteLine($"Nome: {item.nome}, CPF: {item.cpf}, Data de nascimento: {item.dataNascimento}");
                }
            break;        
            case "rf":
                Console.WriteLine($"Informe o CPF da pessoa que deseja remover:");
                string buscacpf = Console.ReadLine();
                PessoaFisica pessoaBuscada = listapf.Find(item => item.cpf == buscacpf);
                if (pessoaBuscada != null){
                    listapf.Remove(pessoaBuscada);
                    Console.WriteLine($"Pessoa removida");
                }else{
                    Console.WriteLine($"CPF não cadastrado");
                    
                }
            break;
            case "cj": // Caso seja j...
                Console.WriteLine("pessoa jurídica"); //...escreva pessoa jurídica no console
                PessoaJuridica aaaa = new PessoaJuridica(); // Cria uma nova pessoa jurídica
                Endereco end1 = new Endereco(); // Cria um novo endereço

                // Define os atributos da pessoa (incluindo o endereço criado anteriormente)
                Console.WriteLine("Informe a razão social: ");
                aaaa.razaoSocial = Console.ReadLine();
                Console.WriteLine("Informe o CNPJ: ");
                aaaa.cnpj = Console.ReadLine();
                Console.WriteLine("Informe o rendimento: ");
                aaaa.rendimento = Convert.ToDouble(Console.ReadLine());

                // Define os atributos do endereço
                Console.WriteLine($"iniciaremos o cadastro do seu endereço");
                Console.WriteLine("Informe o nome da rua: ");
                end1.logradouro = Console.ReadLine();
                Console.WriteLine("Informe o número: ");
                end1.numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Informe o complemento (opcional, pressione ENTER para pular): ");
                end1.complemento = Console.ReadLine();
                Console.WriteLine("Esse endereço é comercial? (s/n)");
                string endcom1 = Console.ReadLine().ToLower();
                if (endcom1 == "s"){
                    end1.enderecoComercial = true;
                }else{
                    end1.enderecoComercial = false;
                }
                
                aaaa.endereco = end1;

                aaaa.validarCnpj(aaaa.cnpj); // Chama o método de validação de CNPJ
                if(aaaa.validarCnpj(aaaa.cnpj)){ // Se o CNPJ informado for válido...
                    Console.WriteLine($"Cadastro realizado com sucesso!");  //...mostre no console que o cadastro foi realizado com sucesso
                    listaj.Add(aaaa);
                }else{ //Se não...
                    Console.WriteLine($"Erro: O CNPJ informado é inválido"); //...mostre uma mensagem de erro no console
                }

                Console.WriteLine(aaaa.pagarImposto(aaaa.rendimento)); // Mostra o retorno do método de pagar imposto no console
                

                break;
            case "lj":
              foreach (var item in listaj)
                {
                    Console.WriteLine($"Razão social: {item.razaoSocial}, CNPJ: {item.cnpj}, Logradouro: {item.endereco.logradouro}");
                }  
            break;
            case "rj":
                Console.WriteLine($"Informe o CNPJ da pessoa que deseja remover:");
                string buscacnpj = Console.ReadLine();
                PessoaJuridica pessoaJBuscada = listaj.Find(item => item.cnpj == buscacnpj);
                if (pessoaJBuscada != null){
                    listaj.Remove(pessoaJBuscada);
                    Console.WriteLine($"Pessoa removida");
                }else{
                    Console.WriteLine($"CNPJ não cadastrado");
                    
                }
            break;
            case "s": // Caso seja s...
                Console.WriteLine("Encerrando sistema"); // ...mostre no console a mensagem de encerramento do sistema
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