using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_software_Prototype
{
    class Client :Person
    {
        private string idClient;
        private List<Project> clientProjects;

        public Client(string cne, string nom, string prenom, string adress, string email, string telNum,string idClient, List<Project> clientProjects)
            : base(cne, nom, prenom, adress, email, telNum)
        {
            this.idClient = idClient;
            this.clientProjects = clientProjects;
        }

        public string IdClient
        {
            get
            {
                return idClient;
            }

            set
            {
                idClient = value;
            }
        }

        internal List<Project> ClientProjects
        {
            get
            {
                return clientProjects;
            }

            set
            {
                clientProjects = value;
            }
        }
    }
}
