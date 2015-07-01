using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            try
            {
                double suma;
                suma = Convert.ToDouble(txtnumero1.Text) + Convert.ToDouble(txtnumero2.Text);
                MessageBox.Show("El resultado es: " + suma);
            }
            catch (SystemException)
            {
            }
        }

        private void btnsustrae_Click(object sender, EventArgs e)
        {
            double resta;
            resta = Convert.ToDouble(txtnumero1.Text) - Convert.ToDouble(txtnumero2.Text);
            MessageBox.Show("El resultado es: " + resta);
        }

        private void btnresto_Click(object sender, EventArgs e)
        {
            double resto;
            resto = Convert.ToDouble(txtnumero1.Text) % Convert.ToDouble(txtnumero2.Text);
            MessageBox.Show("El resultado es: " + resto);

        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            double divide;
            divide = Convert.ToDouble(txtnumero1.Text) / Convert.ToDouble(txtnumero2.Text);
            MessageBox.Show("El resultado es: " + divide);
        }

        private void txtnumero2_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtnumero2.Text)==0)
            {
                btndivide.Enabled=false;
                btnresto.Enabled = false;
                btnraiz.Enabled = false;
            }
        }

        private void btnpotencia_Click(object sender, EventArgs e)
        {
            double potencia;
            potencia=Math.Pow(Convert.ToDouble(txtnumero1.Text),Convert.ToDouble(txtnumero2.Text));
            MessageBox.Show("El resultado es: " + potencia);
        }

        private void btnraiz_Click(object sender, EventArgs e)
        {
            double raiz;
            raiz=Math.Sqrt(Convert.ToDouble(txtnumero1.Text));
            MessageBox.Show("El resultado es: " + raiz);
        }

        private void btnlimpia_Click(object sender, EventArgs e)
        {
            
        }

        private void txtnumero1_TextChanged(object sender, EventArgs e)
        {
            try { }
            catch (SystemException)
            {
                MessageBox.Show("no se acepta vacio");
            }

        }

       
        

    }
}

       