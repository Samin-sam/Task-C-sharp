using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewProductOne
{
    class Program
    {
        static void Main(string[] args)
        {
            ExpiryDate date1 = new ExpiryDate("monday", 10, 2020);
            ProductionDate date2 = new ProductionDate("sunday", 11, 2020);
            CannedFood productOne = new CannedFood(150, 1.5, 4500, date2, "zin1", date1);
            Laptop productTwo = new Laptop(25, 10, 3500, date2, "zing", 4, 6, 8);
            productOne.ShowInfo();
            productTwo.ShowInfo();
        }

    } 
}
