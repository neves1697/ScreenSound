/*
Crie uma lista de inteiros utilizando o List<int> e utilize o for e o foreach para iterar sobre essa lista e exibir apenas os números pares.

No for, comece o índice em 0 e incremente a cada iteração. Defina a condição de continuação do loop como i < numeros.Count, ou seja, 
o loop continuará enquanto o valor de i for menor do que o número de elementos na lista. Acesse o valor de cada elemento utilizando a 
sintaxe numeros[i].

Já no foreach, ao invés de utilizar um loop for com um contador i e acessar os elementos da lista através do índice i, 
é utilizado o foreach para percorrer a lista e acessar diretamente cada elemento com a variável número. Em seguida, é verificado se o número 
é par utilizando o operador de módulo (%) e,
caso seja, o número é impresso no console.


#### - Passos - ####

- Criar lista de inteiros chamada numeros
- Criar um for começando no índice 0 e incrementar a cada iteração.
- Definir a condição de continuação do for do loop como i < numeros.Count.
- Acessar o valor de cada um dos elementos com numeros[i].
- Criar um foreach para percorrer a lista de números.
- Verificar se o número é par com o (mod % )
- Se for número par, imprimir no console.
*/

namespace Exercicios.Ex06;
public class ListaBuscaNumerosPares
{
    List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
    public void ValidaNumerosParesComForSimples()
    {
        Console.WriteLine("**** Lista de números pares com FOR simples**** \n");
        for (int i = 0; i < numeros.Count; i++)
        {
            if (numeros[i] % 2 == 0)
            {
                Console.WriteLine($"Números Pares {numeros[i]} ");
            }
        }
    }

    public void ValidaNumerosParesComForEach()
    {
        Console.WriteLine("\n**** Lista de números pares com ForEach**** \n");
        foreach (var numerosLista in numeros)
        {
            if (numerosLista % 2 == 0)
            {
                Console.WriteLine($"Números pares {numerosLista} ");
            }
        }
    }

    // Plus - Desafio pessoal que fiz para mim.
    // teste

    public void ValidaNumerosImparesComForSimples()
    {
        Console.WriteLine("\n**** Lista de números ímpares**** \n");
        for (int i = 0; i < numeros.Count; i++)
        {
            if (numeros[i] % 2 == 1)
            {
                Console.WriteLine($"Números ímpares: {numeros[i]} ");
            }
        }
    }

    public void QuantidadeNumerosParesIntervalo()
    {
        Console.WriteLine("\n**** Quantidade de números pares no intervalo da lista**** \n");
        int contadorNumeroPar = 0;
        for (int i = 0; i < numeros.Count; i++)
        {
            if (numeros[i] % 2 == 0)
            {
                ++contadorNumeroPar;                
            }            
        }
        Console.WriteLine($"Existem {contadorNumeroPar} números pares entre os {numeros.Count} números da lista ");
    }

    public void QuantidadeNumerosImparesIntervalo()
    {
        Console.WriteLine("\n**** Quantidade de números ímpares no intervalo da lista**** \n");
        int contadorNumeroImpar = 0;
        for (int i = 0; i < numeros.Count; i++)
        {
            if (numeros[i] % 2 == 1)
            {
                ++contadorNumeroImpar;
            }
        }
        Console.WriteLine($"Existem {contadorNumeroImpar} números pares entre os {numeros.Count} números da lista ");
    }
}
