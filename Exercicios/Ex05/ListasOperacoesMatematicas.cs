/*
Escrever uma função que a partir de dois números de ponto flutuante a e b exiba no console 
o resultado de suas quatro operações básicas (adição, subtração, divisão e multiplicação), 
utilizando interpolação de strings.
Criar uma lista de bandas vazia e adicionar suas bandas prediletas em seguida.
Utilizar a estrutura 'for' para mostrar todas as suas bandas preferidas, listadas na
lista do exercício anterior, no console.
Criar um programa que calcula a soma de todos os elementos inteiros em uma lista.
*/

/*
Regras
- Ter dois números com pontos flutuantes: Double , float etc.
- Fazer as quatro operações básicas da matemática.
- Utilizar interpolação de strings para exibir no console.
- Criar uma lista de bandas e adicionar informações à ela.
- Fazer a soma de todos os elementos inteiros da lista.
*/

using System.Linq;

namespace Exercicios.Ex05;
public class ListasOperacoesMatematicas
{
    List<string> listaBandas = new List<string>();
    List<int> listaSomaElementosInteirosLista = new List<int>();
    public void Menu()
    {
        Console.WriteLine("\n1 - Soma\n" +
            "2 - Subtração\n" +
            "3 - Divisão\n" +
            "4 - Multiplicação\n" +
            "5 - Cadastrar bandas\n" +
            "6 - ListarBandas\n" +
            "7 - Cadastrar elementos inteiros de uma lista\n" +
            "8 - Listar elementos soma lista inteira\n" +
            "9 - Somar números da lista\n" +
            "0 - Sair\n");
    }

    void CapturaOpcoesUsuario()
    {
        int opcaoDigitada;
        do
        {
            Menu();

            opcaoDigitada = int.Parse(Console.ReadLine()!);

            switch (opcaoDigitada)
            {
                case 1:
                    double a1 = 0, b1 = 0;
                    Soma(a1, b1);
                    break;
                case 2:
                    double a2 = 0, b2 = 0;
                    Subtracao(a2, b2);
                    break;
                case 3:
                    double a3 = 0, b3 = 0;
                    Divisao(a3, b3);
                    break;
                case 4:
                    double a4 = 0, b4 = 0;
                    Multiplicacao(a4, b4);
                    break;
                case 5:
                    CadastrarBandas();
                    break;
                case 6:
                    ListarBanda();
                    break;
                case 7:
                    CadastrarNumerosListaParaSoma();
                    break;
                case 8:
                    ListarElementosSomaListaInteira();
                    break;
                case 9:
                    SomarNumerosLista();
                    break;
                case 0:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

        } while (opcaoDigitada != 0); // O loop continua até o usuário digitar 0
    }

    public void ExecutaMenu()
    {
        CapturaOpcoesUsuario();
    }

    public void Soma(double a, double b)
    {
        Console.WriteLine("Digite o primeiro número:");
        a = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite o segundo número:");
        b = double.Parse(Console.ReadLine()!);

        double resultadoSoma = a + b;
        Console.WriteLine($"\nA soma é {resultadoSoma:F2}");
    }

    public void Subtracao(double a, double b)
    {
        Console.WriteLine("Digite o primeiro número:");
        a = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite o segundo número:");
        b = double.Parse(Console.ReadLine()!);

        double resultadoSubtracao = a - b;
        Console.WriteLine($"\nO resultado da subtração é {resultadoSubtracao:F2}");
    }

    public void Divisao(double a, double b)
    {
        Console.WriteLine("Digite o primeiro número:");
        a = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite o segundo número:");
        b = double.Parse(Console.ReadLine()!);

        if (b != 0) // Evitar divisão por zero
        {
            double resultadoDivisao = a / b;
            Console.WriteLine($"\nO resultado da divisão é {resultadoDivisao:F2}");
        }
        else
        {
            Console.WriteLine("Não é possível dividir por zero.");
        }
    }

    public void Multiplicacao(double a, double b)
    {
        Console.WriteLine("Digite o primeiro número:");
        a = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite o segundo número:");
        b = double.Parse(Console.ReadLine()!);

        double resultadoMultiplicacao = a * b;
        Console.WriteLine($"\nO resultado da multiplicação é {resultadoMultiplicacao:F2}");
    }

    public void CadastrarBandas()
    {
        Console.Write("Digite o nome da banda para cadastrar: ");
        string banda = Console.ReadLine()!;
        listaBandas.Add(banda);
    }

    public void ListarBanda()
    {
        Console.WriteLine("Lista de bandas registradas");
        for (int i = 0; i < listaBandas.Count; i++)
        {
            Console.WriteLine($"Banda: {listaBandas[i]} ");
        }
    }

    public void CadastrarNumerosListaParaSoma()
    {
        Console.WriteLine("Digite os números. Digite 0 para parar.");

        while (true)
        {
            int numero = int.Parse(Console.ReadLine()!);

            if (numero == 0)
            {
                break;
            }

            listaSomaElementosInteirosLista.Add(numero);

        }
    }

    public void SomarNumerosLista()
    {
        int soma = listaSomaElementosInteirosLista.Sum();
        Console.WriteLine($"Soma dos números da lista: {soma} ");
    }

    public void ListarElementosSomaListaInteira()
    {
        foreach (var elementos in listaSomaElementosInteirosLista)
        {
            Console.WriteLine($"Números digitados {elementos} ");
        }
    }
}
