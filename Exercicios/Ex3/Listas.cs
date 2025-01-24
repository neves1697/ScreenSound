using System;
using System.Collections.Generic;

namespace Exercicios.Ex2
{
    public class Listas
    {
        List<double> listaNotas = new List<double>();

        public void ListaMaterias()
        {
            Console.WriteLine("Digite quantas matérias deseja cadastrar notas:");
            int materias = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < materias; i++)
            {
                double nota;
                do
                {
                    Console.WriteLine($"Digite a nota da matéria {i + 1} (máximo 10):");
                    nota = double.Parse(Console.ReadLine()!);

                    if (nota > 10)
                    {
                        Console.WriteLine("Nota maior que 10. Por favor, insira uma nota válida.");
                    }
                }
                while (nota > 10);

                listaNotas.Add(nota);
            }

            Console.WriteLine("\nNotas cadastradas:");
            foreach (var nota in listaNotas)
            {
                Console.WriteLine(nota);
            }

            double media = MediaNotas(listaNotas);
            Console.WriteLine($"\nA média das notas é: {media:F2}");
        }

        public double MediaNotas(List<double> notasCadastradas)
        {
            double soma = 0;

            foreach (var nota in notasCadastradas)
            {
                soma += nota;
            }

            return soma / notasCadastradas.Count;
        }
    }
}
