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
        // Variaveis globais:
        double a, b;
        string ultimoOp;
        double acumula = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void numeroPressionado(object sender, EventArgs e)
        {
            Button n = (Button)sender;
            txbtela.Text += n.Text; // += é txbtela.Text = txbtela.Text + "7";
        }
        private void operacoes(object sender, EventArgs e)
        {
            Button operador = (Button)sender;
            //corrigir
            this.a = int.Parse(txbtela.Text);
            this.ultimoOp = operador.Text;

            txbaux.Text = txbtela.Text + " " + operador.Text;

            txbtela.Text = "";

        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            //object result = ()
            //string now = ()

            if (operacao == "+")
            {
                acumula += double.Parse(txbtela.Text);
                txbtela.Text = acumula.ToString();
            }
            else if (operacao == "-")
            {
                acumula -= double.Parse(txbtela.Text);
                txbtela.Text = acumula.ToString();
            }
            else if (operacao == "*")
            {
                acumula *= double.Parse(txbtela.Text);
                txbtela.Text = acumula.ToString();
            }
            else if (operacao == "/")
            {
                if (double.Parse(txbtela.Text) != 0)
                {
                    acumula /= double.Parse(txbtela.Text);
                    txbtela.Text = acumula.ToString();
                }
                else
                {
                    txbtela.Text = "Dividindo por zero";
                }

            }
        }
    }
}
           