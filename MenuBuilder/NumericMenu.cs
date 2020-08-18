using System;
using System.Collections.Generic;
using System.Text;
using MenuBuilder.MenuOptions;

namespace MenuBuilder
{
    class NumericMenu : IMenu
    {

        public List<string> Options { get; set; }
        private string _menuName;

        NumericMenuValidator validator;
        public Dictionary<string, IAction> DictOptions { get; set; }

        public NumericMenu(List<string> options , string menuName , Dictionary<string, IAction> dictOptions)
        {
            Options = options;
            _menuName = menuName;
            DictOptions = dictOptions;
            validator = new NumericMenuValidator(DictOptions);

        }


        public void GetOptionFromMenu()
        {
            bool menuFlag = true;
            MenuOutput menuPrinter = new MenuOutput(_menuName);



            while (menuFlag)
            {
                var choice = menuPrinter.PrintOUt(Options);

                var ValidationFlag = validator.ChoiceValidator(choice);
                if (ValidationFlag)
                {

                    if (Int32.Parse(choice) != Options.Count)
                    {
                        DictOptions[choice].RunOption();
                    }
                    else
                    {
                        menuFlag = false;
                    }
                }
            }

        }



    }
}
