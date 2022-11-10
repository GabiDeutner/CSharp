/* Exemplo 1 */

using System;
using System.Globalization;
namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            x = 5;
            y = 2 * x;
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}



/* Exemplo 2 */

using System;
using System.Globalization;
namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            double y;
            x = 5;
            y = 2 * x;
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}


/* Exemplo 3 */

using System;
using System.Globalization;
namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, B, h, area; /* para variável double sempre usar ponto e zero depois do número */
            b = 6.0;
            B = 8.0;
            h = 5.0;
            area = (b + B) / 2.0 * h;
            Console.WriteLine(area);
        }
    }
}


/* Exemplo 4 */

using System;
using System.Globalization;
namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            float b, B, h, area; /* para variável float sempre usar f depois do número */
            b = 6f;
            B = 8f;
            h = 5f;
            area = (b + B) / 2f * h;
            Console.WriteLine(area);
        }
    }
}

/*
Boa prática:
Sempre indique o tipo do número, se a
expressão for de ponto flutuante (não
inteira).
Para double use:
.0
Para float use:
f
 */

 /* Exemplo 5 */

using System;
using System.Globalization;
namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            double resultado;
            a = 5;
            b = 2;
            resultado = a / b;
            Console.WriteLine(resultado); /*o resultado vai dar 2 porque o sistema entende como número inteiro*/
        }
    }
}

/*
Casting

É a conversão explícita de um tipo para outro.
É necessário quando o compilador não é capaz de “adivinhar” que o
resultado de uma expressão deve ser de outro tipo.

*/

/* Exemplo 6 */
/*Fazendo o casting de inteiro para double */

using System;
using System.Globalization;
namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            double resultado;
            a = 5;
            b = 2;
            resultado = (double)a / b; /*colocar o double na frente faz a conversão do resultado para esse tipo*/
            Console.WriteLine(resultado);
        }
    }
}

/* Exemplo 7 */
/*Fazendo o casting de double para inteiro*/

using System;
using System.Globalization;
namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            int b;
            a = 5.0;
            b = (int) a;
            Console.WriteLine(b);
        }
    }
}