using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoDoPesoIdeal
{
    public partial class formCalculoPesoIdeal : Form
    {
        RadioButton rbnSelecionado = null;
        public formCalculoPesoIdeal()
        {
            InitializeComponent();
        }

        private void SetPesoIdeal()
        {
            // outra forma de achar o radioButton selecionado
            //rbnSelecionado = groupBoxSexo.Controls.OfType<RadioButton>().SingleOrDefault(r => r.Checked == true);
            try
            {
                double altura = Convert.ToDouble(txtAltura.Text);
                double pesoIdeal = (rbnSelecionado.Text.Equals("Masculino")) ? (72.7 * altura) - 58 : (62.1 * altura) - 44.7;
                labelPesoIdeal.Text = pesoIdeal.ToString("N");
            }
            catch (Exception e)
            {
                MessageBox.Show("Selecione o sexo e informe a altura corretamente",
                "Atenção!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbnFeminino_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbn = (RadioButton)sender;
            if (rbn.Checked)
            {
                rbnSelecionado = rbn;
                SetPesoIdeal();
            }
        }

        private void rbnMasculino_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbn = (RadioButton)sender;
            if (rbn.Checked)
            {
                rbnSelecionado = rbn;
                SetPesoIdeal();
            }
        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {
            SetPesoIdeal();
        }

        private void labelPesoIdeal_Click(object sender, EventArgs e)
        {

        }
    }
}
