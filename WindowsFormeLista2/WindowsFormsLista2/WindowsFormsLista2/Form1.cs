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

                if ((Opcao == 1) && (Opcao == 01))
                {
                    Lista2Ex01 lista2ex01 = new Lista2Ex01();
                    lista2ex01.Show();
                }
                else if ((Opcao == 2) && (Opcao == 02))
                {
                    Lista2Ex02 lista2ex02 = new Lista2Ex02();
                    lista2ex02.Show();
                }
                else if ((Opcao == 3) && (Opcao == 03))
                {
                    Lista2Ex03 lista2ex3 = new Lista2Ex03();
                    lista2ex3.Show();
                }
                else if ((Opcao == 04) && (Opcao == 04))
                {
                    Lista2Ex04 lista2Ex04 = new Lista2Ex04();
                    lista2Ex04.Show();
                }
                else if ((Opcao == 05) && (Opcao == 5))
                {
                    Lista2Ex05 lista2ex05 = new Lista2Ex05();
                    lista2ex05.Show();
                }
                else if ((Opcao == 06) && (Opcao == 6))
                {
                    Lista2Ex06 lista2ex06 = new Lista2Ex06();
                    lista2ex06.Show();
                }
            }
        }

        private void txt_Opcao_TextChanged(object sender, EventArgs e)
        {
            Opcao = Convert.ToInt32(txt_Opcao.Text);

        }
    }
}
