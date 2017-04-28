using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_software_Prototype
{
    public partial class ClientUserControl : UserControl
    {
        private static ClientUserControl _instance;

        public ClientUserControl()
        {
            InitializeComponent();
        }

        public static ClientUserControl Instance
        {
            get
            {
                if (_instance==null)
                {
                    _instance = new ClientUserControl();
                }
                return _instance;
            }

            

        }

        private void ClientUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
