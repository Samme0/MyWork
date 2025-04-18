using System;

namespace CodeBlack3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            void GreetUser()
            {
                // Exercise 1
                Console.WriteLine("Enter your name: ");
                string UserName = Console.ReadLine();



                Console.WriteLine("Hello welcome to C#!");
            }

            // Call the function
            GreetUser();
            
        }
   }

}
