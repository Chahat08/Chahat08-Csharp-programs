using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(String[] args)
        {
            // declaration and initialisation
            int[] arr = { 15, 21, 17, 8, 5 };
            // declare like "int [] arr" or like "int[] arr"

            // dynamic memory allocation
            // for declaration first and initialsation later

            // declaration:  use new operator
            int[] newArr;
            // or int[] newArr = new int[7]; // to explicitly state length
            
            // initialisation
            newArr = new[] { 15, 14, 10, 8, 5, 10, 20};

            // zero based indexing is used in C#
            Console.WriteLine(newArr[0]); // newArr's first element

            // ---------------------------------------------------

            /* ARRAY METHODS AND PROPERTIES */
            // use dot operator to access methods/properties in c# (.)
            // methods are class functions (usually methods of the inbuilt Array class in this context)
            // properties are class attributes (usually properties of the array that we have declared)

            // Length: property, the no. of elements in the array
            Console.WriteLine("Length: " + newArr.Length);

            // Copy: method, to copy elements of one array into another
            // syntax: Array.Copy(src, dest, no_of_elements);
            Array.Copy(newArr, arr, 3);
            // Copies the first 3 elements of newArr into arr's first 3 locations;
            // now arr = {15, 14, 10, 8, 5}

            // Sort: method, to sort the elements of an array in asc order
            // sorts in place
            Array.Sort(newArr);

            // IndexOf(): method, returns the index of the first occurance of the element
            // within the array, else returns -1 if the element is not found
            Console.WriteLine(Array.IndexOf(newArr, 14));
            Console.WriteLine(Array.IndexOf(newArr, 100));

            Console.Read();
        }
    }
}