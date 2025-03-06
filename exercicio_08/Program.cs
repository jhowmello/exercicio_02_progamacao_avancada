/* Tem-se um conjunto de dados contendo a altura e o sexo (M, F) de N pessoas. Fazer um programa que calcule e escreva:
 a maior e a menor altura do grupo
 a média de altura das mulheres
 o número de homens
*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<double> alturas = new List<double>();
        List<char> sexos = new List<char>();

        int n;
        Console.Write("Digite o número de pessoas: ");
        n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Digite a altura da {i + 1}ª pessoa: ");
            alturas.Add(double.Parse(Console.ReadLine()));

            Console.Write($"Digite o sexo da {i + 1}ª pessoa (M/F): ");
            sexos.Add(char.ToUpper(Console.ReadLine()[0]));
        }

        // Calculando a maior e a menor altura
        double maiorAltura = double.MinValue;
        double menorAltura = double.MaxValue;

        foreach (var altura in alturas)
        {
            if (altura > maiorAltura)
                maiorAltura = altura;

            if (altura < menorAltura)
                menorAltura = altura;
        }

        // Calculando a média das alturas das mulheres
        double somaAlturasMulheres = 0;
        int numeroMulheres = 0;

        for (int i = 0; i < n; i++)
        {
            if (sexos[i] == 'F')
            {
                somaAlturasMulheres += alturas[i];
                numeroMulheres++;
            }
        }

        double mediaAlturaMulheres = (numeroMulheres > 0) ? somaAlturasMulheres / numeroMulheres : 0;

        // Contando o número de homens
        int numeroHomens = 0;

        foreach (var sexo in sexos)
        {
            if (sexo == 'M')
                numeroHomens++;
        }

        // Exibindo os resultados
        Console.WriteLine($"\nMaior altura: {maiorAltura}");
        Console.WriteLine($"Menor altura: {menorAltura}");
        Console.WriteLine($"Média das alturas das mulheres: {mediaAlturaMulheres}");
        Console.WriteLine($"Número de homens: {numeroHomens}");
    }
}
