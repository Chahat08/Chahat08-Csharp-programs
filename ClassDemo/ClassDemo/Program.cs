using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    class Staff // main components: fields, properties, methods and constructors
    {
        // fields
        private string nameOfStaff;
        private const int hourlyRate = 30;
        private int hworked;
        /* 
         * access modifiers in c#: private, public, protected, internal
         * private fields can only be accessed from within the class itself
        */

        // properties
        // THERE ARE ALSO AUTO-IMPLEMENTED PROPERTIES!!
        public int HoursWorked
        {
            get // getter accessor
            {
                return hworked;
            }
            set // setter accessor
            {
                if (value > 0) hworked = value;
                else hworked = 0;
            }
            // default access level of accessor is same as property: public here
            // but it can be changed like so: private set
            // private set is read-only outside the class and can only be modified from within it
        }

        // methods
        private void PrintMessage()
        {
            Console.WriteLine("Calculating pay...");
        }

        public int CalculatePay()
        {
            PrintMessage();

            int staffPay = hworked * hourlyRate;

            if (hworked > 0) return staffPay;
            else return 0;
        }
        // overloading
        public int CalculatePay(int bonus, int allowance)
        {
            PrintMessage();

            if (hworked > 0) return hworked * hourlyRate + bonus + allowance;

            else return 0;

        }
        // overriding the ToString() method
        public override string ToString()
        {
            return "Name of Staff = " + nameOfStaff + "; Hourly Rate = " + hourlyRate
                + "; Hours Worked = " + HoursWorked;
            // ToString() comes with its own default implementation
            // but it is customary to override it

        }

        // constructors
        // constructors have the same name as the class and no return type
        public Staff(string name)
        {
            nameOfStaff = name;
            Console.WriteLine("\n" + nameOfStaff);
            Console.WriteLine("----------------------");
        }
        // another constructor
        public Staff(string fName, string lName)
        {
            nameOfStaff = fName + lName;
            Console.WriteLine("\n" + nameOfStaff);
            Console.WriteLine("----------------------");
        }
        /* if we don't specify any constructors then c# initialises our fields by default to empty values */
        /* like 0 for numeric types and empty string for string types */
    }
    class Program
    {
        static void Main(string[] args)
        {
            int pay;
            // instantiation of an object
            Staff staff1 = new Staff("Chahat");
            staff1.HoursWorked = 160;
            Console.WriteLine(staff1.ToString());
            pay = staff1.CalculatePay();
            Console.WriteLine("Pay = "+ pay);
            Console.WriteLine("----------------------");

            // another object
            Staff staff2 = new Staff("Random", "Name");
            staff2.HoursWorked = 200;
            pay = staff2.CalculatePay(10, 50);
            Console.WriteLine("Pay = " + pay);
            Console.WriteLine("----------------------");

            // yet another object
            Staff staff3 = new Staff("CK");
            staff3.HoursWorked = -1;
            pay = staff3.CalculatePay(100, 200);
            Console.WriteLine("Pay = " + pay);
            Console.WriteLine("----------------------");

            Console.Read();

        }
    }
}
