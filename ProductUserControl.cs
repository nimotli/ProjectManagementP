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
    public partial class ProductUserControl : UserControl
    {
        private static ProductUserControl _instance;

        public ProductUserControl()
        {
            InitializeComponent();
        }

        public static ProductUserControl Instance
        {
            get
            {
                if (_instance==null)
                {
                    _instance = new ProductUserControl();
                }
                return _instance;
            }
        }

        private void ProductUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
