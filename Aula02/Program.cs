using System;
using System.Globalization;
namespace Terceiro{
    class Program{
        static void Main(string[] args) {
    /*VAR*/ int n1;
            Console.Write("Digite um numrero: ");
    /*VAR*/ n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Vocé digitou -> " + n1);
            Console.WriteLine("//Adcionado cod Parse(Ao readline) para conversão da entrada de String para int");

            Console.Write("Digite o sexo F ou M: ");
    /*VAR*/ char ch = char.Parse(Console.ReadLine());
            Console.WriteLine("Você digitou -> " + ch); 

            Console.Write("Digite um numero real: ");
    /*VAR*/ double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Você digitou -> " + n2.ToString("F2", CultureInfo.InvariantCulture));

            String[] vt = Console.ReadLine().Split(' ');
            String nm = vt[0];
    /*VAR*/ char sx = char.Parse(vt[1]);
    /*VAR*/ int idag = int.Parse(vt[2]);
    /*VAR*/ double alt = double.Parse(vt[3], CultureInfo.InvariantCulture);
            Console.WriteLine(nm + " - " + sx + " - " + idag + " - " + alt.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
