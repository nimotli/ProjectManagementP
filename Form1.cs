using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_software_Prototype
{

    public partial class Form1 : Form
    {
        bool menuShowen = false;
        Color buttonDefaultColor = Color.FromArgb(34, 52, 70);
        Color buttonSelectedColor = Color.FromArgb(52, 152, 219);
        private bool mouseDown=false;
        private Point lastLocation;


        public Form1()
        {
            InitializeComponent();
            hideMenu.Interval = 1;
            showMenu.Interval = 1;
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reducebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void HeaderPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void HeaderPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void DashBoardbtn_Click(object sender, EventArgs e)
        {
            changeSelectedButton(0);

        }

        private void commandbtn_Click(object sender, EventArgs e)
        {
            changeSelectedButton(1);
        }
        private void productbtn_Click(object sender, EventArgs e)
        {
            changeSelectedButton(2);
        }

        private void clientbtn_Click(object sender, EventArgs e)
        {
            changeSelectedButton(3);
        }

        private void providerbtn_Click(object sender, EventArgs e)
        {
            changeSelectedButton(4);
        }
        private void Dashpic_Click(object sender, EventArgs e)
        {
            changeSelectedButton(0);
        }

        private void Compic_Click(object sender, EventArgs e)
        {
            changeSelectedButton(1);
        }

        private void propic_Click(object sender, EventArgs e)
        {
            changeSelectedButton(2);
        }

        private void clipic_Click(object sender, EventArgs e)
        {
            changeSelectedButton(3);
        }

        private void provpic_Click(object sender, EventArgs e)
        {
            changeSelectedButton(4);
        }
        public void changeSelectedButton(int index)
        {
            if (index==0)
            {
                DashBoardbtn.BackColor = buttonSelectedColor;
                commandbtn.BackColor = buttonDefaultColor;
                productbtn.BackColor = buttonDefaultColor;
                clientbtn.BackColor = buttonDefaultColor;
                providerbtn.BackColor = buttonDefaultColor;

                Dashpic.BackColor = buttonSelectedColor;
                Compic.BackColor = buttonDefaultColor;
                propic.BackColor = buttonDefaultColor;
                clipic.BackColor = buttonDefaultColor;
                provpic.BackColor = buttonDefaultColor;
               
            }
            
            else if (index == 1)
            {
                DashBoardbtn.BackColor = buttonDefaultColor;
                commandbtn.BackColor = buttonSelectedColor;
                productbtn.BackColor = buttonDefaultColor;
                clientbtn.BackColor = buttonDefaultColor;
                providerbtn.BackColor = buttonDefaultColor;

                Dashpic.BackColor = buttonDefaultColor;
                Compic.BackColor = buttonSelectedColor;
                propic.BackColor = buttonDefaultColor;
                clipic.BackColor = buttonDefaultColor;
                provpic.BackColor = buttonDefaultColor;
            }
            else if (index == 2)
            {
                DashBoardbtn.BackColor = buttonDefaultColor;
                commandbtn.BackColor = buttonDefaultColor;
                productbtn.BackColor = buttonSelectedColor;
                clientbtn.BackColor = buttonDefaultColor;
                providerbtn.BackColor = buttonDefaultColor;

                Dashpic.BackColor = buttonDefaultColor;
                Compic.BackColor = buttonDefaultColor;
                propic.BackColor = buttonSelectedColor;
                clipic.BackColor = buttonDefaultColor;
                provpic.BackColor = buttonDefaultColor;
            }
            else if (index == 3)
            {
                DashBoardbtn.BackColor = buttonDefaultColor;
                commandbtn.BackColor = buttonDefaultColor;
                productbtn.BackColor = buttonDefaultColor;
                clientbtn.BackColor = buttonSelectedColor;
                providerbtn.BackColor = buttonDefaultColor;

                Dashpic.BackColor = buttonDefaultColor;
                Compic.BackColor = buttonDefaultColor;
                propic.BackColor = buttonDefaultColor;
                clipic.BackColor = buttonSelectedColor;
                provpic.BackColor = buttonDefaultColor;
            }
            else if (index == 4)
            {
                DashBoardbtn.BackColor = buttonDefaultColor;
                commandbtn.BackColor = buttonDefaultColor;
                productbtn.BackColor = buttonDefaultColor;
                clientbtn.BackColor = buttonDefaultColor;
                providerbtn.BackColor = buttonSelectedColor;

                Dashpic.BackColor = buttonDefaultColor;
                Compic.BackColor = buttonDefaultColor;
                propic.BackColor = buttonDefaultColor;
                clipic.BackColor = buttonDefaultColor;
                provpic.BackColor = buttonSelectedColor;
            }
        }

        private void showHideMenubtn_Click(object sender, EventArgs e)
        {
            if(menuShowen)
            {
                hideMenu.Start();
                menuShowen = false;
                showHideMenubtn.Enabled = false;
            }
            else
            {
                showMenu.Start();
                menuShowen = true;
                showHideMenubtn.Enabled = false;
            }
        }

        private void showMenu_Tick(object sender, EventArgs e)
        {
            
            Size newSize=new Size();
            if (MenuPanel.Size.Width<=185)
            {
                newSize.Height = MenuPanel.Size.Height;
                newSize.Width = MenuPanel.Size.Width + 5;
                MenuPanel.Size = newSize;
            }
            else
            {
                if (MenuPanel.Size.Width > 185)
                {
                    newSize.Width = 185;
                    MenuPanel.Size = newSize;
                }
                showHideMenubtn.Enabled = true;
                showMenu.Stop();
            }
        }

        private void hideMenu_Tick(object sender, EventArgs e)
        {
            
            Size newSize = new Size();
            if (MenuPanel.Size.Width >= 50)
            {
                newSize.Height = MenuPanel.Size.Height;
                newSize.Width = MenuPanel.Size.Width - 5;
                MenuPanel.Size = newSize;
            }
            else
            {
                if (MenuPanel.Size.Width < 50)
                {
                    newSize.Width = 50;
                    MenuPanel.Size = newSize;
                }
                showHideMenubtn.Enabled = true;
                hideMenu.Stop();
            }
        }
    }
}
