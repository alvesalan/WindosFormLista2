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
    public partial class Lista2Ex05 : Form
    {
        public Lista2Ex05()
        {
            InitializeComponent();
        }

        private void txtNumero_KeyDown(object sender, KeyEventArgs e)
        {
            int Numero = 0;

            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Numero = Convert.ToInt32(txtNumero.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Digite apenas numeros validos !!");
                    return;
                }

                if (Numero == 0)
                {
                    string R = "Numero neutro";
                    lbResultado.Text = Convert.ToString(R);
                }

                else if (Numero % 2 == 1)
                {
                    string R = "Numero impar";
                    lbResultado.Text = Convert.ToString(R);
                }

                else if (Numero % 2 == 0)
                {
                    string R = "Numero não e impar";
                    lbResultado.Text = Convert.ToString(R);
                }
            }

           
        }
    }
}
