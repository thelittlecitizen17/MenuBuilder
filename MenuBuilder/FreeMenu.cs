using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    class FreeMenu:IMenu
    {
        public List<string> Options { get; set; }
        private string _menuName;
        FreeMenuValidator validator;


        public Dictionary<string, IAction> DictOptions { get; set; }

        public FreeMenu(List<string> options, string menuName, Dictionary<string, IAction> dictOptions)
        {
            Options = options;
            _menuName = menuName;
            DictOptions = dictOptions;
            validator = new FreeMenuValidator(DictOptions);

        }

        public void GetOptionFromMenu()
        {
            bool menuFlag = true;
            MenuOutput menuPrinter = new MenuOutput(_menuName);

            while (menuFlag)
            {
                var choice = menuPrinter.PrintOUt(Options);

                bool validationFlag = validator.ChoiceValidator(choice);
                if (validationFlag)
                {
                    if (choice != "exit")
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
