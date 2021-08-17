using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCupsOfCoffee = 6;

            string fullName = "Kelly Dobson";

            DateTime today = System.DateTime.Now;

            System.Console.WriteLine(numberOfCupsOfCoffee + " " + fullName + " " + today);

            Console.Write("Enter your username: ");

            string userName = Console.ReadLine();

            if (userName == "Alice")
            {
                Console.WriteLine("The world keeps shifting so quickly under your feet!");
            }

            Console.WriteLine("Hello, " + userName + "!");
            Console.Write("Enter a number: ");
            string firstNumberAsString = Console.ReadLine();
            Console.Write("Enter Another Number: ");
            string secondNumberAsString = Console.ReadLine();

            double firstOperand = double.Parse(firstNumberAsString);
            double secondOperand = double.Parse(secondNumberAsString);

            double sum = firstOperand + secondOperand;
            double difference = firstOperand - secondOperand;
            double product = firstOperand * secondOperand;
            double quotient = firstOperand / secondOperand;
            double remainder = firstOperand % secondOperand;

            Console.WriteLine("sum: " + sum);
            Console.WriteLine("difference: " + difference);
            Console.WriteLine("product: " + product);
            Console.WriteLine("quotient: " + quotient);
            Console.WriteLine("remainder: " + remainder);

        }
    }
}
