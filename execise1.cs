/* Anotações do Curso:
Curso: Lógica de Programação e Algoritmos em C#
https://www.udemy.com/user/nelio-alves
Prof. Dr. Nelio Alves

Fazer um programa para executar a seguinte interação com o usuário, lendo os valores destacados em vermelho, 
e depois mostrar os dados na tela:

Entre com seu nome completo:
Alex Green
Quantos quartos tem na sua casa?
3
Entre com o preço de um produto:
500.50
Entre seu último nome, idade e altura (mesma linha):
Green 21 1.73
*/

using System;
using System.Globalization;
namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quarto = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double produto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] vet = Console.ReadLine().Split(' ');
            string n1 = vet[0];
            int ida1 = int.Parse(vet[1]);
            double alt1 = double.Parse(vet[2], CultureInfo.InvariantCulture);
            Console.WriteLine(nome);
            Console.WriteLine(quarto);
            Console.WriteLine(produto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(n1);
            Console.WriteLine(ida1);
            Console.WriteLine(alt1.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}