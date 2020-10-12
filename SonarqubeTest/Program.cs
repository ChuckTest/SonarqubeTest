using System;

namespace SonarqubeTest
{
    public static class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Hello world.");

                foreach (var item in CustomHelper.MandatoryFields)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine(Math.Pi);

                Console.WriteLine(Shape.Empty.GetHashCode());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
