using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder.MenuOptions
{
    class PrintNumber:IAction
    {
        public PrintNumber()
        {
            
        }

        public void RunOption()
        {
            int number = getValues();
            print(number);
        }
        private int getValues()
        {
            Console.WriteLine("\nPlease enter the number you want to print\n");
            int number = Int32.Parse(Console.ReadLine());
            return number;
        }
        private void print(int number)
        {
            Console.WriteLine($"\nThe number is: {number}\n");
        }
    }
}
