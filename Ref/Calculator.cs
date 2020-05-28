using System;
using System.Collections.Generic;
using System.Text;

namespace Ref
{
    class Calculator
    {
        public static void Triple(ref int x)
        {
            x = x * 3;
        }
    }
}
