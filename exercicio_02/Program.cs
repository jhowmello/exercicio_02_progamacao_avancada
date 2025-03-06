// Faça um programa que leia N números inteiros e armazene-os em um vetor. Em seguida, mostre na tela:
// -todos os números pares
// - a quantidade de números pares 


using System;

class Program
{
    static void Main()
    {
        // Solicitar o número de elementos
        Console.Write("Digite a quantidade de números: ");
        int N = int.Parse(Console.ReadLine());

        // Criar o vetor para armazenar os números
        int[] numeros = new int[N];

        // Ler os números e armazená-los no vetor
        Console.WriteLine("Digite os números:");
        for (int i = 0; i < N; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());
        }

        // Contar e exibir os números pares
        int quantidadePares = 0;
        Console.WriteLine("Números pares:");
        foreach (int numero in numeros)
        {
            if (numero % 2 == 0)
            {
                Console.WriteLine(numero);
                quantidadePares++;
            }
        }

        // Exibir a quantidade de números pares
        Console.WriteLine($"Quantidade de números pares: {quantidadePares}");
    }
}
