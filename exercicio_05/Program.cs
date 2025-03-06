// Fazer um programa para ler um vetor de N números inteiros. Em seguida, mostrar na tela a média aritmética somente
// dos números pares lidos.

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Entrada do número de elementos do vetor
        Console.Write("Digite o número de elementos do vetor: ");
        int N = int.Parse(Console.ReadLine());

        int[] vetor = new int[N];

        // Leitura dos números inteiros
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Digite o número {i + 1}: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        // Filtra os números pares do vetor
        var numerosPares = vetor.Where(x => x % 2 == 0).ToArray();

        // Calcula a média dos números pares, se houver algum
        if (numerosPares.Length > 0)
        {
            double media = numerosPares.Average();
            Console.WriteLine($"A média dos números pares é: {media}");
        }
        else
        {
            Console.WriteLine("Não há números pares no vetor.");
        }
    }
}
