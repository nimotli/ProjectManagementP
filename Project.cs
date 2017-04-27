using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_software_Prototype
{
    public enum Projectstatus {Complete,Ongoing,Canceled,OnHold }
    public enum ProjectSize {Small,Medium,Big}
    class Project
    {
        private string number;
        private string name;
        private ProjectType projectType;
        private Projectstatus projectStatus;
        private Client client;
        private ProjectSize projectSize;
        private float estimatedCost;
        private float projectPayement;
        private float estimadedEarning;
        private float actualCost;
        private float actualEarning;
        private DateTime startingDate;
        private List<Ressource> requirededRessources;

        public Project(string number,string name,ProjectType projectType,Projectstatus projectStatus,Client client,
            ProjectSize projectSize,float estimatedCost,float projectPayement,float estimadedEarning,float actualCost,float actualEarning,
            DateTime startingDate, List<Ressource> requirededRessources)
        {
            this.number = number;
            this.name = name;
            this.projectType = projectType;
            this.projectStatus = projectStatus;
            this.client = client;
            this.projectSize = projectSize;
            this.estimatedCost = estimatedCost;
            this.projectPayement = projectPayement;
            this.estimadedEarning = estimadedEarning;
            this.ActualCost = actualCost;
            this.ActualEarning = actualEarning;
            this.startingDate = startingDate;
            this.requirededRessources = requirededRessources;

        }

        public string Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        internal ProjectType ProjectType
        {
            get
            {
                return projectType;
            }

            set
            {
                projectType = value;
            }
        }

        public Projectstatus ProjectStatus
        {
            get
            {
                return projectStatus;
            }

            set
            {
                projectStatus = value;
            }
        }

        internal Client Client
        {
            get
            {
                return client;
            }

            set
            {
                client = value;
            }
        }

        public ProjectSize ProjectSize
        {
            get
            {
                return projectSize;
            }

            set
            {
                projectSize = value;
            }
        }

        public float EstimatedCost
        {
            get
            {
                return estimatedCost;
            }

            set
            {
                estimatedCost = value;
            }
        }

        public float ProjectPayement
        {
            get
            {
                return projectPayement;
            }

            set
            {
                projectPayement = value;
            }
        }

        public float EstimadedEarning
        {
            get
            {
                return estimadedEarning;
            }

            set
            {
                estimadedEarning = value;
            }
        }

        public DateTime StartingDate
        {
            get
            {
                return startingDate;
            }

            set
            {
                startingDate = value;
            }
        }

        internal List<Ressource> RequirededRessources
        {
            get
            {
                return requirededRessources;
            }

            set
            {
                requirededRessources = value;
            }
        }

        public float ActualEarning
        {
            get
            {
                return actualEarning;
            }

            set
            {
                actualEarning = value;
            }
        }

        public float ActualCost
        {
            get
            {
                return actualCost;
            }

            set
            {
                actualCost = value;
            }
        }
    }
}
