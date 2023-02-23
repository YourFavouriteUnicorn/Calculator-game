using System;
using System.Runtime.InteropServices;

namespace ExampleProject
{
    class Program
    {

        

static void Main(string[] args)
        {

            void answerFunction(string inputName)
            {
                if (inputName.ToUpper() == "YES")
                {
                    Console.WriteLine("Let's begin!");
                    Console.ReadLine();
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
            
            Console.Write("Hello " + name + " Do you want to calculate some numbers? Please type \"yes\" or \"no\"");
            string answer = Console.ReadLine();
              answerFunction(answer);
            
            



           

        }
    }
}