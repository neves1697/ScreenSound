namespace Exercicios.Ex4;
public class ListasBuscaDadosCadastrados
{
    /*
    1 - cadastrar dados em strings. Neste exemplo serão cadastros de Campeões do Lol.
    2 - Podemos buscar por nome
    3 - Podemos buscar por ID -- Fazer depois
    4 - Podemos buscar por classes. -- Fazer depois
    */

    List<string> listaCampeoes = new List<string>();
    public void CadastrarCampeoes()
    {
        Console.WriteLine("\nCadastro de campeões do LOL");
        Console.Write("Nome: ");

        string campeao = Console.ReadLine()!;
        listaCampeoes.Add(campeao);
    }

    public void ExibirCampeoes()
    {
        foreach (var item in listaCampeoes)
        {
            Console.WriteLine(item);
        }

        List<string> ordenarAscendente = listaCampeoes;
        ordenarAscendente.Sort();
    }

    public void RemoverCampeao(string campeao)
    {
        Console.WriteLine("Nome do campeão: ");
        campeao = Console.ReadLine()!;
        listaCampeoes.Remove(campeao);
        Console.WriteLine("Campeão removido com sucesso!");
    }

    public void ExecutaMenu()
    {
        int opcao = 0;

        do
        {
            Console.WriteLine("\n1 - Cadastro");
            Console.WriteLine("2 - Exibir campeões");
            Console.WriteLine("3 - Deletar campeão");
            Console.WriteLine("0 - Sair\n");

            opcao = int.Parse(Console.ReadLine()!);

            switch (opcao)
            {
                case 1:
                    CadastrarCampeoes();
                    break;
                case 2:
                    ExibirCampeoes();
                    break;
                case 3:
                    string campeao = null!;

                    RemoverCampeao(campeao);
                    break;
                case 0:
                    Console.WriteLine("Encerrando programa!!!");
                    break;
                default:
                    Console.WriteLine("Dados inválidos");
                    break;
            }
        } while (opcao != 0);
    }
}
