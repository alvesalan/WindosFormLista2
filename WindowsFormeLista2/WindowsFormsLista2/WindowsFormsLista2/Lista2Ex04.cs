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
                    double Numero = Convert.ToDouble(txt_Numero.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Digite apenas numeros validos");
                    
                }
            }
        }
    }
}
