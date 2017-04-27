using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_software_Prototype
{
    class ProjectType
    {
        private string idType;
        private string libelle;

        public ProjectType(string idType,string libelle)
        {
            this.IdType = idType;
            this.Libelle = libelle;
        }

        public string IdType
        {
            get
            {
                return idType;
            }

            set
            {
                idType = value;
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
    }
}
