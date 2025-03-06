// Fazer um programa para ler um vetor de N números reais. Em seguida, mostrar na tela a média aritmética de todos
// elementos.Depois mostrar todos os elementos do vetor que estejam abaixo da média.

using System;

class Program
{
    static void Main()
    {
        // Ler o tamanho do vetor
        Console.Write("Digite o tamanho do vetor: ");
        int N = int.Parse(Console.ReadLine());

        // Criar o vetor de tamanho N
        double[] vetor = new double[N];

        // Ler os elementos do vetor
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            vetor[i] = double.Parse(Console.ReadLine());
        }

        // Calcular a média aritmética
        double soma = 0;
        for (int i = 0; i < N; i++)
        {
            soma += vetor[i];
        }
        double media = soma / N;

        // Exibir a média
        Console.WriteLine($"Média aritmética: {media}");

        // Exibir os elementos abaixo da média
        Console.WriteLine("Elementos abaixo da média:");
        for (int i = 0; i < N; i++)
        {
            if (vetor[i] < media)
            {
                Console.WriteLine(vetor[i]);
            }
        }
    }
}
