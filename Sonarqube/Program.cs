using System;

namespace Chuck.Sonarqube
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

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
