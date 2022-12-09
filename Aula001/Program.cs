using System;
using System.Globalization;
//using System.globalization usado para importar biblioteca
namespace Primeiro
{
    class Program
    {
        public static void Main(string[] args) { 
            //variaveis
            double x01 = 10.35784;
            String nom = "Maria";
            byte age = 32;
            Char gen = 'F';

            Console.WriteLine("//codigo para demonstrar abreviação de numeros com ToString (F.)");
            Console.WriteLine(x01.ToString("F2"));
            Console.WriteLine(x01.ToString("F4"));
            Console.WriteLine(x01.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Result = " + x01);
            Console.WriteLine("Troco: "+ x01 +" Reais (R$)");
            Console.WriteLine("O valor do troco é "+ x01.ToString("F2") + " Reais\n");
            Console.WriteLine("//A interação de variavel com texto separado por '' e + VARIAVEL +");
            Console.WriteLine("A paciente "+nom+" Possui "+age+" anos e seu sexo é "+gen+"\n");

            Console.WriteLine("//Exemplo 01 e 02 mudando var y de int para double/float");
            int x;
            float y;
            x = 5;
            y = 2 * x;
            Console.WriteLine(x + " e " + y + "\n");
            
            Console.WriteLine("//Exemplo 03 fizemos um calculo matematico dentro do codigo WriteLine");
            float b1, b2, h;
            b1 = 6;
            b2 = 8;
            h = 5;
            Console.WriteLine("A aréa é igual a: " + (b1 + b2) / 2 * h + "\n");
            
            Console.WriteLine("//Exemplo 04 adiconamos a expressão (double) dentro do WriteLine para dar o valor real");
            int a, b;
            a = 5;
            b = 2;
            Console.WriteLine((double)a / b + "\n");

            Console.WriteLine("//Exemplo 05 casting dentro do valor da variavel");
            double a_ex05;
            int b_ex05;
            a_ex05 = 5;
            b_ex05 = (int) a_ex05;
            Console.WriteLine(a_ex05 + "<- a e b ->" + b_ex05 + "\n"); 
        }
    }
}

//https://pt.stackoverflow.com/q/146970/101