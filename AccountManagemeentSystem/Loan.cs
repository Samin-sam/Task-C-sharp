using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManagemeentSystem
{
    internal class Loan : Account
    {
        private static int serialNo = 0;
        internal override string Id
        {

            set { base.Id = "L-" + value; }
        }

        internal Loan(string name, JoiningDate openingDate, OurAddress address, double balance) : base(name, openingDate, address, balance)
        {
            this.Id = (++serialNo).ToString();
        }

        internal override void ShowInfo()
        {
            base.ShowInfo();

        }

        internal override void Deposit(double amount)
        {
            if (amount > 0)
            {
                Console.WriteLine("Previous Balance: {0}", this.Balance);
                Console.WriteLine("Deposit Amount: {0} ", amount);
                this.Balance = this.Balance + amount;

                Console.WriteLine("Current Balance: {0} ", this.Balance);
            }
            else
            {
                Console.WriteLine("Can Not Deposit{0}");
            }
        }
        internal override void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Console.WriteLine("Previous Balance: {0}	", this.Balance);
                Console.WriteLine("Withdraw Amount: {0}	", amount);
                this.Balance = this.Balance - amount -50;

                Console.WriteLine("Current Balance: {0}	", this.Balance);
            }
            else
            {
                Console.WriteLine("Can Not Withdraw");
            }
        }
        internal override void Transfer(Account x, Account y, double amount)
        {
            if (amount > 0 && amount <= this.Balance)
            {
                Console.WriteLine("Previous Balance:{0}", this.Balance);
                Console.WriteLine("Transfer Amount:{0}	", amount);
                x.Balance = x.Balance - amount;
                y.Balance = y.Balance + amount;

                Console.WriteLine("Current Balance:	{0}", this.Balance);
            }
            else
            {
                Console.WriteLine("Can Not Transfer");
            }
        }


    }
}
