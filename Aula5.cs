/* Anotações do Curso:
Curso: Lógica de Programação e Algoritmos em C#
https://www.udemy.com/user/nelio-alves
Prof. Dr. Nelio Alves

A = Math.Sqrt(x); Variável A recebe a raiz quadrada de x
A = Math.Pow(x, y); Variável A recebe o resultado de x elevado a y
A = Math.Abs(x); Variável A recebe o valor absoluto de x*/

using System;
using System.Globalization;
namespace curso {
    class Program {
        static void Main(string[] args) {
            double x = 3.0;
            double y = 4.0;
            double z = -5.0;
            double A, B, C;
            A = Math.Sqrt(x);
            B = Math.Sqrt(y);
            C = Math.Sqrt(25.0);
            Console.WriteLine("Raiz quadrada de " + x + " = " + A);
            Console.WriteLine("Raiz quadrada de " + y + " = " + B);
            Console.WriteLine("Raiz quadrada de 25 = " + C);
            A = Math.Pow(x, y);
            B = Math.Pow(x, 2.0);
            C = Math.Pow(5.0, 2.0);
            Console.WriteLine(x + " elevado a " + y + " = " + A);
            Console.WriteLine(x + " elevado ao quadrado = " + B);
            Console.WriteLine("5 elevado ao quadrado = " + C);
            A = Math.Abs(y);
            B = Math.Abs(z);
            Console.WriteLine("Valor absoluto de " + y + " = " + A);
            Console.WriteLine("Valor absoluto de " + z + " = " + B);
            Console.ReadLine();
        }
    }
}