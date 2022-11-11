/* 

Anotações do Curso:
Curso: Lógica de Programação e Algoritmos em C#
https://www.udemy.com/user/nelio-alves
Prof. Dr. Nelio Alves

Para escrever na tela um texto qualquer

Sem quebra de linha ao final:
Console.Write("Bom dia!");

Com quebra de linha ao final:
Console.WriteLine("Bom dia!"); 

*/


using System;
using System.Globalization; /* Para usar o CultureInfo.InvariantCulture para trocar a vírgula por ponto */
namespace Curso {
class Program {
static void Main(string[] args) {
double x = 10.35784;
int y = 32;
string z = "Maria";
char w = 'F';
Console.Write("Olá mundo!");
Console.WriteLine("Bom dia!");
Console.WriteLine("Até mais!");
Console.WriteLine();
Console.WriteLine(x);
Console.WriteLine(x.ToString("F2")); /*Para limitar a quantidade de casas decimais*/
Console.WriteLine(x.ToString("F4"));
Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine();
Console.WriteLine("RESULTADO = " + x);
Console.WriteLine("O valor do troco é " + x + " reais");
Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais");
Console.WriteLine();
Console.WriteLine("A paciente " + z + " tem " + y + " anos e seu sexo é: " + w);
Console.ReadLine();
}
}
}