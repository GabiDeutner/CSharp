/* Anotações do Curso:
Curso: Lógica de Programação e Algoritmos em C#
https://www.udemy.com/user/nelio-alves
Prof. Dr. Nelio Alves


Entrada de Dados em C#

Checklist • Ler um número inteiro

• Ler um caractere
• Ler um número double
• Ler um nome (única palavra), sexo (caractere F ou M), idade (inteiro) e altura (double) na mesma linha,
armazenando-os em quatro variáveis com os devidos tipos

*/

using System;
using System.Globalization;
namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            /* o Console.ReadLine lê a entrada como string, então precisamos de conversões para os outros tipos */
            int n1 = int.Parse(Console.ReadLine()); /* int.Parse converte string para int*/
            char ch = char.Parse(Console.ReadLine()); /* char.Parse converte de string para char*/
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); string[] vet = Console.ReadLine().Split(' ');
            /* double.Parse converte string para double*/
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);   
            int idade = int.Parse(vet[2]);   
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture); 
            /* CultureInfo.InvariantCulture faz o sistema ler tanto ponto quanto vírgula como 
            separador decimal, independente do idioma configurado no computador*/
            Console.WriteLine("Você digitou:");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}