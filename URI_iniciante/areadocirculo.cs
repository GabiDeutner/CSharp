using System;
using System.Globalization;

namespace uri1002 {
    class Program {
        static void Main(string[] args) {

            double raio, A, π = 3.14159;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            A = π * raio * raio;

            Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}