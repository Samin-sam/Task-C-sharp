using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManagemeentSystem
{
    internal struct JoiningDate
    {
        private byte day;
        private string month;
        private ushort year;

       internal JoiningDate(byte day, string month, ushort year)
        {
            if (day >= 1 && day <= 31)
            {
                this.day = day;
                this.month = month;
                this.year = year;
            }
            else
            {
                this.day = 1;
                this.month = "January";
                this.year = 1980;
            }
        }
       

        internal void ShowDate()
        {
            Console.WriteLine("Opening Date : {0}/{1}/{2}", this.day, this.month, this.year);
        }
    }

    internal struct OurAddress
    {
        private byte apartmentNumber;
        private byte roadNumber;
        private string district ;
        private string country;

        public OurAddress(byte apartmentNumber, byte roadNumber, string district, string country)
        {
            this.apartmentNumber = apartmentNumber;
            this.roadNumber = roadNumber;
            this.district = district;
            this.country = country;

        }
        public void showaddress()
        {
            Console.WriteLine(" My Address :{0},{1},{2},{3}", this.apartmentNumber,this.roadNumber,this.district,this.country);
           /*
            * Console.WriteLine(" Apartment Number :{0}", this.apartmentNumber);
            Console.WriteLine(" Road Number :{0}", this.roadNumber);
            Console.WriteLine(" District :{0}", this.district);
            Console.WriteLine(" Country :{0}", this.country);
           */
        }

    }


    internal class Account
    {
        private string name;
        private static int serialNo = 0;
        private string id;
        private JoiningDate openingDate;
        private OurAddress address;
        private double balance;

        internal string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        internal virtual string Id
        {
            get { return this.id; }
            set
            {
                this.id = "A" + value;
            }
        }

      
        internal JoiningDate OpeningDate
        {
            get { return this.openingDate; }
            set { this.openingDate = value; }
        }

        internal OurAddress Address
        { 
            get { return this.address; }
            set { this.address = value; }
        }
        internal double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        internal Account(string name, JoiningDate openingDate, OurAddress address, double balance)
        {
            this.Name = name;
            this.Id = (++serialNo).ToString();
            this.OpeningDate = openingDate;
            this.Address = address;
            this.Balance = balance;
        }

        internal virtual void ShowInfo()
        {
            Console.WriteLine("Information: ");
            Console.WriteLine("Name: {0}", this.Name);
            Console.WriteLine("ID: {0}", this.Id);
            this.OpeningDate.ShowDate();
            this.Address.showaddress();
            Console.WriteLine("Balance: {0}", this.Balance);
        }


        internal virtual void Deposit(double amount)
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
                Console.WriteLine("Can Not Deposit");
            }
        }
        internal virtual void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Console.WriteLine("Previous Balance: {0}" ,this.Balance);
                Console.WriteLine("Withdraw Amount: {0}	" ,amount);
               this.Balance = this.Balance - amount;

                Console.WriteLine("Current Balance: {0}" ,this.Balance);
            }
            else
            {
                Console.WriteLine("Can Not Withdraw");
            }
        }
        internal virtual void Transfer(Account x, Account y, double amount)
        {
            if (amount > 0 && amount <= this.Balance)
            {
                Console.WriteLine("Previous Balance: {0}", this.Balance);
                Console.WriteLine("Transfer Amount:	{0}", amount);
                x.Balance = x.Balance - amount;
                y.Balance = y.Balance + amount;

                Console.WriteLine("Current Balance:	{0}",this.Balance);
            }
            else
            {
                Console.WriteLine("Can Not Transfer");
            }
        }





    }
}
