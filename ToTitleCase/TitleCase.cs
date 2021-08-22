using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertToTitleCase
{
    public static class TitleCase
    {
        public static string ToTitleCase(this string givenString)
        {
            string titleCase = givenString[0].ToString().ToUpper() + givenString[1..];
            return titleCase;
        }
    }
}
