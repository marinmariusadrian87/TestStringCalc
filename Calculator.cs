using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace StringCalculator
{
    public class Calculator
    {
        public static int Add(string numbers)
        {
            char[] delimiters = GetDelimiters(numbers);

            string[] strings = numbers.Split(delimiters);
            int sum = 0;
            
            foreach (var item in strings)
            {
                if (int.TryParse(item, out int number))
                {
                    sum += number;
                }
            }
            return sum;          
        }

        private static char[] GetDelimiters(string numbers)
        {
            var delimiters = new List<char> {',','\n' };

            if (numbers.StartsWith("//"))
            {
                string stringsDelimiter =   numbers.Split('\n').First();
                char delimiter =   stringsDelimiter.Substring(2,1).Single();
                delimiters.Add(delimiter);
            }
            return delimiters.ToArray();
            
        }
    }
}
