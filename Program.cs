// Made by Jordan Leich on 6/5/2020

using System;
using System.Threading;

namespace Simple_Survey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to a simple survey!");
            Console.WriteLine("");
            Thread.Sleep(2000);

            try
            {
                Console.WriteLine("What is your name? ");
                string name = Console.ReadLine();
                Console.WriteLine();
                Thread.Sleep(2000);

                Console.WriteLine("Hello " + name + ", how old are you? ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Thread.Sleep(2000);

                Console.WriteLine("What do you like to do in your free time " + name + "? ");
                string hobby = Console.ReadLine();
                Console.WriteLine();
                Thread.Sleep(2000);
                Console.WriteLine("What are your thoughts on computer science and programming? ");
                string thoughts = Console.ReadLine();
                Console.WriteLine();
                Thread.Sleep(2000);

                Console.WriteLine("Computing your information together...");
                Console.WriteLine();
                Thread.Sleep(4000);


                Console.WriteLine("Your name is " + name + " and you are " + age + " years old.");
                Console.WriteLine(name + " likes to spend free time doing " + hobby + ".");
                Console.WriteLine("Yours thoughts on computer science and programming: ");
                Console.WriteLine();
                Thread.Sleep(2000);

                Console.WriteLine("Ending survey...");
                Thread.Sleep(3000);
            }

            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
        }
    }
}
