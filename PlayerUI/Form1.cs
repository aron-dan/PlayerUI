﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            panelMediaSubmenu.Visible = false;
            panelPlaylistSubmenu.Visible = false;
            panelToolsSubmenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelMediaSubmenu.Visible == true)
                panelMediaSubmenu.Visible = false;
            if (panelPlaylistSubmenu.Visible == true)
                panelPlaylistSubmenu.Visible = false;
            if (panelToolsSubmenu.Visible == true)
                panelToolsSubmenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        #region MediaSubmenu
        private void buttonMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubmenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
            //put your code here, like an link or anything there you wanna
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //put your code here, like an link or anything there you wanna
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //put your code here, like an link or anything there you wanna
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //put your code here, like an link or anything there you wanna
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //put your code here, like an link or anything there you wanna
            hideSubMenu();
        }
        #endregion

        #region PlaylistSubmenu
        private void buttonPlaylistManagement_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubmenu);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //put your code here, like an link or anything there you wanna
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //put your code here, like an link or anything there you wanna
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //put your code here, like an link or anything there you wanna
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //put your code here, like an link or anything there you wanna
            hideSubMenu();
        }
        #endregion

        #region ToolsSubmenu
        private void buttonTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolsSubmenu);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //put your code here, like an link or anything there you wanna
            hideSubMenu();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //put your code here, like an link or anything there you wanna
            hideSubMenu();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //put your code here, like an link or anything there you wanna
            hideSubMenu();
        }
        #endregion

        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonEqualizer_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
        }
    }
}
