using Microsoft.VisualBasic.CompilerServices;
using System;

namespace Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program!");

            Console.WriteLine("Enter the (X,Y) co-ordinates of the first line : ");

            double X1 = Convert.ToDouble(Console.ReadLine());
            double Y1 = Convert.ToDouble(Console.ReadLine());
            double X2 = Convert.ToDouble(Console.ReadLine());
            double Y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the (X,Y) co-ordinates of the second line: ");

            double P1 = Convert.ToDouble(Console.ReadLine());
            double Q1 = Convert.ToDouble(Console.ReadLine());
            double P2 = Convert.ToDouble(Console.ReadLine());
            double Q2 = Convert.ToDouble(Console.ReadLine());

            //Power Calculation for Co-Ordinate Points
            double powerX = Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2);
            double powerP = Math.Pow(P2 - P1, 2) + Math.Pow(Q2 - Q1, 2);

            double Line1 = Math.Sqrt(powerX);
            double Line2 = Math.Sqrt(powerP);

            //Passing double as string
            String line1 = Convert.ToString(Line1);
            String line2 = Convert.ToString(Line2);

            //Checking whether two lines are equal
            Boolean check = line1.Equals(line2);

            if(check == true)
                Console.WriteLine("Both the lines are equal.");
            else
                Console.WriteLine("Lines are not equal.");

        }
    }
}
