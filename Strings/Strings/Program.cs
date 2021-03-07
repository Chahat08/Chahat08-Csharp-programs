using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(String[] args)
        {
            // declaration
            string str1 = "Hello, World!";
            string str2 = " Bye!";
            Console.WriteLine(str1);
            Console.WriteLine(str2);

            // concatenation
            string str3 = str1 + " Nice to meet you!" + str2;
            Console.WriteLine(str3);

            // str3 = "Hello, World!""bye!"; // not allowed in C#

            // empty string
            string empty = "";
            Console.WriteLine(empty);

            /* PROPERTIES */

            // Length: returns the no of characters in the string
            Console.WriteLine("Length: " + str1.Length);

            /* METHODS */

            // Substring(): to extract a substring from a string
            // returns the extracted substring
            // syntax: str_name.Substring(startIndex, noOfChars);
            Console.WriteLine(str1.Substring(1, 2));

            // Equals(): To compare if the two strings are equal
            // returns bool value true if the strings are equal else returns false
            // syntax: str1.Equals(str2);
            Console.WriteLine(str1.Equals("Hello, World!")); // true
            Console.WriteLine(str1.Equals(str2)); // false

            // Split(): to split the string into an array of substrings based on user defined seperators
            // returns array of split substrings
            // syntax: str1.Split(seperator, options)
            string[] seperator = { ", ", "; " }; // arr of strings containing seperators
            string names = "Chahat, Muskan; Bhavana, , DSK";
            string[] substrs = names.Split(seperator, StringSplitOptions.None);
            // substrs contains: {"Chahat", "Muskan", "Bhavana", "", "DSK"}
            substrs = names.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
            // substrs contains: {"Chahat", "Muskan", "Bhavana", "DSK"}


            Console.Read();
        }
    }
}