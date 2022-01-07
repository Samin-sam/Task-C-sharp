using System;
using System.Collections.Generic;
using System.Text;


namespace NewProductOne
{
    struct ExpiryDate
    {
        private string day;
        private byte month;
        private ushort year;

        public ExpiryDate(string day, byte month, ushort year)
        {
            this.day = day;
            this.month = month;
            this.year = year;

        }
        public void showDate()
        {
            Console.WriteLine("day :{0}", this.day);
            Console.WriteLine("month :{0}", this.month);
            Console.WriteLine("year :{0}", this.year);

        }

    }

    internal class CannedFood : Product
    {
        private ExpiryDate expirydate;

      internal override ushort Id
        {
            
            set { base.Id = value; }
        }
      
        internal override double Quantity
        {
            set { base.Quantity = value ; }
        }

        internal override double Price 
        { 
            set { base.Price = value*0.05; }
        }


        internal ExpiryDate ExDate
        {
            get { return this.expirydate; }
            set { this.expirydate = value; }
        }
        internal CannedFood(ushort id, double quantity, double price, ProductionDate date, string manufacturerName,ExpiryDate expirydate):base(id,quantity,price,date,manufacturerName)
        {
            this.ExDate = expirydate;
        }

        internal override void ShowInfo()
        {
            base.ShowInfo();
            this.ExDate.showDate();
        }
    }
}
