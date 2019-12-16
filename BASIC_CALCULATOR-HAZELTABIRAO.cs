using System;

namespace Hazel_BasicCalculator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            char redo;
           
            do
            {
                Console.WriteLine("\n\t\t\t\t\t\t{Basic Calculator}");
                Console.WriteLine("\t\t\t\t\txxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\n");
                Console.WriteLine("Operation:\n");

                Console.WriteLine("1.Addition");
                Console.WriteLine("2.Substraction");
                Console.WriteLine("3.Multiplication");
                Console.WriteLine("4.Division\n");

                Console.Write("Enter Choice(1-4):\n");
                float ch = Int32.Parse(Console.ReadLine());
                float a, b, c;
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("You have chosen addition.\n");
                        Console.Write("\nEnter 1st Num:");
                        a = Convert.ToSingle(Console.ReadLine());
                        Console.Write("\nEnter 2nd Num:");
                        b = Convert.ToSingle(Console.ReadLine());
                        c = a + b;
                        Console.WriteLine("\nSum = {0}\n", c);
                        break;
                    case 2:
                        Console.WriteLine("You have chosen subtraction.\n");
                        Console.Write("\nEnter 1st Num:");
                        a = Convert.ToSingle(Console.ReadLine());
                        Console.Write("\nEnter 2nd Num:");
                        b = Convert.ToSingle(Console.ReadLine());
                        c = a - b;
                        Console.WriteLine("\nDifference = {0}", c);
                        break;
                    case 3:
                        Console.WriteLine("You have chosen multiplication.\n");
                        Console.Write("\nEnter 1st Num:");
                        a = Convert.ToSingle(Console.ReadLine());
                        Console.Write("\nEnter 2nd Num:");
                        b = Convert.ToSingle(Console.ReadLine());
                        c = a * b;
                        Console.WriteLine("\nProduct = {0}", c);
                        break;
                    case 4:
                        Console.WriteLine("You have chosen division.\n");
                        Console.Write("\nEnter 1st Num:");
                        a = Convert.ToSingle(Console.ReadLine());
                        Console.Write("\nEnter 2nd Num:");
                        b = Convert.ToSingle(Console.ReadLine());
                        c = a / b;
                        Console.WriteLine("\nQuotient = {0}", c);
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
                
                Console.Write("Type 'c' or 'C' to continue: \n");
                redo = char.Parse(Console.ReadLine());

            } while (redo == 'C' || redo == 'c');

            return;

        }
    }
}