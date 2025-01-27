using System;
using System.Collections.Generic;

class Program
{
    // Screen Sound
    string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
    //List<string> listaDasBandas = new List<string> { "U2", "The Beatles", "Calypso" };
    //List<string> listaBandas = new List<string>();

    Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();

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
                    AvaliarBanda();
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

        //Console.WriteLine("Registro de bandas");
        ExibirTituloOpcoes("Registro de bandas");
        Console.Write("Digite o nome da banda para cadastrar: ");
        string nomeBanda = Console.ReadLine()!;
        //listaBandas.Add(nomeBanda); // Adiciona a banda à lista

        //usando dicionário
        bandasRegistradas.Add(nomeBanda, new List<int>());// as notas ainda não estarão preenchidas porque preencheremos depois.

        Console.WriteLine($"A banda {nomeBanda} foi cadastrada com sucesso!");
        ExibirOpcoesDoMenu(); // Exibe o menu novamente
    }

    void MostrarBandas()
    {
        Console.Clear();
        //Console.WriteLine("Lista de bandas registradas");
        ExibirTituloOpcoes("Lista de bandas registradas");

        foreach (string banda in bandasRegistradas.Keys)
        {
            Console.WriteLine($"Banda: {banda} ");
        }

        Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

    void ExibirTituloOpcoes(string titulo)
    {
        int quantidadeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }

    /*
        - Digitar banda que deseja avaliar
        - Verificar se a banda existir no dicionário, se existir, atribuir nota
        - Se não existir a banda, exibe uma mensagem e volta para o menu principal
    */

    void AvaliarBanda()
    {
        Console.Clear();
        ExibirTituloOpcoes("Avaliar banda");
        Console.Write("Digite o nome da banda para avaliar: ");
        string nomeBanda = Console.ReadLine()!;

        //pesquisando o nome da banda através da chave do dicionário

        if (bandasRegistradas.ContainsKey(nomeBanda))
        {
            Console.Write($"Digite a nota para a banda {nomeBanda} = ");
            int nota = int.Parse(Console.ReadLine()!);
            //pegando a banda pelo colchete e adicionando a nota à ela.
            bandasRegistradas[nomeBanda].Add(nota);
            Console.WriteLine($"Nota {nota} registrada para a banda {nomeBanda} ");
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeBanda} não foi encontrado... ");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesDoMenu();
        }
    }
}