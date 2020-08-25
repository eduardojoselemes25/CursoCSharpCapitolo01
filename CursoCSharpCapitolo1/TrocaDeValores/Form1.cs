using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrocaDeValores
{
    public partial class frmTrocaDeValores : Form
    {
        public frmTrocaDeValores()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string auxiliar;
            auxiliar = txtPrimeiroValor.Text;
            txtPrimeiroValor.Text = txtSegundoValor.Text;
            txtSegundoValor.Text = auxiliar;

            MessageBox.Show("Troca de valores concluida",
                "Infomações", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
