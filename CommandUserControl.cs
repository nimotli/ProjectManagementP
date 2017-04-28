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
    public partial class CommandUserControl : UserControl
    {
        private static CommandUserControl _instance;

        public CommandUserControl()
        {
            InitializeComponent();
        }

        public static CommandUserControl Instance
        {
            get
            {
                if (_instance==null)
                {
                    _instance = new CommandUserControl();
                }
                return _instance;
            }
        }

        private void CommandUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
