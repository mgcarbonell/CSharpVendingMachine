using System;


namespace CSharpVendingMachine
{
    class Beverage : Product
    {
        private double _litres;
        private string _flavor;

        public Beverage(string name, double price, string expiryDate, double litres, string flavor)
            : base(name, price, expiryDate)
        {
            this._litres = litres;
            this._flavor = flavor;
        }

        public void BeverageDetails()
        {
            PrintDetails();
            Console.WriteLine("Litres: " + this._litres);
            Console.WriteLine("Flavor: " + this._flavor);
        }
    }
}