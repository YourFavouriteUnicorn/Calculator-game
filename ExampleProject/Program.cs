using System;
using System.Runtime.InteropServices;

namespace ExampleProject
{
    class Program
    {

        

static void Main(string[] args)
        {
            void addTwoNumbers ()
            {
                Console.WriteLine("Let's ADD two numbers. Please type first number: ");
                double firstNumber = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Now, type second number: ");
                double secondNumber = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Thank you, here is your answer: " + firstNumber + " + " + secondNumber + " = " + (firstNumber + secondNumber));
                Console.ReadLine();
            }

            void subtractTwoNumbers()
            {
                Console.WriteLine("Let's SUBTRACT two numbers. Please type first number: ");
                double firstNumber = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Now, type second number: ");
                double secondNumber = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Thank you, here is your answer: " + firstNumber + " - " + secondNumber + " = " + (firstNumber - secondNumber));
                Console.ReadLine();
            }

            void multiplyTwoNumbers()
            {
                Console.WriteLine("Let's MULTIPLY two numbers. Please type first number: ");
                double firstNumber = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Now, type second number: ");
                double secondNumber = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Thank you, here is your answer: " + firstNumber + " * " + secondNumber + " = " + (firstNumber * secondNumber));
                Console.ReadLine();
            }
            void divideTwoNumbers()
            {
                Console.WriteLine("Let's DIVIDE two numbers. Please type first number: ");
                double firstNumber = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Now, type second number: ");
                double secondNumber = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Thank you, here is your answer: " + firstNumber + " / " + secondNumber + " = " + (firstNumber / secondNumber));
                Console.ReadLine();
            }

            void answerFunction(string inputName)
            {
                if (inputName.ToUpper() == "YES")
                {
                    Console.WriteLine("Press ENTER to begin!");
                    Console.ReadLine();
                    Console.Write("Choose what you want to do : \n ADD - enter 1 and press ENTER \n SUBTRACT - enter 2 and press ENTER " +
                        "\n MULTIPLY - enter 3 and press ENTER \n DIVIDE - enter 4 and press ENTER \n ");
                    int userChoiseNumber = Convert.ToInt32(Console.ReadLine());
                    switch(userChoiseNumber)
                    {
                        case 1: addTwoNumbers();
                            break;
                        case 2: subtractTwoNumbers();
                            break;
                        case 3: multiplyTwoNumbers();
                            break;
                        case 4: divideTwoNumbers();
                            break;
                        
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



            Console.Write("hello, what is your name?");
            string name = Console.ReadLine();
            string firstNameLetter = name.Substring(0, 1).ToUpper();
            string otherNameLetters = name.Substring(1).ToLower();
            string nameWithUpperCase = firstNameLetter + otherNameLetters;
            
            Console.Write("Hello " + nameWithUpperCase + "! Do you want to calculate some numbers? Please type \"yes\" or \"no\"");
            string answer = Console.ReadLine();
              answerFunction(answer);

            

            
            



           

        }
    }
}