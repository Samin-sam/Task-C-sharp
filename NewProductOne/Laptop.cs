using System;
using System.Collections.Generic;
using System.Text;

namespace NewProductOne
{
    class Laptop : Product
    {
        private byte memorySize;
        private byte clockspeed;
        private int batteryLifetime;

        internal override ushort Id
        {

            set { base.Id = value; }
        }
        internal override double Quantity
        {
            set { base.Quantity =Convert.ToInt32(value); }
        }

        internal override double Price
        {
            set { base.Price = value * 0.10; }
        }

        internal byte MemorySize
        {
            get { return this.memorySize; }
            set { this.memorySize = value; }
        }
        internal byte ClockSpeed
        {
            get { return this.clockspeed; }
            set { this.clockspeed = value; }
        }
        internal int BatteryLifetime
        {
            get { return this.batteryLifetime; }
            set { this.batteryLifetime= value; }
        }


        internal Laptop(ushort id, double quantity, double price, ProductionDate date, string manufacturerName, byte memorySize, byte clockspeed, int batteryLifetime) : base(id, quantity, price, date, manufacturerName)
        {
            this.MemorySize = memorySize ;
            this.ClockSpeed = clockspeed;
            this.BatteryLifetime = batteryLifetime;
        }

        internal override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Memory Size: {0}", this.MemorySize);
            Console.WriteLine("Clock Speed: {0}", this.ClockSpeed);
            Console.WriteLine("Battery Lifetime: {0}", this.BatteryLifetime);
        }


    }
}
