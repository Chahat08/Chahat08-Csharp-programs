using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(String[] args)
        {
            /*
             * Lists come under the System.Collections.Generic namespace
             * Generally preferred over arrays because of the relative ease of modification
             * Unlike arrays, Lists can be resized dynamically.
            */

            // DECLARATION
            List<int> aList = new List<int>();

            // DECLARATION AND INITIALISATION
            List<int> lst = new List<int> { 1, 2, 3, 4, 5 };

            // ACCESSING ELEMENTS: simple indexing
            Console.WriteLine(lst[0]); // first element

            // Add() method: to add elements to the end of the list
            aList.Add(10);
            aList.Add(20);

            // Count property: to count the no of elements in a list
            Console.WriteLine(aList.Count);

            // Insert() method: to insert an element at a specific postition
            // aList.Insert(index, value);
            aList.Insert(1, 15);

            // Remove() method: removes (inplace) the first instance of the arg supplied
            aList.Remove(15);

            // RemoveAt() method: to remove the element at the given index
            aList.RemoveAt(1);

            // Contains() method: returns bool true if the given element is in the list, else false
            Console.WriteLine(aList.Contains(10));

            // Clear() method: to remove all the items in the list
            aList.Clear();

            Console.Read();
        }
    }
}