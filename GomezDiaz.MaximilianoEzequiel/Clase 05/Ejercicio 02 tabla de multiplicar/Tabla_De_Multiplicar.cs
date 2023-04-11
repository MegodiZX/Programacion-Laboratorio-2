using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_02_tabla_de_multiplicar
{
    public partial class fmrPrincipal : Form
    {
        public fmrPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

            //esto no lo tenia que atrapar
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==Convert.ToChar(Keys.Enter))
            {
                int numero= int.Parse(txtNumero.Text);
                for(int i=1;i<11;i++)
                {

                    lstTabla.Items.Add(item: $"{numero} x {i} = {numero * i}");
                }
            }
            
        }

        private void lstTabla_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "";
            lstTabla.Items.Clear();
        }

        private void fmrPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Esta seguro que desea salir del programa?", "ATENCION:", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if(respuesta == DialogResult.No)
            {
                e.Cancel = true;
            }

        }
    }
}
