using System;
using System.Collections.Generic;
using System.Text;

namespace ArqSandBox.Common.Extensions
{
    public static class StringExtensions
    {
        public static bool StartsWithUpper(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return false;

            return Char.IsUpper(str[0]);
        }
    }
}
