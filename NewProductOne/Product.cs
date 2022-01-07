using System;
using System.Collections.Generic;
using System.Text;

namespace NewProductOne
{
    struct ProductionDate
    {
        private string day;
        private byte month;
        private ushort year;

        public ProductionDate(string day, byte month, ushort year)
        {
            this.day = day;
            this.month = month;
            this.year = year;

        }
        public void showdate()
        {
            Console.WriteLine("day :{0}", this.day);
            Console.WriteLine("month :{0}", this.month);
            Console.WriteLine("year :{0}", this.year);

        }

    }

    internal class Product
    {
        private ushort id;
        private double quantity;
        private double price;
        private ProductionDate date;
        private string manufacturerName;


        internal virtual ushort Id
        {
            get { return this.id; }
            set
            {
                this.id = value;
            }
        }

        internal virtual double Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }

        internal virtual double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        internal ProductionDate Date
        {
            get { return this.date; }
            set { this.date = value; }
        }
        internal virtual string ManufacturerName
        {
            get { return this.manufacturerName; }
            set { this.manufacturerName = value; }
        }
      internal Product(ushort id, double quantity, double price, ProductionDate date, string manufacturerName)
        {
            this.Id = id;
            this.Quantity = quantity;
            this.Price = price;
            this.Date = date;
            this.ManufacturerName = manufacturerName;
        }
        internal virtual void ShowInfo()
        {
            Console.WriteLine("Information: ");
            Console.WriteLine("ID: {0}", this.Id);
            Console.WriteLine("Quantity: {0}", this.Quantity);
            Console.WriteLine("Price: {0}", this.Price);
            this.Date.showdate();
            Console.WriteLine("ManufacturerName: {0}", this.ManufacturerName);
        }

    }
}
