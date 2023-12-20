using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculator Program
            /*
            
                By Muhammad Ishraq Hasin
                12/20/2023

                Windows Console App
                Visual Studio 2022

            */



            //user selection

            // number 1 selection
            Console.WriteLine("enter first number");          
            string var1 = Console.ReadLine();
            double number_0 = double.Parse(var1);
            Console.WriteLine("you entered: " + number_0);

            // number 2 selection
            Console.WriteLine("\nenter second number");
            string var2 = Console.ReadLine();
            double number_1 = double.Parse(var2);
            Console.WriteLine("you entered: " + number_1);

            //operator selection
            Console.WriteLine("\n What do you intend to do with these numbers?");
            Console.WriteLine("\t + (Addition)");
            Console.WriteLine("\t - (Subtraction)");
            Console.WriteLine("\t - (Subtraction)");
            Console.WriteLine("\t * (Multipacition)");
            Console.WriteLine("\t / (Division)\n");

            string var3 = Console.ReadLine();


            // function
            switch (var3)
            {
                case "+":
                    Console.WriteLine(number_0 + number_1);
                    break;

                case "-":
                    Console.WriteLine(number_0 - number_1);
                    break;

                case "*":
                    Console.WriteLine(number_0 * number_1);
                    break;

                case "/":
                    Console.WriteLine(number_0 / number_1);
                    break;

                default:
                    // default statements
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(@"Error: You typed an invalid operator");
                    Console.ResetColor();
                    break;
            }
        }
    }
}
