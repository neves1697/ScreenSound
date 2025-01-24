using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Criar uma variável chamada notaMedia e atribua um valor inteiro a ela. Caso seu valor seja maior ou igual a 5, escreva na tela "Nota suficiente para aprovação".
Criar uma lista de linguagens de programação, com as linguagens C#, Java e JavaScript.
Exibir o valor "C#" no console, utilizando a lista criada no exercício anterior.
Criar um programa que, dado a entrada de dados de um número n inteiro, a partir do teclado, exibir a n-ésima posição de uma lista.
*/

namespace Exercicios;
public class Ex1
{
    public static void Exercicios()
    {
        /*
 Ex https://cursos.alura.com.br/course/csharp-criando-primeira-aplicacao/task/146410
 */

        List<string> linguagens = new List<string>() { "C#", "Javascript", "Java" };

        //linguagens.AddRange("C#","Javascript","Java");

        void MediaNota()
        {
            Console.WriteLine("Validação de média");
            Console.Write("Digite um valor: ");
            int valor = int.Parse(Console.ReadLine()!);

            if (valor <= 5)
            {
                Console.WriteLine($"A nota {valor} é insufienciente");
            }
            else
            {
                Console.WriteLine($"Nota sufienciente {valor} ");
            }
        }

        void ListaLinguagens()
        {
            Console.WriteLine("\nExibe lista de linguagens");
            foreach (var item in linguagens)
            {
                Console.WriteLine(item);
            }
        }

        void ExibeLinguagenDoExercicio()
        {
            Console.WriteLine("\nExibe a linguagem proposta pelo exercício");
            string c = "C#";
            //Console.WriteLine(linguagens[0]);
            foreach (var item in linguagens)
            {
                if (item.Contains(c))
                {
                    Console.WriteLine(item);
                    Console.WriteLine($"O valor buscado está no índice {item.IndexOf(c)} ");
                }
            }
        }

        MediaNota();
        ListaLinguagens();
        ExibeLinguagenDoExercicio();
    }
}
