/*
    Author: Yao Xiao    
    Date: 1/30/2019
    Comments: This C# Console application code demonstrates the use of
              methods after getting input from a user name.
*/
using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Hello," + name);
            Console.ReadLine();
        }
    }
}
