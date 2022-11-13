/* 
Anotações do Curso:
Curso: Lógica de Programação e Algoritmos em C#
https://www.udemy.com/user/nelio-alves
Prof. Dr. Nelio Alves

Fazer um programa para ler as medidas da largura e comprimento de um terreno
retangular com uma casa decimal, bem como o valor do metro quadrado do
terreno com duas casas decimais. Em seguida, o programa deve mostrar o valor
da área do terreno, bem como o valor do preço do terreno, ambos com duas
casas decimais, conforme exemplo (calcular área e preço).

*/

using System;
using System.Globalization;
namespace curso {
    class Program {
        static void Main(string[] args) {
            double area, preco;
            Console.WriteLine("Digite a largura do terreno: ");
            double larg = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o comprimento do terreno: ");
            double comp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor do metro quadrado do terreno: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = larg * comp;
            preco = valor * area;

            Console.WriteLine("A área do terreno é: " + area.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("O preço do terreno é: " + preco.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}