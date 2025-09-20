using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pclac
{
    public partial class Form1 : Form
    {
        double numero1, numero2, numero3, resultado;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            resultado = (numero1 + numero2);
            txtResultado.Text = resultado.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (numero2 == 0)
            {
                errorProvider2.SetError(txtNumero2, "numero 2 não pode ser igual a 0");
                txtNumero2.Focus();
            }
            else
            {
                resultado = (numero1 - numero2);
                txtResultado.Text = resultado.ToString();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja mesmo sair?", "Saída", 
                MessageBoxButtons.YesNo,MessageBoxIcon.Question) == 
                DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            resultado = (numero1 * numero2);
            txtResultado.Text = resultado.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (numero2 == 0)
            {
                errorProvider2.SetError(txtNumero2, "numero 2 não pode ser igual a 0");
                txtNumero2.Focus();
            }
            else
            {
                resultado = (numero1 / numero2);
                txtResultado.Text = resultado.ToString();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtResultado.Clear();
            txtNumero1.Focus();
        }

        private void txtNumero2_Validated(object sender, EventArgs e)
        {
            try
            {
                errorProvider2.SetError(txtNumero2, "");
                numero2 = Convert.ToDouble(txtNumero2.Text);
            }
            catch
            {
                errorProvider2.SetError(txtNumero2, "numero inválido");
                txtNumero2.Focus();
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void txtNumero1_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtNumero1.Text, out numero1))
            {
                errorProvider1.SetError(txtNumero1, "Número 1 inválido");
                txtNumero1.Focus();
            }
            else
            {
                errorProvider1.SetError(txtNumero1, "");
            }

        }
    }
}
