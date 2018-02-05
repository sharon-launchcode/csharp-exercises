using System;

namespace HelloWorld
{ 

    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Enter Your Name Here: ");
                string userInput =  Console.ReadLine();
                if (userInput != "")
                {
                Console.WriteLine("Hello,  " + userInput);
                Console.ReadLine();
                }
                else
                {
                Console.WriteLine("Cannot be Empty");
                Console.ReadLine();
                }
        }
    }
}
