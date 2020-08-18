using System;
using System.Collections.Generic;
using System.Text;
using MenuBuilder.MenuOptions;


namespace MenuBuilder
{
    class MenuRunner
    {
        public MenuRunner()
        {

        }
        public void Run()
        {
            List<string> myOptions = new List<string>() { "1) Print the number ", "2) Sum the numbers ", "3) exit" };
            string menuName = "Main";
            PrintNumber firstAction = new PrintNumber();
            SumOfNumbers secondAction = new SumOfNumbers();
            Exit exit = new Exit();

            Dictionary<string, IAction> dictOptions = new Dictionary<string, IAction>(){
                {"1" ,firstAction},{ "2",secondAction},{ "3",exit} };

            IMenu mainMenu = new NumericMenu(myOptions , menuName , dictOptions);
            mainMenu.GetOptionFromMenu();


            Dictionary<string, IAction> dictOptionsFree = new Dictionary<string, IAction>(){
                {"Print the number" ,firstAction},{ "Sum the numbers",secondAction} , {"exit",exit} };
            List<string> myOptionsFree = new List<string>(){ "Print the number ", "Sum the numbers ", "exit" };
            string newMenuName = "Free";

            IMenu freeMenu = new FreeMenu(myOptionsFree, newMenuName, dictOptionsFree);
            freeMenu.GetOptionFromMenu();

        }
    }
}
