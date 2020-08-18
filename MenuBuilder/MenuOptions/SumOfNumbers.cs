using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder.MenuOptions
{
    class SumOfNumbers:IAction
    {
        public SumOfNumbers()
        {

        }
        public void RunOption()
        {
            SumNumbers();
        }
        public void SumNumbers()
        {
            Console.WriteLine("\nEnter the number of numbers you want to sum\n ");
            int size = Int32.Parse(Console.ReadLine());
            int sum = 0;

            int[] arr = new int[size];

            for(int i =0; i<size; i++)
            {
                Console.WriteLine("\nPlease enter your number\n");
                sum += int.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum);
        }
    }
}
