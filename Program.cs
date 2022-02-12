// See https://aka.ms/new-console-template for more information
using System;

namespace HelloWorld
{

    class Program
    {

        /// <summary>
        /// This is a C# Learning introducion
        /// </summary>
        /// <param name='args'>An array of String arguments from the command line</param>
        /// <returns>
        /// Does not return anything
        /// </returns>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("What is your name?: ");
            string str = Console.ReadLine();
            Console.WriteLine("Why, hello there " + str);

            string nullString = null;
            Console.WriteLine(nullString ?? "Ek het null waarde");
            nullString ??= "Ek is nul daarom kry ek 'n waarde";
            Console.WriteLine(nullString);
        }

    }
}
