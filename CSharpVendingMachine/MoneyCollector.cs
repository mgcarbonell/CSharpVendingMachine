using System;


namespace CSharpVendingMachine
{
    class MoneyCollector
    {
        private int _moneyCollected;
        private int _productPrice;
        private int _insertedMoney;

        public MoneyCollector()
        {
            this._moneyCollected = 0;
            this._productPrice = 2;
            this._insertedMoney = 0;
        }

        public void AddMoney(int money)
        {
            this._insertedMoney = money;
            if (this._insertedMoney >= 0)
            {
                Console.WriteLine("You inserted {0}$", this._insertedMoney);
                this.Change();
            }
            else Console.WriteLine("Invalid Transaction");

            this._insertedMoney = 0;
        }

        public void Change()
        {
            if (this._insertedMoney >= this._productPrice)
            {
                int change = this._insertedMoney - this._productPrice;
                this._moneyCollected += this._productPrice;
                Console.WriteLine("Your change is: {0}$", change);
            }
            else
            {
                Console.WriteLine("Insufficient money inserted.");
                Console.WriteLine("Your change is: {0}$", this._insertedMoney);
            }
        }

        public int GetMoneyCollected()
        {
            return this._moneyCollected;
        }
    }
}
