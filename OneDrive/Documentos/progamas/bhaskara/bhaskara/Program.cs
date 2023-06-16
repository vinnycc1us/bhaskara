using System;

class Baskharalho
{
    static double Delta(double a, double b, double c)
    {
        return b * b - (4 * a * c);
    }
    static double Xlinha(double delta, double b, double a)
    {
        return ((-1 * b) + Math.Sqrt(delta)) / (2 * a);
    }
    static double X2linha(double delta, double b, double a)
    {
        return ((-1 * b) - Math.Sqrt(delta)) / (2 * a);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("digite o valor de a:");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("digite o valor de b:");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("digite o valor de c:");
        double c = Convert.ToDouble(Console.ReadLine());
        double delta = Delta(a, b, c);

        if(delta < 0)
        {
            Console.WriteLine("não é possivel calcular");
        }
        else if (delta == 0)
        {
            Console.WriteLine("X' = " + Xlinha(delta, b, a));
        }
        else
        {
            Console.WriteLine("X' = " + Xlinha(delta, b, a)); 
            Console.WriteLine("X'' = " + X2linha(delta, b, a));
        }
            
        Console.ReadKey();
    }
}