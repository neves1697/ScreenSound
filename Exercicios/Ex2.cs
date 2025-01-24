using System;

namespace Exercicios
{
    public class Exercicio2
    {
        // Gera um número aleatório entre 1 e 100
        public static int GerarNumeroRandomico()
        {
            Random random = new Random();
            return random.Next(1, 101);
        }

        // Exibe mensagem de boas-vindas
        public static void ExibirBoasVindas()
        {
            Console.WriteLine("Bem-vindo ao jogo de adivinhar o número!\n");
            Console.WriteLine("O programa escolheu um número entre 1 e 100. Tente adivinhar!\n");
        }

        // Obtém o número digitado pelo usuário
        public static int ObterNumeroDigitado()
        {
            Console.Write("Digite um número: ");
            return int.Parse(Console.ReadLine()!);
        }

        // Verifica se o número digitado está correto, maior ou menor
        public static void VerificarNumero(int numeroGerado)
        {
            int tentativa;
            do
            {
                tentativa = ObterNumeroDigitado();

                if (tentativa == numeroGerado)
                {
                    Console.WriteLine($"Parabéns! Você acertou o número: {numeroGerado}");
                    break;
                }
                else if (tentativa < numeroGerado)
                {
                    Console.WriteLine("O número é maior. Tente novamente!");
                }
                else
                {
                    Console.WriteLine("O número é menor. Tente novamente!");
                }

            } while (true);

            Console.WriteLine("Fim de jogo!");
        }

        // Método principal que chama as demais funções
        public static void Main(string[] args)
        {
            ExibirBoasVindas();
            int numeroGerado = GerarNumeroRandomico();
            VerificarNumero(numeroGerado);
        }
    }
}
