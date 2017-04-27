using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_software_Prototype
{
    class Ressource
    {
        private string idRessource;
        private string libelle;
        private float price;

        public Ressource(string idRessource,string libelle,float price)
        {
            this.IdRessource = idRessource;
            this.Libelle = libelle;
            this.Price = price;
        }

        public string IdRessource
        {
            get
            {
                return idRessource;
            }

            set
            {
                idRessource = value;
            }
        }

        public string Libelle
        {
            get
            {
                return libelle;
            }

            set
            {
                libelle = value;
            }
        }

        public float Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }
    }
}
