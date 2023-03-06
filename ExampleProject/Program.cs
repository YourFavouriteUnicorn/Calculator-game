using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace ExampleProject
{
    class Program
    {



        static void Main(string[] args)
        {






            Console.Write("hello, what is your name?");
            string name = Console.ReadLine();
            string firstNameLetter = name.Substring(0, 1).ToUpper();
            string otherNameLetters = name.Substring(1).ToLower();
            string nameWithUpperCase = firstNameLetter + otherNameLetters;

            Console.Write("Hello " + nameWithUpperCase + "! Do you want to calculate some numbers? Please type \"yes\" or \"no\"");
            string answer = Console.ReadLine();
            answerFunction(answer);


            void answerFunction(string inputName)
            {

                if (inputName.ToUpper() == "YES")
                {
                    Console.WriteLine("Press ENTER to begin!");
                    Console.ReadLine();
                    Console.Write("Choose what you want to do : \n ADD - enter 1 and press ENTER \n SUBTRACT - enter 2 and press ENTER " +
                        "\n MULTIPLY - enter 3 and press ENTER \n DIVIDE - enter 4 and press ENTER \n ");
                    int userChoiceNumber = Convert.ToInt32(Console.ReadLine());

                    if (userChoiceNumber == 1)
                    {
                        CalculateTwoNumbers('+');
                    }
                    else if (userChoiceNumber == 2)
                    {
                        CalculateTwoNumbers('-');
                    }
                    else if (userChoiceNumber == 3)
                    {
                        CalculateTwoNumbers('*');
                    }
                    else if (userChoiceNumber == 4)
                    {
                        CalculateTwoNumbers('/');
                    }
                    else
                    {
                        Console.WriteLine("Ooops! Invalid input. Please enter 1,2,3 or 4 to continue.");


                    }
                }


                else if (inputName.ToUpper() == "NO")
                {
                    Console.WriteLine("Hope to see you next time, goodbye!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Ooops something went wrong, please type correct answer into console");
                    Console.ReadLine();
                }
            }


            void CalculateTwoNumbers(char operatorInput)
            {


                Console.WriteLine("Please type first number! (for decimal numbers -  use comma): ");
                try
                {
                    double firstNumber = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Now, type the second number: ");
                    double secondNumber = Convert.ToDouble(Console.ReadLine());

                    double finalAnswer = 0;
                    switch (operatorInput)

                    {
                        case '+':
                            finalAnswer = firstNumber + secondNumber;
                            break;

                        case '-':
                            finalAnswer = firstNumber - secondNumber;
                            break;

                        case '*':
                            finalAnswer = firstNumber * secondNumber;
                            break;

                        case '/':
                            finalAnswer = firstNumber / secondNumber;
                            break;



                    }


                    Console.WriteLine($"Thank you, here is your answer:" +
                        $" {firstNumber} {operatorInput} {secondNumber} = {finalAnswer}");
                    Console.ReadLine();
                }

                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Invalid format of number. Please type comma for decimal numbers.");
                    Console.ReadLine();

                }















            }
        }
    }
}