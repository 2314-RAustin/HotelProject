﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event Windows close --R.Austin--
        /// </summary>
        /// <param EventYes="Close"></param>
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Seguro de cerrar la aplicacion","Cierre de aplicacion",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Event Window Minimized --R.Austin--
        /// </summary>
        /// <param ClickEvent="Minimezed"></param>
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


    }
}
