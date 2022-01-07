using System;
using System.Collections.Generic;
using System.Text;

namespace CodeOne
{
    class Product
    {
        private ushort id;
        private string name;
        private ulong price;

        public ushort Getid()
        {
            return this.id;
        }
        public String Getname()
        {
            return this.name;
        }

        public ulong Getprice()
        {
            return this.price;
        }

        public void setid(ushort id)
        {
            this.id = id;
        }
        public void setname(string name)
        {
            this.name = name;
        }
        public void setprice(ulong price)
        {
            this.price = price;
        }
       
        public Product()
        {

        }
        public Product(ushort id, string name, ulong price)
        {
            this.setid(id);
            this.setname(name);
            this.setprice(price);
        }

        public void ShowProductInfo()
        {
            Console.WriteLine("Product Id:{0} ", this.id);
            Console.WriteLine("Product Name:{0} ", this.name);
            Console.WriteLine("Product price:{0} ", this.price);
        }
    }
}
