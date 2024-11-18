using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ECE2310_Final
{
    class Magazine:ReadingMaterial
    {
        private string editInChief;

        public string EditorInChief
        {
            get { return editInChief; }
            set { editInChief = value; }
        }
        public void Subscribe()
        {
            Console.WriteLine("{0} editor-in-chief is: {1} and price {2}",Title, editInChief, Price);
        }
        public override void ToString()
        {
            Console.WriteLine("{0} editor-in-chief is : {1},  price: ${2}", Title, editInChief, Price);

        }

        ~Magazine() { }
    }
}
