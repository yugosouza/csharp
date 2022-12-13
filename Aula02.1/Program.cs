namespace Funções_matematicas_em_csharp {
    class Program {
        static void Main(string[] args) {
            double x = 3.0;
            double y = 4.0;
            double z = -5.0;
            double a, b, c, x1, x2;

            a = Math.Sqrt(x);
            b = Math.Sqrt(y);
            c = Math.Sqrt(25.0);
            Console.WriteLine("A raiz qdr de " + x + "=" + a );
            Console.WriteLine("B raiz qdr de " + y + "=" + b );
            Console.WriteLine("C raiz qdr de 25 = " + c);

            a = Math.Pow(x, y);
            b = Math.Pow(x, 2.0);
            c = Math.Pow(5.0, 2.0);
            Console.WriteLine(x + " Elevado a " + y + " = "+ a);
            Console.WriteLine(x + " Elevado ao quadrado = " + b);
            Console.WriteLine("5 Elevado ao quadrado = " + c);

            a = Math.Abs(y);
            b = Math.Abs(z);
            Console.WriteLine("Valor absoluto de " + y + " = " + a);
            Console.WriteLine("Valor absoluto de " + z + " = " + b);
            

            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            double delta = Math.Pow(b, 2.0) - 4*a*c;
            if (delta < 0){
                delta *= -1;

                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                    Console.WriteLine("utilizando-se da propriedade dos numeros complexo obtemos que:"+ delta);
                    Console.WriteLine("x1 vale " + x1+"i");
                    Console.WriteLine("a2 vale " + x2+"i"); 
            }
            else {
            x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
            Console.WriteLine("Valor de delta é: " + delta + " = X1 = " + x1 + " X2 = " + x2);
            }
        }
    }
}