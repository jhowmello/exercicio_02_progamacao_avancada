// Fazer um programa para ler um conjunto de N nomes de alunos, bem como as notas que eles tiraram no 1º e 2º semestres.
// Cada uma dessas informações deve ser armazenada em um vetor. Depois, imprimir os nomes dos alunos aprovados,
// considerando aprovados aqueles cuja média das notas seja maior ou igual a seis.

using System;

class Program
{
    static void Main()
    {
        // Lendo o número de alunos
        Console.Write("Digite o número de alunos: ");
        int n = int.Parse(Console.ReadLine());

        // Criando os vetores para armazenar os nomes e notas
        string[] nomes = new string[n];
        double[] notas1 = new double[n];
        double[] notas2 = new double[n];

        // Lendo os dados dos alunos
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Digite o nome do aluno {i + 1}: ");
            nomes[i] = Console.ReadLine();

            Console.WriteLine($"Digite a nota do 1º semestre de {nomes[i]}: ");
            notas1[i] = double.Parse(Console.ReadLine());

            Console.WriteLine($"Digite a nota do 2º semestre de {nomes[i]}: ");
            notas2[i] = double.Parse(Console.ReadLine());
        }

        // Imprimindo os alunos aprovados
        Console.WriteLine("\nAlunos Aprovados:");
        for (int i = 0; i < n; i++)
        {
            double media = (notas1[i] + notas2[i]) / 2;
            if (media >= 6)
            {
                Console.WriteLine(nomes[i]);
            }
        }
    }
}
