using System;
using System.Collections.Generic;

namespace CSharpVendingMachine
{
    class VendingMachine

    {
        private bool _onOff;
        private int _count;
        private int _capacity;
        private int _moneyCollected;

        public const string Manufacturer = "MGC Inc.";
        
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

        public void PrintFields()
        {
            Console.WriteLine("Is the machine turned on? {0}", _onOff);
            Console.WriteLine("The count of products is: {0}", _count);
            Console.WriteLine("The capacity of machine is: {0}", _capacity);
            Console.WriteLine("The total money collected till now is: {0}", _moneyCollected);
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

     
    }
}
