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
            bool canParse;

            while (true)
            {
                Console.WriteLine("\nPlease enter the number you want to print\n");
                var userNumber = Console.ReadLine();
                IntValidator validator = new IntValidator();
                canParse = validator.Validate(userNumber);

                if (canParse)
                {
                    return Int32.Parse(userNumber);
                }
                else
                {
                    Console.WriteLine("\nYou entered invalid number! please try again\n");
                }
            }
        }
        private void print(int number)
        {
            Console.WriteLine($"\nThe number is: {number}\n");
        }
    }
}
