using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods.Extension
{
    class StringExtension
    {
        public static string Cut(this string ThisObj, int count)
        {
            if(ThisObj.Length <= count)
            {
                return ThisObj;
            }
            else
            {
                return ThisObj.Substring(0, count) + "...";
            }
        }
    }
}
