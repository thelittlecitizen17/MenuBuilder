using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    class NumericMenuValidator : IValidator
    {
        private Dictionary<string, IAction> _dictOptions;
        public NumericMenuValidator(Dictionary<string, IAction> dictOptions)
        {
            _dictOptions = dictOptions;
        }
        public bool ChoiceValidator(string choice)
        {
            int i = 0;
            if(int.TryParse(choice,out i) && _dictOptions.ContainsKey(choice))
            {
                return true;
            }
            else
            {
                Console.WriteLine("The number invalid");
                return false;
            }
        }

    }
}
