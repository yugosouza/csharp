// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;

namespace exercised {
    class Program {
        static void Main(String[] args) {

            Console.Write("Nome completo: ");
    /*VAR*/ String[] nom = Console.ReadLine().Split(' ');
    /*VAR*/ String n1 = nom[0];
    /*VAR*/ String n2 = nom[1];
            Console.WriteLine(n1 + " <> " + n2);

            Console.Write("Quantos quartos em casa: ");
    /*VAR*/ int qrt = int.Parse(Console.ReadLine());
            Console.WriteLine("Numero de quartos: "+qrt);

            Console.Write("Qual é o preço do produto: R$");
    /*VAR*/ double pric = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Preço: " + pric);

            Console.Write("Qual é seu ultimo nome: ");
    /*VAR*/ String s2 = Console.ReadLine();
            Console.Write("Idade: ");
    /*VAR*/ int id = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Sua altura: ");
    /*VAR*/ double alt = double.Parse(Console.ReadLine());
            Console.WriteLine("Seu ultimo nome é ->" + s2 + "| Sua idade é ->" + id + "| Sua altura é ->" +alt);
        }
    }
}
