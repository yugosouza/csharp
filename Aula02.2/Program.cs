using System;
using System.Globalization;

namespace ComoUtilizarDebug {
    class Program {
        static void Main(string[] args) {
            Console.Write("Lado 1 do terreno em metros: ");
            double la = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado 2 do terreno em metros: ");
            double comp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Preço do metro do terreno: R$");
            double prc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double are = la * comp;
            prc = comp * prc;
            Console.WriteLine("A aréa total do terreno equivale a: " + are.ToString("F2") + "metros e o preçodo mesmo equivale a: R$" + prc.ToString("F2"), CultureInfo.InvariantCulture);

        }
    }
}
