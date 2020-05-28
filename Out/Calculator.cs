using System;
using System.Collections.Generic;
using System.Text;

namespace Out
{
    class Calculator
    {
        public static void Triple(int origin, out int result) // out não precisa ser inciada 
        {
            result = origin * 3;
        }
    }
}
