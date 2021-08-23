using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertToTitleCase
{
    public static class TitleCase
    {
        public static string ToTitleCase(this string givenString)
        {
            if(givenString.Length == 0)
            {
                throw new Exception("string is empty");
            }
            string titleCase = givenString[0].ToString().ToUpper() + givenString[1..];
            return titleCase;
        }
    }
}
