using System;
// using static System.Console;
// using the above directive enables us to use Console fns like on line 14
// fns like Console.WriteLine() are static methods of the Console class

namespace BasicIO
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Hello, World!"); // newline added at end by default
            Console.Write("Hi, but also ");
            Console.Write("Bye!");

            // WriteLine("Skipping writing Console here");

            Console.WriteLine("\n");

            // Placeholders
            int score = 92;
            Console.WriteLine("{0} is the score {1} got in maths.", score, "CK");
            Console.WriteLine("{1} scored {0} in maths.", score, "CK");

            // Format specifiers

            // F specifier: used to specify the no of decimal places a no should be displayed with
            Console.WriteLine("This number is {0:F3}", 1234.56789); // rounded off to 3 digits

            // C specifier: for currencies. puts currency symbol in front of nos, displyes nos w 2 decimal places and seperates thousands by commas
            Console.WriteLine("Deposit = {0:C}, Account balance = {1:C}", 2125, 12345.678);
            // currency needs to be specified in the format's property!!

            Console.WriteLine("\n");

            // Console.Read() reads the next character from the standard input
            // Console.ReadLIne() reads user input from the standard input and always RETURNS A STRING
            Console.Write("Write something here: ");
            string userInput = Console.ReadLine();
            Console.WriteLine("\nThe line you wrote was: "+userInput);

            // converting a string to an integer
            Console.Write("Enter your age here: ");
            int userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nYour age is: " + userAge);

            // for conversion to a decimal: Convert.ToDecimal()
            // for conversion to a float  : Convert.ToSingle()
            // for conversion to a double : Convert.ToDouble()

            Console.Read();
        }
    }
}