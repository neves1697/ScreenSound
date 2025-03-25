namespace Exercicios._11_MediaCarrosVendidos;
/*
Com base na lista de super carros fornecida acima, onde a chave é o nome do carro e os valores são quantas vezes 
esse carro foi vendido por ano, calcule a média de uma chave específica.
*/
public class MediaCarros
{
    Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>> {
    { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
    { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
    { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
    { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
    { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
    };

    public void CalculaMedia()
    {
        foreach (var valores in vendasCarros)
        {
            string carros = valores.Key;
            List<int> vezesVendasCarro = valores.Value;
            Console.WriteLine($"Carros: {carros}");
            Console.WriteLine($"Quantodade de vendas: {vezesVendasCarro.Sum()} \n");
            
        }
        double mediaVendasBugatti = vendasCarros["Bugatti Veyron"].Average();
        Console.WriteLine("Média de vendas do Bugatti Veyron: " + mediaVendasBugatti);
    }

    public void Menu()
    {
        int opcao;
        do
        {
            Console.WriteLine("1 - Exibir média vendas carros\n");
            opcao = int.Parse(Console.ReadLine()!);
            switch (opcao)
            {
                case 1: CalculaMedia();
                    break;
                default:
                    Console.WriteLine("Dados inválidos...\n");
                    break;
            }
        }
        while (opcao != 0);

    }

}

