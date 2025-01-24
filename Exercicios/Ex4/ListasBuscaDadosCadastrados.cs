namespace Exercicios.Ex4;
public class ListasBuscaDadosCadastrados
{
    /*
    1 - cadastrar dados em strings. Neste exemplo serão cadastros de Campeões do Lol.
    2 - Podemos buscar por nome
    3 - Podemos buscar por ID -- Fazer depois
    4 - Podemos buscar por classes. -- Fazer depois
    */

    List<string>listaCampeoes = new List<string>();
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


}
