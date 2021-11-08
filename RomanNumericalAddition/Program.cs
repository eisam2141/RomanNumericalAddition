using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumericalAddition
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine();
            List<int> lst = new List<int>();
            foreach(string i in a.Split(' '))
            {
                var b = DataGen.RomanNumerals.RomanNumeralsExtensions.ParseRomans(i.ToUpper());
                lst.Add(b);
            }
            var k = lst.Sum();

            var output = DataGen.RomanNumerals.RomanNumeralsExtensions.ToRomans(k);

            Console.WriteLine($"Total of {a} = {output}")

           
            Console.WriteLine("Hello World!");
        }
    }
}
