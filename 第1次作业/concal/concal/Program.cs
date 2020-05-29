using System;

namespace concal
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0; double num1 = 0; double num2 = 0;
            Console.WriteLine("------------------------\n");
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");
            try
            {
                Console.Write("Type a number as num1\n");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Type another number as num2\n ");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Choose an operator from the following list:+-*/");
                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":

                        if (num2 == 0)
                        {
                            Console.WriteLine("Please enter a divisor that is not zero.\n");
                        }
                        result = num1 / num2;
                        break;
                    default:
                        Console.WriteLine("Error operation.\n");
                        break;
                }
                Console.WriteLine("Your result: {0:0.##}\n", result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Input format is error!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Inputted number is overflow!");
            }
        }
    }
}
