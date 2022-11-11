/* Anotações do Curso:
Curso: Lógica de Programação e Algoritmos em C#
https://www.udemy.com/user/nelio-alves
Prof. Dr. Nelio Alves


Entrada de Dados em C#

Comando
Console.ReadLine(); • Lê da entrada padrão até a quebra de linha. • Retorna os dados lidos na forma de string.

Checklist 
• Ler um texto até a quebra de linha e armazenar em uma variável 
• Ler três palavras, uma em cada linha, armazenando cada uma em uma variável 
• Ler três palavras na mesma linha, separadas por espaço, armazenando cada uma em uma variável

*/

using System;
using System.Globalization;
namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            string[] v = Console.ReadLine().Split(' ');
            /*o Split(' ') faz com  que o sistema reconheça o espaço entre as palavras, ou seja,
            toda vez que houver um espaço ele guarda como uma palavra diferente no vetor*/
            string a = v[0];
            string b = v[1];
            string c = v[2];
            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}


/* PRIMEIRO EXEMPLO: */

using System;
using System.Globalization;
namespace curso {
 class Program {
 static void Main(string[] args) {
 string x;
 int y;
 double z;
 char w;
 x = Console.ReadLine();
 y = int.Parse(Console.ReadLine());
 z = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
 w = char.Parse(Console.ReadLine());
 Console.WriteLine(x);
 Console.WriteLine(y);
 Console.WriteLine(z.ToString("F2", CultureInfo.InvariantCulture));
 Console.WriteLine(w);
 Console.ReadLine();
 }
 }
}

/* SEGUNDO EXEMPLO: */

using System;
using System.Globalization;
namespace curso {
 class Program {
 static void Main(string[] args) {
 string x;
 int y;
 double z;
 string[] vet = Console.ReadLine().Split(' ');
 x = vet[0];
 y = int.Parse(vet[1]);
 z = double.Parse(vet[2], CultureInfo.InvariantCulture);
 Console.WriteLine(x);
 Console.WriteLine(y);
 Console.WriteLine(z.ToString("F2", CultureInfo.InvariantCulture));
 Console.ReadLine();
 }
 }
}