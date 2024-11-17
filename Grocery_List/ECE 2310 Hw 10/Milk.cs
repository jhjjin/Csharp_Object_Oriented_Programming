using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECE_2310_Hw_10
{
    class Milk
    {
        private double unitPrice;
        private int quantity;

        public Milk()
        {
            unitPrice = 0.0;
            quantity = 0;
        }

        public Milk(double price, int qty)
        {
            unitPrice = price;
            quantity = qty;
        }

        public double UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public double TotalPrice()
        {
            return unitPrice * quantity;
        }

        public override string ToString()
        {
            return "Milk    $" + unitPrice + quantity;
        }
        ~Milk() { }
    }
}
