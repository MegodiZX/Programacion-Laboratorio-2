using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_03_Descuento_por_compra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            float numero = float.Parse(txtNumeroIngresado.Text);
            float descuento = 0;
            if(numero>5000)
            {
                descuento = numero * 20 / 100;
                numero = numero - descuento;

            }else
            {
                if(numero>2999)
                {
                    descuento = numero * 10 / 100;
                    numero = numero - descuento;
                }
            }
            txtDescuento.Text = descuento.ToString();
            txtTotal.Text = numero.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Control item in groupBox1.Controls)
            {
                
                if (item is TextBox)
                {
                    item.Text = "";
                    //MessageBox.Show("entro");
                }
            }
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
