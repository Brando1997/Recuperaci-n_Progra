using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serie_ll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdbsuma.Checked = true;
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double numero1, numero2, operacion;
            numero1 = double.Parse(txtnumero1.Text);
            numero2 = double.Parse(txtnumero2.Text);

            if (rdbsuma.Checked == true) 
            {
                operacion = numero1 + numero2;
            }
            else if (rdbresta.Checked == true) 
            {
                operacion = numero1 - numero2;
            }
            else if (rdbmultiplicar.Checked == true)
            {
                operacion = numero1 * numero2;
            }
            else
            {
                operacion = numero1 / numero2;
            }

            txtresultado.Text = operacion.ToString();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtnumero1.Clear();
            txtnumero2.Clear();
            txtresultado.Clear();
            txtnumero1.Focus();
        }
    }
}
