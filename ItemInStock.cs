using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_software_Prototype
{
    class ItemInStock
    {
        private Ressource ressource;
        private int quantity;

        public ItemInStock(Ressource ressource, int quantity)
        {
            this.Ressource = ressource;
            this.Quantity = quantity;
        }
        
        internal Ressource Ressource
        {
            get
            {
                return ressource;
            }

            set
            {
                ressource = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        
    }
}
