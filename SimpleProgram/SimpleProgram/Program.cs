using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProgram
{
    class Program
    {
        static void Main(String[] args)
        {
            string name;
            int birthYear;
            int currYear;

            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("Enter the year you were born in: ");
            birthYear = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the current year: ");
            currYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");

            Console.WriteLine("Hello, {0}! You were born in {1} and are currently {2} years old.", name, birthYear, currYear - birthYear);

            Console.Read();
        }
    }
}