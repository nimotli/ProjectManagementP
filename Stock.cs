using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_software_Prototype
{
    class Stock
    {
        private List<ItemInStock> itemsInStock;

        public Stock(List<ItemInStock> itemsInStock)
        {
            this.itemsInStock = itemsInStock;
        }
        internal List<ItemInStock> ItemsInStock
        {
            get
            {
                return itemsInStock;
            }

            set
            {
                itemsInStock = value;
            }
        }
    }
}
