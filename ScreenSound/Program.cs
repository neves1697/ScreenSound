using System;
using System.Collections.Generic;

class Program
{
    // Screen Sound
    string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
    //List<string> listaDasBandas = new List<string> { "U2", "The Beatles", "Calypso" };
    List<string> listaBandas = new List<string>();

    static void Main(string[] args)
    {
        Program program = new Program(); // Cria uma instância da classe Program
        program.ExibirOpcoesDoMenu(); // Chama o método para exibir o menu
    }

    void ExibirLogo()
    {
        Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
        Console.WriteLine(mensagemDeBoasVindas);
    }

    void ExibirOpcoesDoMenu()
    {
        ExibirLogo();
        Console.WriteLine("\nDigite 1 para registrar uma banda");
        Console.WriteLine("Digite 2 para mostrar todas as bandas");
        Console.WriteLine("Digite 3 para avaliar uma banda");
        Console.WriteLine("Digite 4 para exibir a média de uma banda");
        Console.WriteLine("Digite -1 para sair");

        Console.Write("\nDigite a sua opção: ");
        string opcaoEscolhida = Console.ReadLine()!;
        int opcaoEscolhidaNumerica;

        // Verifica se a opção escolhida é um número
        if (int.TryParse(opcaoEscolhida, out opcaoEscolhidaNumerica))
        {
            switch (opcaoEscolhidaNumerica)
            {
                case 1:
                    RegistrarBandas();
                    break;
                case 2:
                    MostrarBandas();
                    break;
                case 3:
                    Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
                    break;
                case 4:
                    Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
                    break;
                case -1:
                    Console.WriteLine("Tchau tchau :)");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Por favor, insira um número válido.");
        }
    }

    void RegistrarBandas()
    {
        Console.Clear();
        //ExibirOpcoesDoMenu();

        Console.WriteLine("Registro de bandas");
        Console.Write("Digite o nome da banda para cadastrar: ");
        string nomeBanda = Console.ReadLine()!;
        listaBandas.Add(nomeBanda); // Adiciona a banda à lista
        Console.WriteLine($"A banda {nomeBanda} foi cadastrada com sucesso!");
        ExibirOpcoesDoMenu(); // Exibe o menu novamente
    }

    void MostrarBandas()
    {
        Console.Clear();
        Console.WriteLine("Lista de bandas registradas");

        for (int i = 0; i < listaBandas.Count; i++)
        {
            Console.WriteLine($"Banda: {listaBandas[i]} ");
        }

        Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}