using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    interface IMenu
    {
        List<string> Options { get; set; }

        void GetOptionFromMenu();

    }
}
