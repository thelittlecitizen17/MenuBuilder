using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    class FreeMenuValidator
    {
        private Dictionary<string, IAction> _dictOptions;
        public FreeMenuValidator(Dictionary<string, IAction> dictOptions)
        {
            _dictOptions = dictOptions;
        }
        public bool ChoiceValidator(string choice)
        {
            
            if ( _dictOptions.ContainsKey(choice))
            {
                return true;
            }
            else
            {
                Console.WriteLine("The string is invalid");
                return false;
            }
        }

    }
}
