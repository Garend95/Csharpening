using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Sheet
    {
        public static void Main(string[] args)
        {
           
            bool format1; // ex: row48col24 or col79row23532
            bool format2; // ex: aaa67 or idg253

            Console.WriteLine("Please enter the spreadsheet coordinates in either format");  ///Row112col333 or AA14
            
            
            string input = Console.ReadLine();
            input = input.ToUpper();
            Console.WriteLine(input);
        }
    }
}
