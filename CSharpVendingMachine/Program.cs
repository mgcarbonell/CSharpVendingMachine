using System;

namespace CSharpVendingMachine
{    class Program
    {
        public static void Main(string[] args)
        {
            VendingMachine vendy = new VendingMachine(true, 50, 10);
            var cola = new Soda("RC Cola", 0.9, "12/12/2027", 350, "Cola", true, false);
            var crunch = new Chocolate("Crunch", 2.3, "12/12/2027", 43, true);
            cola.SodaDetails();
            crunch.ChocolateDetails();
        }
    }
}
