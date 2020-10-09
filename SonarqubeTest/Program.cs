using System;

namespace SonarqubeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var fieldName = "First name";
            if (CustomHelper.MandatoryFields.Contains(fieldName))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
