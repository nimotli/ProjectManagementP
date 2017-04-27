using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_software_Prototype
{
    class Employe:Person
    {
        private string idEmploye;
        private DateTime dateEmbauch;
        private float salaireHoraire;
        private Grade grade;


        public Employe(string cne, string nom, string prenom, string adress, string email, string telNum, string idEmploye, DateTime dateEmbauch, float salaireHoraire, Grade grade)
            : base(cne, nom, prenom, adress, email, telNum)
        {
            this.IdEmploye = idEmploye;
            this.DateEmbauch = dateEmbauch;
            this.SalaireHoraire = salaireHoraire;
            this.Grade = grade;
        }


        public string IdEmploye
        {
            get
            {
                return idEmploye;
            }

            set
            {
                idEmploye = value;
            }
        }

        public DateTime DateEmbauch
        {
            get
            {
                return dateEmbauch;
            }

            set
            {
                dateEmbauch = value;
            }
        }

        public float SalaireHoraire
        {
            get
            {
                return salaireHoraire;
            }

            set
            {
                salaireHoraire = value;
            }
        }

        internal Grade Grade
        {
            get
            {
                return grade;
            }

            set
            {
                grade = value;
            }
        }

        
    }
}
