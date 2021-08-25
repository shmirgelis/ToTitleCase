using System;

namespace ConvertToTitleCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string tCase = ConvertToTitleCase.TitleCase.ToTitleCase("belekas  yra  testas");
            Console.WriteLine(tCase);
        }

    }
}
