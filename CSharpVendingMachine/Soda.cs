using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpVendingMachine
{
    class Soda : Beverage
    {
        private bool _isCaffeinated;
        private bool _isDiet;

        public Soda(string name, double price, string expiryDate, double litres, string flavor, bool isCaffeinated, bool isDiet)
            : base(name, price, expiryDate, litres, flavor)
        {
            this._isCaffeinated = isCaffeinated;
            this._isDiet = isDiet;
        }

        public void SodaDetails()
        {
            BeverageDetails();
            Console.WriteLine("Is the {0} caffeinated? {1}", GetName(), this._isCaffeinated);
            Console.WriteLine("Is the {0} diet? {1} ", GetName(), this._isDiet);
        }
    }
}
