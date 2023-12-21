using System;

namespace Start
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool check = false;

                while (check == false)
                {
                    int number1 = 0, number2 = 0;

                    Console.WriteLine("WELCOME TO CALCULATOR");

                    Console.Write("PLEASE ENTER ONE NUMBER :");
                    number1 = int.Parse(Console.ReadLine());

                    Console.Write("PLEASE ENTER TOW NUMBER :");
                    number2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("PLEASE ENTER ONE OF THESE :");

                    Console.WriteLine("+   :   ADDING TOW NUMBERS");

                    Console.WriteLine("-   :   REDUNCING TOW NUMBERS");

                    Console.WriteLine("*   :   MULTIPLY TOW NUMBERS");

                    Console.WriteLine("/   :   DIVIDING TOW NUMBERS");

                    string Result = Console.ReadLine();

                    switch (Result)
                    {
                        case "+":
                            Console.WriteLine($"RESULT : {number1} + {number2} = " + (number1 + number2));
                            break;

                        case "-":
                            Console.WriteLine($"RESULT : {number1} - {number2} = " + (number1 - number2));
                            break;

                        case "*":
                            Console.WriteLine($"RESULT : {number1} * {number2} = " + (number1 * number2));
                            break;

                        case "/":
                            Console.WriteLine($"RESULT : {number1} / {number2} = " + (number1 / number2));
                            break;
                    }

                    Console.WriteLine("PRESS THE ENTER KEY IF YOU WANT TO CONTINUE | AND TYPE THE DOT (.) IF YOU WANT TO GO  OUT");

                    if (Console.ReadLine() == ".")
                    {
                        check = true;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("PLEASE ENTER NUMBER !");
            }
        }
    }
}
