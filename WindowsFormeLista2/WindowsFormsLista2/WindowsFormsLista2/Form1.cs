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
    public partial class Form1 : Form
    {
        int Opcao = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void txt_Opcao_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {


               Opcao = Convert.ToInt32(txt_Opcao.Text);

                if (Opcao == 1)
                {
                    Lista2Ex01 lista2ex01 = new Lista2Ex01();
                    lista2ex01.Show();
                }
                else if (Opcao == 3)
                {
                    Lista2Ex03 lista2ex3 = new Lista2Ex03();
                    lista2ex3.Show();
                }

            }
        }

        private void txt_Opcao_TextChanged(object sender, EventArgs e)
        {
            Opcao = Convert.ToInt32(txt_Opcao.Text);

        }
    }
}
