﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Greenaid_IDE_Indigo
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
            if (Form1.indigoSettings[1] == "theme=dark")
            {
                this.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);


                this.pictureBox1.Image = global::Greenaid_IDE_Indigo.Properties.Resources.logoidnidniwhite;

                this.label1.ForeColor = System.Drawing.Color.FromArgb(245, 245, 245);
                this.label2.ForeColor = System.Drawing.Color.FromArgb(245, 245, 245);
            }
            if (Form1.indigoSettings[3] == "lang=es")
            {
                label2.Text = "Por: GreenSoupDeveloper";


            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
