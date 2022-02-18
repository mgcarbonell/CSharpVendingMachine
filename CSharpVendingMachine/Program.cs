using System;

namespace CSharpVendingMachine
{    class Program
    {
        public static void Main(string[] args)
        {
            VendingMachine vendy = new VendingMachine(true, 50, 10);
            //var vendy2 = new VendingMachine(true, 50, 10);
            //var badVendy = new VendingMachine(true, 110, -10);

            //Console.WriteLine(vendy3000.GetManufacturer());
            //vendy.PrintFields();
            //vendy2.PrintFields();
            //badVendy.PrintFields();
            //Beverage cola = new Beverage("RC Cola", 0.7, "8/12/2027", 0.35, "Cola");
            //cola.BeverageDetails();
            var cola = new Soda("CocaCola", 0.9, "12/12/2025", 0.35, "Cola", false, true);
            cola.SodaDetails();
        }
    }
}
