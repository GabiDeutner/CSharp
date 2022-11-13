/* URI 1010

Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Após, calcule e mostre o valor a ser pago.

Entrada
O arquivo de entrada contém duas linhas de dados. Em cada linha haverá 3 valores, respectivamente dois inteiros e um valor com 2 casas decimais.

Saída
A saída deverá ser uma mensagem conforme o exemplo fornecido abaixo, lembrando de deixar um espaço após os dois pontos e um espaço após o "R$". O valor deverá ser apresentado com 2 casas após o ponto.
*/

using System;
using System.Globalization;

namespace uri1010
{
    class Program
    {
        static void Main(string[] args)
        {

            int c1, c2, n1, n2;
            double v1, v2, valor;
            
            string[] valores = Console.ReadLine().Split(' ');
            c1 = int.Parse(valores[0]);
            n1 = int.Parse(valores[1]);
            v1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');
            c2 = int.Parse(valores[0]);
            n2 = int.Parse(valores[1]);
            v2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valor = (n1 * v1) + (n2 * v2);

            Console.WriteLine("VALOR A PAGAR: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}