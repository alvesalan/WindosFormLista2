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
    public partial class Lista2Ex03 : Form
    {
        double N1 = 0, N2 = 0, Opcao = 0;


        public Lista2Ex03()
        {
            InitializeComponent();
        }

        private void txt_Numero1_TextChanged(object sender, EventArgs e)
        {
               
            
        }

        private void txt_Numero2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txt_Numero1_KeyDown(object sender, KeyEventArgs e)
        {
           
            
        }

        private void txt_Numero2_KeyDown(object sender, KeyEventArgs e)
        {           
           
        }

        private void txt_Opcao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Opcao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { 
                try
                {
                 Opcao = Convert.ToDouble(txt_Opcao.Text);
                }
                catch (Exception)
                {
                MessageBox.Show("Por favor digite apenas numeros");

                 }
            }


            if (Opcao == 1)
            {
                N1 = Convert.ToDouble(txt_Numero1.Text);
                N2 = Convert.ToDouble(txt_Numero2.Text);
                double Resultado = N1 + N2;
                MessageBox.Show(N1 + " + " + N2 + " = " + Resultado);
            }
            else if (Opcao == 2)
            {
                N1 = Convert.ToDouble(txt_Numero1.Text);
                N2 = Convert.ToDouble(txt_Numero2.Text);
                double Resultado = N1 - N2;
                MessageBox.Show(N1 + " - " + N2 + " = " + Resultado);
            }
            else if (Opcao == 3)
            {
                N1 = Convert.ToDouble(txt_Numero1.Text);
                N2 = Convert.ToDouble(txt_Numero2.Text);
                double Resultado = N1 * N2;
                MessageBox.Show(N1 + " * " + N2 + " = " + Resultado);
            }
            else if (Opcao == 4)
            {
                N1 = Convert.ToDouble(txt_Numero1.Text);
                N2 = Convert.ToDouble(txt_Numero2.Text);
                double Resultado = N1 / N2;
                MessageBox.Show(N1 + " / " + N2 + " = " + Resultado);
            }

        }
    }
}
