using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor.Clear();
            txtValor.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int valor;
            
            valor = int.Parse(txtValor.Text);

            if (valor % 2 == 0)
            {
                valor *= 3;
                MessageBox.Show("O Valor é Par. O valor multiplicado por 3 é: " + valor, "Resultado");
            }
            else
            {
                valor += 7;
                MessageBox.Show("O Valor é Impar. O valor somado com 7 é: " + valor, "Resultado");
            }
        }
    }
}
