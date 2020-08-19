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
            IntValidator validator = new IntValidator();

            Console.WriteLine("\nEnter the number of numbers you want to sum\n ");

            bool canParse;

            var userSize = Console.ReadLine();
            canParse = validator.Validate(userSize);
            
            int sum = 0;
            if(canParse)
            {
                int size = Int32.Parse(userSize);
                int[] arr = new int[size];
                bool loopFalg = true;

                for (int i = 0; i < size; i++)
                {
                    bool isInt = false;
                    loopFalg = true;

                    while (loopFalg)
                    {
                        Console.WriteLine("\nPlease enter your number\n");
                        var userNumber = Console.ReadLine();
                        isInt = validator.Validate(userNumber);
                        if (isInt)
                        {
                            sum += Int32.Parse(userNumber);
                            loopFalg = false;
                        }
                        else
                        {
                            Console.WriteLine("\nYou entered invalid number!!! please try again\n");
                        }
                    }

                }

            }
            else
            {
                Console.WriteLine("You entered invalid number!!!");
                return;
            }

            Console.WriteLine($"\nThe sum is: {sum}\n");
        }
    }
}
