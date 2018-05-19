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
    public partial class Lista2Ex02 : Form
    {
        int Numero = 0;

        public Lista2Ex02()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void Lista2Ex02_KeyDown(object sender, KeyEventArgs e)
        {





        }


        private void txtNumero_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Numero = Convert.ToInt32(txtNumero.Text);
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Digite apenas numeros validos");
                    return;

                }


                if (Numero == 0)
                {
                    MessageBox.Show("Numero neutro");
                }
                else if (Numero > 0)
                {
                    MessageBox.Show("Numero não e negativo");
                }
                else if (Numero < 0)
                {
                    MessageBox.Show("Numeo e negativo");
                }
            }
        }

    }
}

