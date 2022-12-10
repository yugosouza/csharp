using System;
namespace Curso 
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.Write("Digite 3 nomes: (Separados por espaço) ");
            String[] v = Console.ReadLine().Split(' ');
            String a = v[0];
            String b = v[1];
            String c = v[2];
            Console.WriteLine(a + " e " + b + " e " + c);
        
            Console.Write("Bom dia! ");
            String frase = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Qual seu dia de aniversario (Apenas o dia): ");
            String x = Console.ReadLine();
            Console.Write("Qual é o mês do seu aniversario (Apenas o mês): ");
            String y = Console.ReadLine();
            Console.Write("Qual é o ano do seu nascimento: ");
            String z = Console.ReadLine();

            Console.WriteLine("//COMANDO .Split ESTÁ SEPARADO DO ReadLine ↨");
            String xs = Console.ReadLine();         
            String[] O = xs.Split(' ');
            String x1 = O[0];
            String x2 = O[1];
            String x3 = O[2];

        Console.WriteLine(frase+"\n"+x+"\n"+y+"\n"+z+"\n"+x1+"\n"+x2+"\n"+x3+"\n");
            
        }
    }
}