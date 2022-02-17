using System;

namespace CSharpVendingMachine
{    class Program
    {
        public static void Main(string[] args)
        {
            VendingMachine vendy = new VendingMachine();
            //var vendy2 = new VendingMachine(true, 50, 10);
            //var badVendy = new VendingMachine(true, 110, -10);

            //Console.WriteLine(vendy3000.GetManufacturer());
            vendy.PrintFields();
            //vendy2.PrintFields();
            //badVendy.PrintFields();
        }
    }
}
