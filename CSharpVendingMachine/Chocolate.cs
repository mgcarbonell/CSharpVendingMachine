using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpVendingMachine
{
    class Chocolate : Product
    {
        private bool _isMilkChocolate;
        private double _grams;

        public Chocolate(string name, double price, string expiryDate, double grams, bool isMilkChocolate)
            : base(name, price, expiryDate)
        {
            this._grams = grams;
            this._isMilkChocolate = isMilkChocolate;
        }

        public void ChocolateDetails()
        {
            PrintDetails();
            Console.WriteLine("Is the {0} milk chocolate? {1}", GetName(), this._isMilkChocolate);
            Console.WriteLine("The {0} weighs: {1}g", GetName(), this._grams);
        }
    }
}
