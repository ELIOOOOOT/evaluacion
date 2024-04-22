using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace evaluacion
{
    public partial class Form1 : Form
    {
        double primerNumero = 0;
        double segundoNumero = 0;
        char operador;

        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_sumar_Click(object sender, EventArgs e)
        {
            primerNumero = double.Parse(textBox1.Text);
            operador = '+';
            textBox1.Clear();
        }

        private void BTN_resta_Click(object sender, EventArgs e)
        {
            primerNumero = double.Parse(textBox1.Text);
            operador = '-';
            textBox1.Clear();
        }

        private void BTN_multiplicacion_Click(object sender, EventArgs e)
        {
            primerNumero = double.Parse(textBox1.Text);
            operador = 'x';
            textBox1.Clear();
        }

        private void BTN_division_Click(object sender, EventArgs e)
        {
            primerNumero = double.Parse(textBox1.Text);
            operador = '÷';
            textBox1.Clear();
        }

        private void BTN_resultado_Click(object sender, EventArgs e)
        {
            segundoNumero = double.Parse(textBox1.Text);
            double resultado = 0;

            switch (operador)
            {
                case '+':
                    resultado = primerNumero + segundoNumero;
                    break;
                case '-':
                    resultado = primerNumero - segundoNumero;
                    break;
                case '*':
                    resultado = primerNumero * segundoNumero;
                    break;
                case '/':
                    if (segundoNumero != 0)
                    {
                        resultado = primerNumero / segundoNumero;
                    }
                    else
                    {
                        textBox1.Text = "Error";
                        return;
                    }
                    break;
            }

            textBox1.Text = resultado.ToString();
        }

        private void BTN_cero_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void BTN_uno_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void BTN_dos_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void BTN_tres_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void BTN_cuatro_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void BTN_cinco_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void BTN_seis_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void BTN_siete_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void BTN_ocho_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void BTN_NUEVE_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void BTN_punto_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void BTN_limpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
