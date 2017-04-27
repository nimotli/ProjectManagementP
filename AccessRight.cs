using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_software_Prototype
{
    class AccessRight
    {
        private string id;
        private string libelle;

        public AccessRight(string id,string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
    }
}
