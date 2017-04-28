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
    public partial class DashBoardUserControl : UserControl
    {
        private static DashBoardUserControl _instance;


        public DashBoardUserControl()
        {
            InitializeComponent();
        }

        public static DashBoardUserControl Instance
        {
            get
            {
                if (_instance==null)
                {
                    _instance = new DashBoardUserControl();
                }
                return _instance;
            }
        }

        private void DashBoardUserControl_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
