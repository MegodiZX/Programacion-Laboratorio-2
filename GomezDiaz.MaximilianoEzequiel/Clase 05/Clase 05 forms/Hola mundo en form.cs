﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_05_forms
{
    public partial class FrmSaludo : Form
    {
        public FrmSaludo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblSaludo.Visible = true;
        }

        private void Frm_Load(object sender, EventArgs e)
        {
            this.Text = "Saludos Desde un form";//esto hace lo mismo que llamarlo asi pero desde codigo

            lblSaludo.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
