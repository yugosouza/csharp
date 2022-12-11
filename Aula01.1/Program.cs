using System;
namespace Curso 
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.Write("Digite 3 nomes: (Separados por espaço) ");
    /*VAR*/ String[] v = Console.ReadLine().Split(' ');
    /*VAR*/ String a = v[0];
    /*VAR*/ String b = v[1];
    /*VAR*/ String c = v[2];
            Console.WriteLine(a + " e " + b + " e " + c);
        
            Console.Write("Bom dia! ");
    /*VAR*/ String frase = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Qual seu dia de aniversario (Apenas o dia): ");
    /*VAR*/ String x = Console.ReadLine();
            Console.Write("Qual é o mês do seu aniversario (Apenas o mês): ");
    /*VAR*/ String y = Console.ReadLine();
            Console.Write("Qual é o ano do seu nascimento: ");
    /*VAR*/ String z = Console.ReadLine();

            Console.WriteLine("//COMANDO .Split ESTÁ SEPARADO DO ReadLine ↨");
    /*VAR*/ String xs = Console.ReadLine();         
    /*VAR*/ String[] O = xs.Split(' ');
    /*VAR*/ String x1 = O[0];
    /*VAR*/ String x2 = O[1];
    /*VAR*/ String x3 = O[2];

        Console.WriteLine(frase+"\n"+x+"\n"+y+"\n"+z+"\n"+x1+"\n"+x2+"\n"+x3+"\n");
            
        }
    }
}
