using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_19
{
    public delegate int ArithmeticOperation(int num1, int num2);
    internal class Program
    {
       
        public static int Addition(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        static void Main(string[] args)
        {
            ArithmeticOperation add = new ArithmeticOperation(Addition);
            ArithmeticOperation sub = new ArithmeticOperation(Subtract);
            ArithmeticOperation multi = new ArithmeticOperation(Multiply);
            ArithmeticOperation divide = new ArithmeticOperation(Divide);
            
            while (true)
            {
                Console.WriteLine("Choose an Arithmetic Operation\n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division");
                int operation = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter first number");
                int number1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter second number");
                int number2 = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        Console.WriteLine($"Addition of {number1} and {number2} is {add(number1, number2)}");
                        break;
                    case 2:
                        Console.WriteLine($"Subtraction of {number1} and {number2} is {sub(number1, number2)}");
                        break;
                    case 3:
                        Console.WriteLine($"Multiplication of {number1} and {number2} is {multi(number1, number2)}");
                        break;
                    case 4:
                        Console.WriteLine($"Division of {number1} and {number2} is {divide(number1, number2)}");
                        break;
                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }
                Console.ReadKey();
            }
 
        }
    }
}
