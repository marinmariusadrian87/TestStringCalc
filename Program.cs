using System;
using System.Collections.Generic;
using System.IO;

namespace StringCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" String Numbers ");
            var inputString = Console.ReadLine();

            var nrString = Calculator.Add(inputString);

            Console.WriteLine(nrString);




            #region NumbersCalc
            Numbers nr = new Numbers();

            while (true)
            {
                Console.WriteLine("Add numbers or press q to show te sum ");
                var inputNumber = Console.ReadLine();

                if (inputNumber == "q")
                {

                    break;
                }
                if (inputNumber == String.Empty)
                {
                    inputNumber = "0";
                }

                var nrAdd = int.Parse(inputNumber);
                nr.AddNumbers(nrAdd);
            }

           
            nr.GetNumbers();

            #endregion
        }
    }
}
