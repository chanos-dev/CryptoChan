﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoChan
{
    public partial class FormManagementS : Form
    { 

        public FormManagementS()
        {
            InitializeComponent(); 
        } 

        private void pictureBox_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        } 

        private void FormManagementS_Load(object sender, EventArgs e)
        {
            int x = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            int y = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
            this.Location = new Point(x, y); 
        }
    }
}
