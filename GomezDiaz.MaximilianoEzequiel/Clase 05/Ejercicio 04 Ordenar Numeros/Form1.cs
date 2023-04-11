using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_04_Ordenar_Numeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach(Control item in groupBox1.Controls)// no funciona solo con Controls por alguna razon
            {
                if (item is TextBox)
                {
                    item.Text = "";
                    //MessageBox.Show("entro");
                }
            }
            foreach(Control item in groupBox2.Controls)
            {
                if(item is RadioButton)
                {
                    rbtnAscendente.Checked = false;
                    rbtnDescendiente.Checked = false;

                }
                
            }
            foreach(Control item in groupBox3.Controls)
            {
                if (item is ListBox)
                {
                    lstNumeros.Items.Clear();
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            lstNumeros.Items.Add(item: $"{int.Parse(txtNumero.Text)}");
            txtNumero.Text = "";
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if(rbtnAscendente.Checked == true)
            {
                //orden ascendente
            }else
            {
                if(rbtnDescendiente.Checked == true)
                {
                    //ordenar descendiente
                }
            }
        }
    }
}
