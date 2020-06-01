using System;
using System.Collections.Generic;
using System.Text;

namespace StringCalculator
{
    public class Numbers
    {
        public Numbers()
        {
            numbers = new List<int>();
        }

        private List<int> numbers;

        public void AddNumbers(int nr)
        {
            if (nr>=0&& nr<=1000)
            {
                numbers.Add(nr);
            }         
            else
            {
                numbers.Add(0);
            }
         
        }

        public void GetNumbers()
        {
            var sum = 0;
            var nrHigh = int.MinValue;
            var nrLowest = int.MaxValue;

            foreach (var item in numbers)
            {
                Console.Write(" " + item);
                if (item > nrHigh)
                {
                    nrHigh = item;
                }
                if (item < nrLowest)
                {
                    nrLowest = item;
                }


                sum += item;
            }
            Console.WriteLine("  Sum : " + sum + " high " + nrHigh + " lowest " + nrLowest);
        }


    }
}
