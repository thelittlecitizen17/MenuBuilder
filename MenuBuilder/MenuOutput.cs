using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    class MenuOutput
    {
        private string _menuName;
        public MenuOutput(string menuName)
        {
            _menuName = menuName;
                
        }
        public string PrintOUt(List<string> options)
        {
            Console.WriteLine($"\nWelcome to {_menuName} menu \n");
            string choice = "1";


            foreach (var option in options)
            {
                Console.WriteLine(option);
            }

            Console.WriteLine("\nPlease enter your choice\n");
            choice = Console.ReadLine();

            return choice;
        }
    }
}
