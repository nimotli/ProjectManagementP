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
    public partial class ProviderUserControl : UserControl
    {

        private static ProviderUserControl _instance;

        public ProviderUserControl()
        {
            InitializeComponent();
        }

        public static ProviderUserControl Instance
        {
            get
            {
                if (_instance==null)
                {
                    _instance = new ProviderUserControl();
                }
                return _instance;
            }

        }

        private void ProviderUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
