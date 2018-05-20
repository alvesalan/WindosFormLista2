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
    public partial class Lista2Ex04 : Form
    {
        double Numero = 0;

        public Lista2Ex04()
        {
            InitializeComponent();
        }

        private void Lista2Ex04_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                   Numero = Convert.ToDouble(txt_Numero.Text);
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
                else if (Numero % 2 == 0)
                {
                    MessageBox.Show("Numero e par");
                }
                else if (Numero % 2 == 1)
                {
                    MessageBox.Show("Numero não e par");
                }
            }
        }

        private void txt_Numero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
