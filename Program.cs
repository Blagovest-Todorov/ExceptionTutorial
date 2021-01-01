using System;

namespace ExceptionsTut
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double convertedToDouble = Double.Parse(input);

            if (convertedToDouble >= 5)
            {
                Console.WriteLine($"The entered number is {convertedToDouble}");
            }
            else
            {
                throw new ArgumentException(" Entered is invalid number !");
                // here the system just throws an unhandled exception
            }
        }
    }
}
