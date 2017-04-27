using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_software_Prototype
{
    class Person
    {
        private string cne;
        private string nom;
        private string prenom;
        private string adress;
        private string email;
        private string telNum;


        public Person (string cne, string nom , string prenom , string adress , string email , string telNum)
        {
            this.cne = cne;
            this.nom = nom;
            this.prenom = prenom;
            this.adress = adress;
            this.email = email;
            this.telNum = telNum;
        }
        public string Cne
        {
            get
            {
                return cne;
            }

            set
            {
                cne = value;
            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
            }
        }

        public string Adress
        {
            get
            {
                return adress;
            }

            set
            {
                adress = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string TelNum
        {
            get
            {
                return telNum;
            }

            set
            {
                telNum = value;
            }
        }
    }
}
