using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpVendingMachine
{
    class MoneyCollector
    {
        public int moneyCollected;
        public int productPrice;
        public int insertedMoney;

        public MoneyCollector()
        {
            this.moneyCollected = 0;
            this.productPrice = 2;
            this.insertedMoney = 0;
        }

        public void AddMoney(int money)
        {
            this.insertedMoney = money;
            if (this.insertedMoney >= 0)
            {
                Console.WriteLine("You inserted {0}$", this.insertedMoney);
                this.Change();
            }
            else Console.WriteLine("Invalid Transaction");

            this.insertedMoney = 0;
        }

        public void Change()
        {
            if (this.insertedMoney >= this.productPrice)
            {
                int change = this.insertedMoney - this.productPrice;
                this.moneyCollected += this.productPrice;
                Console.WriteLine("Your change is: {0}$", change);
            }
            else
            {
                Console.WriteLine("Insufficient money inserted.");
                Console.WriteLine("Your change is: {0}$", this.insertedMoney);
            }
        }

        public int GetMoneyCollected()
        {
            return this.moneyCollected;
        }
    }
}
