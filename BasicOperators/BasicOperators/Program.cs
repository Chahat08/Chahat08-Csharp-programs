using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicOperators
{
    class Program
    {
        static void Main(String[] args)
        {
            int x = 8, y = 9;

            // addition
            Console.WriteLine(x + y); // 17

            // subtraction
            Console.WriteLine(x - y); // -1

            // multiplication
            Console.WriteLine(x * y); // 72

            // division
            Console.WriteLine(x / y); // 0 (decimal division)

            // modulus
            Console.WriteLine(x % y); // 8

            // normal divison: when one of them is a double/float/decimal
            float f = 2.0f;
            Console.WriteLine(x / f); // 4.0
            Console.WriteLine(y / f); // 4.5

            // SHORTHAND OPERATORS
            x += 1; // now x = 9, same as x=x+1;
            y %= 2; // now y = 1, same as y=y%2;

            // INCREMENT AND DECREMENT OPERATORS
            int i = 1, j = 10;

            // post increment/decrement (i++ or i--)
            Console.WriteLine(i++); // 1, but now i = 2
            // same as writing:
            // Console.WriteLine(i); i = i+1;

            // pre increment/decrement (++i or --i)
            Console.WriteLine(++j); // 2, and now i = 2
            // same as writing:
            // i = i+1; Console.WriteLine(i); 


            Console.Read();
        }
    }
}