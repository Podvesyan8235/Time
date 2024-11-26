using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Parse
            Console.WriteLine("Метод Parse");
            Console.WriteLine(DateTime.Parse("27.11.2024"));

            // TryParse
            Console.WriteLine("Метод TryParse");
            if (DateTime.TryParse("2024-11-27", out DateTime date1))
                Console.WriteLine(date1);

            // ParseExact
            Console.WriteLine("Метод ParseExact");
            Console.WriteLine(DateTime.ParseExact("27-Nov-2024", "dd-MMM-yyyy", CultureInfo.InvariantCulture));

            // TryParseExact
            Console.WriteLine("Метод TryParseExact");
            if (DateTime.TryParseExact("2024/11/27", "yyyy/MM/dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date2))
                Console.WriteLine(date2);

            Console.ReadLine();

           
        }
    }
}
