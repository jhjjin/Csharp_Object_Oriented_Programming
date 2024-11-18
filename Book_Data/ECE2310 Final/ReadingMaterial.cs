using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECE2310_Final
{
   class ReadingMaterial
    {
        private string title;
        private double price;

        public ReadingMaterial()
        {
            title = "Unknwon";
            price = 0.0;
        }
        
        public ReadingMaterial(string tt, double pc)
        {
            title = tt;
            price = pc;

        }
        public string Title
        {
           get { return title; }
            set { title = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public void Read()
        {
            Console.WriteLine("Read a book title: {0}", title);
        }
        public virtual void ToString()
        {
            Console.WriteLine();
        }
        ~ReadingMaterial() {}
    }
}
