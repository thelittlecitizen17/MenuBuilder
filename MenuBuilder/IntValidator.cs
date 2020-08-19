using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    class IntValidator
    {
        public IntValidator()
        {

        }
        public bool Validate(string n)
        {
            int number = 0;
            bool canParse;

            canParse = Int32.TryParse(n, out number);

            if(canParse)
            {
                return true;
            }
            else
            {
                return false;
            }
          
        }
    }
}
