using Coindesk.Services;
using System;

namespace Coindesk
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new CurrentPriceService();
            Console.WriteLine(service.GetCurrentPriceEuro());
            Console.ReadLine();
        }
    }
}
