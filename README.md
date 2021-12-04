# Sistema de cadastro de clientes
Repositório do sistema de cadastro de pessoas físicas e jurídicas criado para a empresa ClientLab.

## Funcionalidades
O sistema é capaz de:
- Cadastrar pessoas físicas maiores de 18 anos, com nome, CPF, data de nascimento, rendimento e endereço;
- Cadastrar pessoas jurídicas, com nome, razão social, CNPJ, rendimento e 
endereço;
- Calcular o imposto a ser pago com base no rendimento informado;
- Listar clientes já cadastrados;
- Salvar registros de pessoas físicas em arquivos .txt;
- Salvar registros de pessoas jurídicas em arquivos .csv.

## Tecnologias usadas:
Esse sistema foi desenvolvido com:
### Programação
- [C#](https://docs.microsoft.com/pt-br/dotnet/csharp/)
- [.NET](https://dotnet.microsoft.com)
### Editor
[Visual Studio Code](https://code.visualstudio.com) 
#### Extensões
- C#
- C# Snippets
- C# Extensions
- C# XML Documentation

## Organização do projeto
O projeto foi organizado no Trello

## Requisitos de instalação
Para instalar o sistema, você precisa:
- Ter uma conta no GitHub;
- Ter o Git instalado;
- Ter o .NET instalado.

## Como executar
1- Clone o repositório
```bash
> git clone https://github.com/ana-clara-candida/cadastro-de-clientes
```

2- Entre no repositório
```bash
> cd cadastro-de-clientes
```
3- Execute a aplicação pelo .NET
```bash
>dotnet run
```

## Erros comuns
### Aplicação não inicia
- Instale (ou reinstale) o .NET SDK
- Instale (ou reinstale) o C#

### Execução para após algum input
Verifique se você inseriu:
- O rendimento como um número com ou sem casas decimais;
- A data de nascimento no formato AAAA-MM-DD;
- O número do endereço como um número inteiro
E tente executar novamente

## Contribuidores
Para contribuir com o projeto:
- Clone o repositório para sua máquina;
- Crie uma branch;
- Faça as alterações necessárias;
- Envie um pull request.
