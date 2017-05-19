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
            Console.WriteLine("Please enter the spreadsheet coordinates in either format");  ///Row112col333 or AA14
            
            bool format1; // ex: row48col24 or col79row23532
            bool format2; // ex: aaa67 or idg253
            
            string input = Console.ReadLine();
            input = input.ToUpper();    // when the uppercase is only considered, ASCII comparisons become easier
            Console.WriteLine(input);

            //Conditions for format1
			bool condition1 = (input.Contains("ROW") && input.Contains("COL")); // input string has to contain ROW and COL
            bool condition2 = ((input.IndexOf("ROW") == input.LastIndexOf("ROW")) && (input.IndexOf("COL") == input.LastIndexOf("COL"))); // No duplicate ROW and COL substrings should exist
            bool condition3 = ((Math.Abs(input.IndexOf("ROW")-input.IndexOf("COL"))) != 3); // ROW and COL should not be attached ex: ROWCOL COLROW
            bool rowfirst = (input.IndexOf("ROW") < input.IndexOf("COL")); // whether ROW comes before COL or vice-versa
        }
    }
}
