// Fazer um programa para ler um conjunto de nomes de pessoas e suas respectivas idades. Depois, mostrar na tela o nome
// da pessoa mais velha.

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<(string nome, int idade)> pessoas = new List<(string, int)>();

        // Ler a quantidade de pessoas
        Console.Write("Quantas pessoas você deseja cadastrar? ");
        int quantidade = int.Parse(Console.ReadLine());

        // Ler os dados das pessoas
        for (int i = 0; i < quantidade; i++)
        {
            Console.Write("Digite o nome da pessoa: ");
            string nome = Console.ReadLine();
            Console.Write("Digite a idade de " + nome + ": ");
            int idade = int.Parse(Console.ReadLine());

            // Adicionar a pessoa à lista
            pessoas.Add((nome, idade));
        }

        // Encontrar a pessoa mais velha
        string pessoaMaisVelha = "";
        int idadeMaisVelha = -1;

        foreach (var pessoa in pessoas)
        {
            if (pessoa.idade > idadeMaisVelha)
            {
                idadeMaisVelha = pessoa.idade;
                pessoaMaisVelha = pessoa.nome;
            }
        }

        // Exibir o nome da pessoa mais velha
        Console.WriteLine("A pessoa mais velha é: " + pessoaMaisVelha);
    }
}
