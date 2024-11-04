using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714230059
{
    internal abstract class Product_714230059
    {
        //protected string myType = "Book";
        private string myType;
        private string myTitle;


        public Product_714230059()
        {
        }

        public string GetMyType()
        {
            return myType;
        }

        public Product_714230059(string type, string title)
        {
            myType = type;
            myTitle = title;
        }

        public string MyType
        {
            get
            { return myType; }
            set
            { myType = value; }
        }

        public string MyTitle
        {
            get { return myTitle; }
            set { MyTitle = value; }
        }

        public abstract void DisplayInfo();
    }
}