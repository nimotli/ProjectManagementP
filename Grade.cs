using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_software_Prototype
{
    class Grade
    {
        private string idGrade;
        private string libelle;
        private int rank;


        public Grade(string idGrade,string libelle,int rank)
        {
            this.idGrade = idGrade;
            this.libelle = libelle;
            this.rank = rank;
        }
        public string IdGrade
        {
            get
            {
                return idGrade;
            }

            set
            {
                idGrade = value;
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

        public int Rank
        {
            get
            {
                return rank;
            }

            set
            {
                rank = value;
            }
        }
    }
}
