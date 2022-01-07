using System;

namespace CodeOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Product productOne = new Product();
            productOne.setid = 1000;
            productOne.setname = "laptop";
            productOne.setprice = 50000;

            productone.ShowProductInfo();

            Product productTwo = new Product(1000, "desktop", 40000);
            productTwo.ShowProductInfo;

        }
     
    }
}
