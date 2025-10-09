using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryList
{
    class Grocery
    {
        private Milk my_milk;
        private Bread my_bread;
        private Eggs my_eggs;

        public Grocery(Milk milk, Bread bread, Eggs eggs)
        {
            my_milk = milk;
            my_bread = bread;
            my_eggs = eggs;
        }
        public double Expense()
        {
            return my_milk.TotalPrice() + my_bread.TotalPrice() + my_eggs.TotalPrice();
        }
        
        public override string ToString()
        {
            string obj = "Grocery List\n";
            obj += "\nItem \tUnit Price\tQuantity";
            obj += "\nMilk\t" + my_milk;
            obj += "\nBread\t" + my_bread;
            obj += "\nEggs\t" + my_eggs;
            obj += "\n Total Expense is         $" + Expense();

            return obj;
        }
        ~Grocery() { }
    }
}
