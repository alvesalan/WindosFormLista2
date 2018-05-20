using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLista2
{
    public partial class Lista2Ex06 : Form
    {
        public Lista2Ex06()
        {
            InitializeComponent();
        }

        private void txtNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int Numero = 0;

                try
                {
                    Numero = Convert.ToInt32(txtNumero.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Digite um numero valido");
                    return;
                }

                if (Numero != 1)
                {
                    MessageBox.Show("Numero e diferente de 1");
                }
                else
                {
                    MessageBox.Show("Numero não e diferente de 1");
                }
            }
        }
    }
}
