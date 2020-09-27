using System;

namespace Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program!");

            Console.WriteLine("Enter the (X,Y) co-ordinates of the line : ");

            double X1 = Convert.ToDouble(Console.ReadLine());
            double Y1 = Convert.ToDouble(Console.ReadLine());
            double X2 = Convert.ToDouble(Console.ReadLine());
            double Y2 = Convert.ToDouble(Console.ReadLine());

            //Power Calculation for Co-Ordinate Points
            double powerP = Math.Pow(X2 - X1, 2);
            double powerQ = Math.Pow(Y2 - Y1, 2);

            //Length of line 
            Console.WriteLine(Math.Sqrt(powerP + powerQ));
        }
    }
}
