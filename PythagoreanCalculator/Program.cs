using System;

namespace PythagoreanCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserChoice;

            Console.WriteLine("Pythagorean Calculator");

            Console.WriteLine("      /|");
            Console.WriteLine("     / |");
            Console.WriteLine("    /  |");
            Console.WriteLine(" c /   | a");
            Console.WriteLine("  /    |");
            Console.WriteLine(" /    _|");
            Console.WriteLine("/____|_|");
            Console.WriteLine("    b   ");

            do
            {
                Console.WriteLine("Solve for [leg] or [hypotenuse]? ('q' to quit)");
                UserChoice = Console.ReadLine();

                if (UserChoice.Equals("leg"))
                {
                    SolveForLeg();
                }
                else if (UserChoice.Equals("hypotenuse"))
                {
                    SolveForHypotenuse();
                }
            } while (!UserChoice.Equals("q"));

            Console.Clear();

            Console.Read();
        }

        static void SolveForLeg()
        {
            double a;
            double c;
            double result;

            do
            {
                Console.Write("a: ");
                a = Convert.ToDouble(Console.ReadLine());

                if(a <= 0)
                {
                    Console.WriteLine("-Invalid Input-");
                    Console.WriteLine("leg cannot be less than or equal to zero.");
                }
            } while (a <= 0);

            do
            {
                Console.Write("c: ");
                c = Convert.ToDouble(Console.ReadLine());

                if (c <= a)
                {
                    Console.WriteLine("-Invalid Input-");
                    Console.WriteLine("leg length cannot be greater than hypotenuse.");
                } else if(c <= 0)
                {
                    Console.WriteLine("-Invalid Input-");
                    Console.WriteLine("value cannot be equal to or below zero.");
                }
            } while (c <= a || c <= 0);

            result = Math.Sqrt(Math.Pow(c, 2) - Math.Pow(a, 2));

            Console.WriteLine("b = " + Math.Round(result, 2));
        }

        static void SolveForHypotenuse()
        {
            double a;
            double b;
            double result;

            do
            {
                Console.Write("a: ");
                a = Convert.ToDouble(Console.ReadLine());

                if(a <=0)
                {
                    Console.WriteLine("-Invalid Input-");
                    Console.WriteLine("leg cannot be less than or equal to zero.");
                }
            } while (a <= 0);

            do
            {
                Console.Write("b: ");
                b = Convert.ToDouble(Console.ReadLine());

                if (b <= 0)
                {
                    Console.WriteLine("-Invalid Input-");
                    Console.WriteLine("leg cannot be less than or equal to zero.");
                }
            } while (b <= 0);

            result = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            Console.WriteLine("c = " + Math.Round(result, 2));
        }

    }
}
