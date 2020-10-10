using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button19_Click(object sender, EventArgs e)
        {
                
        }

        private void Bt_cero_Click(object sender, EventArgs e)
        {
            Tx_pantalla.Text += Bt_cero.Text;  
        }

        private void Bt_uno_Click(object sender, EventArgs e)
        {
            Tx_pantalla.Text += Bt_uno.Text;
        }

        private void Bt_dos_Click(object sender, EventArgs e)
        {
            Tx_pantalla.Text += Bt_dos.Text;
        }

            private void Bt_tres_Click(object sender, EventArgs e)
        {
            Tx_pantalla.Text += Bt_tres.Text;
        }

        private void Bt_cuatro_Click(object sender, EventArgs e)
        {
            Tx_pantalla.Text += Bt_cuatro.Text;
        }

        private void Bt_cinco_Click(object sender, EventArgs e)
        {
            Tx_pantalla.Text += Bt_cinco.Text;
        }

        private void Bt_seis_Click(object sender, EventArgs e)
        {
            Tx_pantalla.Text += Bt_seis.Text;
        }

        private void Bt_siete_Click(object sender, EventArgs e)
        {
            Tx_pantalla.Text += Bt_siete.Text;
        }

        private void Bt_ocho_Click(object sender, EventArgs e)
        {
            Tx_pantalla.Text += Bt_ocho.Text;
        }

        private void Bt_nueve_Click(object sender, EventArgs e)
        {
            Tx_pantalla.Text += Bt_nueve.Text;
        }

        private void Bt_decimal_Click(object sender, EventArgs e)
        {
            Tx_pantalla.Text += Bt_decimal.Text;
        }
    }
}
