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

        public VendingMachine()
        {
            _onOff = false;
            _capacity = 100;
            _count = 10;
            _moneyCollected = 0;
        }
        public VendingMachine(bool onOff, int count, int moneyCollected)
        {
            _onOff = onOff;
            _capacity = 100;
            if (moneyCollected >= 0)
            {
                _moneyCollected = moneyCollected;
            }
            else
            {
               Console.WriteLine("Invalid monetary value, please enter a positive numeric value.");
            }

            if (count >= 0 && count <= 100)
            {
                _count = count;
            }
            else
            {
                Console.WriteLine("Invalid count value, please enter a numeric value between 0 and 100.");
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
