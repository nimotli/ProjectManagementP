using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_software_Prototype
{
    class Account
    {
        private string userName;
        private string passWord;
        private string idEmploye;
        private AccessRight accessRight;

        public Account(string userName, string passWord, string idEmploye,AccessRight accessRight)
        {
            this.userName = userName;
            this.passWord = passWord;
            this.idEmploye = idEmploye;
            this.accessRight = accessRight;
        }
        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public string PassWord
        {
            get
            {
                return passWord;
            }

            set
            {
                passWord = value;
            }
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

        internal AccessRight AccessRight
        {
            get
            {
                return accessRight;
            }

            set
            {
                accessRight = value;
            }
        }
    }
}
