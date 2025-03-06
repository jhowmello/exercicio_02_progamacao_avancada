// Faça um programa para ler dois vetores A e B, contendo N elementos cada. Em seguida, gere um terceiro vetor C onde
//cada elemento de C é a soma dos elementos correspondentes de A e B. Imprima o vetor C gerado.

using System;

class Program
{
    static void Main()
    {
        // Solicitar o tamanho dos vetores
        Console.Write("Digite o número de elementos nos vetores: ");
        int N = int.Parse(Console.ReadLine());

        // Criar os vetores A, B e C
        int[] A = new int[N];
        int[] B = new int[N];
        int[] C = new int[N];

        // Ler os elementos do vetor A
        Console.WriteLine("Digite os elementos do vetor A:");
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            A[i] = int.Parse(Console.ReadLine());
        }

        // Ler os elementos do vetor B
        Console.WriteLine("Digite os elementos do vetor B:");
        for (int i = 0; i < N; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            B[i] = int.Parse(Console.ReadLine());
        }

        // Calcular a soma dos elementos correspondentes de A e B para preencher o vetor C
        for (int i = 0; i < N; i++)
        {
            C[i] = A[i] + B[i];
        }

        // Imprimir o vetor C
        Console.WriteLine("\nVetor C (Soma dos elementos de A e B):");
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine($"C[{i}] = {C[i]}");
        }
    }
}
