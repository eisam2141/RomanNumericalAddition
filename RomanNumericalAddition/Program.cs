using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumericalAddition
{
   public class Program
    {
       public static void Main(string[] args)
        {
            // Console.WriteLine("Enter roman numericals with spaces to add eg : X X L");
            //var input = Console.ReadLine();
            AddNumerical(args);
              
            
        }

        public static string AddNumerical(string[] args)
        {
            var input = args;
            List<int> lst = new List<int>();
            try
            {
                if (input.Length < 0) { throw new Exception("Input Cannot be null"); };
                foreach (string i in input)
                {
                    var romanToInt = DataGen.RomanNumerals.RomanNumeralsExtensions.ParseRomans(i.ToUpper());
                    lst.Add(romanToInt);
                }
                var total = lst.Sum();

                var output = DataGen.RomanNumerals.RomanNumeralsExtensions.ToRomans(total);

                Console.WriteLine($"Total of {input} = {output}");
                return output;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
