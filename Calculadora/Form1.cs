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
    public partial class Frm_Calculadora : Form
    {
        public Frm_Calculadora()
        {
            InitializeComponent();
        }

        Operaciones_Matematicas obj = new Operaciones_Matematicas();
        private String opreador = null;
        private Double n1,n2 = 0.0;

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

        private void Bt_factorial_Click(object sender, EventArgs e)
        {
            Tx_pantalla.Text= obj.factorial(Double.Parse(Tx_pantalla.Text)).ToString();
        }

        private void Bt_Limpiar_Click(object sender, EventArgs e)
        {
            Tx_pantalla.Clear();
        }

      

        private void Bt_suma_Click(object sender, EventArgs e)
        {
            opreador = Bt_suma.Text;
            n1 = Double.Parse(Tx_pantalla.Text);
            Tx_pantalla.Clear();
        }

        private void Bt_resta_Click(object sender, EventArgs e)
        {
            opreador = Bt_resta.Text;
            n1 = Double.Parse(Tx_pantalla.Text);
            Tx_pantalla.Clear();
        }

        private void Bt_multiplica_Click(object sender, EventArgs e)
        {
            opreador = Bt_multiplica.Text;
            n1 = Double.Parse(Tx_pantalla.Text);
            Tx_pantalla.Clear();
        }

        private void Bt_div_Click(object sender, EventArgs e)
        {
            opreador = Bt_div.Text;
            n1 = Double.Parse(Tx_pantalla.Text);
            Tx_pantalla.Clear();
        }

        private void Bt_porcentaje_Click(object sender, EventArgs e)
        {
            opreador = Bt_porcentaje.Text;
            Tx_pantalla.Text = (Double.Parse(Tx_pantalla.Text)/100).ToString();
           
        }

        private void Bt_igual_Click(object sender, EventArgs e)
        {
            n2 = Double.Parse(Tx_pantalla.Text);
            switch (opreador) {
                case "+":
                    Tx_pantalla.Text = obj.suma(n1, n2).ToString();
                    break;
                case "-":
                    Tx_pantalla.Text = obj.resta(n1, n2).ToString();
                    break;
                case "*":
                    Tx_pantalla.Text = obj.Multiplicacion(n1, n2).ToString();
                    break;
                case "/":
                    Tx_pantalla.Text = obj.divicion(n1, n2).ToString();
                    break;
                case "%":
                    Tx_pantalla.Text = obj.Multiplicacion(n1, n2).ToString();
                    break;

            }
        }
    }
}
