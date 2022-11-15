/*
Joaozinho quer calcular e mostrar a quantidade de litros de combustível gastos em uma viagem, 
ao utilizar um automóvel que faz 12 KM/L. Para isso, ele gostaria que você o auxiliasse através 
de um simples programa. Para efetuar o cálculo, deve-se fornecer o tempo gasto na viagem (em horas) 
e a velocidade média durante a mesma (em km/h). Assim, pode-se obter distância percorrida e, em seguida, 
calcular quantos litros seriam necessários. Mostre o valor com 3 casas decimais após o ponto.

Entrada
O arquivo de entrada contém dois inteiros. O primeiro é o tempo gasto na viagem (em horas) e o segundo 
é a velocidade média durante a mesma (em km/h).

Saída
Imprima a quantidade de litros necessária para realizar a viagem, com três dígitos após o ponto decimal


Minha Resolução

distância viajada?
dist = t * vel

qts litros para viajar?
12 km ----------- 1 litro
dist ------------ gastoL

gastoL = dist / 12


*/

using System;
using System.Globalization;

namespace uri1017
{
    class Program
    {
        static void Main(string[] args)
        {

            int vel, t;
            double dist, gastoL;
            
            vel = int.Parse(Console.ReadLine());
            t = int.Parse(Console.ReadLine());

            dist = t * vel;
            gastoL = dist / 12.0;

            Console.WriteLine( gastoL.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}