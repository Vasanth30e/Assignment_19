using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_19_Part2
{
    delegate T Operation<T>(T num1, T num2);
    internal class Program
    {
        static T Add<T>(T num1, T num2)
        {
            dynamic a = num1;
            dynamic b = num2;
            return a + b;
        }

        static T Subtract<T>(T num1, T num2)
        {
            dynamic a = num1;
            dynamic b = num2;
            return a - b;
        }

        static T Multiply<T>(T num1, T num2)
        {
            dynamic a = num1;
            dynamic b = num2;
            return a * b;
        }

        static T Divide<T> (T num1, T num2)
        {
            dynamic a = num1;
            dynamic b = num2;
            return a / b;

        }

        static void Main(string[] args)
        {
            Operation<int> addOperation = new Operation<int>(Add);
            Operation<int> subOperation = Subtract;
            Operation<int> multiplyOperation = Multiply;
            Operation<double> divideOperation = Divide;

            while (true)
            {
                Console.WriteLine("Choose an Arithmetic Operation\n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division");
                int operation = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter first number");
                string number1 = Console.ReadLine();
                int value1;
                if(!int.TryParse(number1, out value1))
                {
                    Console.WriteLine("Invalid Input");
                    Console.ReadKey();
                    return;
                }

                Console.WriteLine("Enter second number");               
                string number2 = Console.ReadLine();
                int value2;
                if (!int.TryParse(number2, out value2))
                {
                    Console.WriteLine("Invalid Input");
                    Console.ReadKey();
                    return;
                }

                switch (operation)
                {
                    case 1:

                        Console.WriteLine($"Addition of {number1} and {number2} is {addOperation(value1, value2)}");
                        break;
                    case 2:
                        Console.WriteLine($"Subtraction of {number1} and {number2} is {subOperation(value1, value2)}");
                        break;
                    case 3:
                        Console.WriteLine($"Multiplication of {number1} and {number2} is {multiplyOperation(value1, value2)}");
                        break;
                    case 4:
                        Console.WriteLine($"Division of {number1} and {number2} is {divideOperation(value1, value2)}");
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
