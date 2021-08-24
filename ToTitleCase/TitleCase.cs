using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConvertToTitleCase
{
    public static class TitleCase
    {

        public static string ToTitleCase(this string givenString)
        {
            if (string.IsNullOrWhiteSpace(givenString))
            {
                return givenString;
            }

            string[] strings = SplitStrings(givenString);

            StringBuilder capitalizedString = new StringBuilder("");

            foreach (var item in strings)
            {
                string titleCase = item[0].ToString().ToUpper() + item[1..];
                capitalizedString.Append(titleCase + " ");
            }

            return capitalizedString.ToString().Trim();
        }

        static string[] SplitStrings(string givenString)
        {
            string[] strings = givenString.Split(" ");
            return strings;
        }
    }
}
