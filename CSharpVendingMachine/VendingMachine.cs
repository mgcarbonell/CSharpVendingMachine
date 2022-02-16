using System;
using System.Collections.Generic;

namespace CSharpVendingMachine
{
    class VendingMachine

    {
        public const string Manufacturer = "MGC Inc.";

        private int _count = 0;
        private decimal _moneyCollected;

        private static int _capacity = 100;
        
        public bool Permission = true;

        public int Count 
        { 
            get
            {
                return _count;
            }

            set
            {
                if (value >= 0 && value <= _capacity)
                {
                    _count = value;
                }
            }
        
        }

        void Display()
        {
            Console.WriteLine("This.Display  - hah-hah, class joke - this is the Display method.");
        }
        void DispenseProducts()
        {
            Console.WriteLine("You have accessed the DispenseProducts method.");
        }

        void Refill()
        {
            Console.WriteLine("This is the refill method, I will refill count.");
        }

        public string GetManufacturer()
        {
            return Manufacturer;
        }

        public void CountMoney()
        {
            if(this.Permission)
            {
                Console.WriteLine("We have collected ${0} today", this._moneyCollected);
            }
            else
            {
                int i = 0;
                while (i < 10)
                {
                    Console.WriteLine("YOU DIDN'T SAY THE MAGIC WORD!");
                    i++;
                }
            }
        }
    }
}
