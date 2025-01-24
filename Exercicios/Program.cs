using Exercicios.Ex4;

ListasBuscaDadosCadastrados l = new();

int opcao = 0;

do
{
    Console.WriteLine("\n1 - Cadastro");
    Console.WriteLine("2 - Exibir campeões");
    Console.WriteLine("3 - Exibir campeões ordenados Ascendente");
    Console.WriteLine("0 - Sair\n");

    opcao = int.Parse(Console.ReadLine()!);

    switch (opcao)
    {
        case 1:
            l.CadastrarCampeoes();
            break;
        case 2:
            l.ExibirCampeoes();
            break;
        
        case 0:
            Console.WriteLine("Encerrando programa!!!");
            break;
        default:
            Console.WriteLine("Dados inválidos");
            break;
    }
} while (opcao != 0);