using System;
namespace basics
{
    class Pro
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter side A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            System.Console.Write("Enter side B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt((a*a)+(b*b));
            Console.WriteLine("The hypotenuse is: " + c);
            
        }
    }
}