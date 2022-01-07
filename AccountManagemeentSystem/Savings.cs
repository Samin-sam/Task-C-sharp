using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManagemeentSystem
{
   internal class Savings : Account
    {
        private static int serialNo = 0;
        internal override string Id
        {
           
            set { base.Id = "S-" + value ; }
        }

        internal Savings(string name, JoiningDate openingDate, OurAddress address, double balance) : base(name, openingDate, address, balance)
        {
            this.Id = (++serialNo).ToString();
        }

        internal override void ShowInfo()
        {
            base.ShowInfo();
        }

        internal override void Deposit(double amount)
        {
            base.Deposit(amount);
        }
        internal override void Withdraw(double amount)
        {
            if (amount > 0 && amount <=2000)
            {
                Console.WriteLine("Previous Balance {0}:	", this.Balance);
                Console.WriteLine("Withdraw Amount {0}:	", amount);
                this.Balance = this.Balance - amount;

                Console.WriteLine("Current Balance {0}:	", this.Balance);
            }
            else
            {
                Console.WriteLine("Can Not Withdraw");
            }
        }
        internal override void Transfer(Account x, Account y, double amount)
        {
            base.Transfer(x,y,amount);
        }



    }
}
