using System;

namespace ConvertToTitleCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string tCase = ConvertToTitleCase.TitleCase.ToTitleCase("b");
            Console.WriteLine(tCase);
        }

    }
}
