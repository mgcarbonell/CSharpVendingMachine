using System;

namespace CSharpVendingMachine
{    class Program
    {
        public static void Main(string[] args)
        {
            VendingMachine vendy3000 = new VendingMachine();

            //Console.WriteLine(vendy3000.GetManufacturer());
            vendy3000.PrintFields();
        }
    }
}
