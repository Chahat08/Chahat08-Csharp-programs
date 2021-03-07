using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;

namespace DataTypes
{
    class Program
    {
        static void Main(String[] args)
        {
            // int: [-2,147,483,648, 2,147,483,647]
            int i = 10;
            // no long datatype in C#

            // byte: [0, 255]
            byte b = 255;
            // byte B = 265; // error, out of range

            // float: [-3.4 x 10^38, +3.4 x 10^38]
            // precision of 7 digits approx
            // 8 bytes storage
            float f = 1234.5f;
            // f suffix is imp as double is the default datatype
            // float g = 1234.5; // error, suffix f

            // double: [(+/-)5.0 x 10^-324, (+/-)1.7 x 10^308]
            // precision: approx 15-16 digits
            // so called because it has "double" the precision of a float
            double d = 1234.7890;
            // the default datatype for floating points in C#

            // decimal: smaller range than double or float
            // precision: 28-29 digits
            decimal m = 1234.987654321m;
            // m suffix important for decimals
            // decimal n = 1234.6; // error, suffix m


            // TYPE CONVERSION: prefix by (datatype)
            int j = (int)1.9; // j=1, truncated after decimal pt.

        }
    }
}
