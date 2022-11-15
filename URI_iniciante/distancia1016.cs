/* URI 1016
Dois carros (X e Y) partem em uma mesma direção. 
O carro X sai com velocidade constante de 60 Km/h e o carro Y sai com velocidade constante de 90 Km/h.

Em uma hora (60 minutos) o carro Y consegue se distanciar 30 quilômetros do carro X, ou seja, 
consegue se afastar um quilômetro a cada 2 minutos.

Leia a distância (em Km) e calcule quanto tempo leva (em minutos) para o carro Y 
tomar essa distância do outro carro.

Entrada
O arquivo de entrada contém um número inteiro.

Saída
Imprima o tempo necessário seguido da mensagem "minutos".

Minha resolução:
carro x 
60 km --------- 1 hora

carro y
90 km --------- 1 hora
se afasta do carro x 0,5 km/ minuto

0,5 km ---------- 1 minuto
dist   ---------- t

t = dist / 0,5 
logo,
t = dist * 2

*/

using System;
using System.Globalization;

namespace uri1014
{
    class Program
    {
        static void Main(string[] args)
        {

            int dist, t;
            
            dist = int.Parse(Console.ReadLine());

            t = dist * 2;

            Console.WriteLine( t + " minutos");

        }
    }
}