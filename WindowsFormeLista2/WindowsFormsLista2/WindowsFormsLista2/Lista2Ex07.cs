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
    public partial class Lista2Ex07 : Form
    {
        double Numero = 0;

        public Lista2Ex07()
        {
            InitializeComponent();
        }

       

        private void ntnResultados_Click(object sender, EventArgs e)
        {

           
           

            try
            {
                Numero = Convert.ToInt32(txtNumero.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Digite um numero valido !!");
                return;
            }

            if (Numero != 1)
            {
                lbNumeroDiferente1.Text = Convert.ToString("Numero é diferente de 1");
            }
            else 
            {
                lbNumeroDiferente1.Text = Convert.ToString("Numero não e diferente diferente 1");
            }

            if (Numero < -10)
            {                
                lbNumeroMenorMenos10.Text = Convert.ToString("Numero e menor que -10 ");
            }
            else
            {               
                lbNumeroMenorMenos10.Text = Convert.ToString("Numero não e menor que -10");
            }

            if (Numero >= 30)
            {
                lbNumeroMaiorIgual30.Text = Convert.ToString("Numero e maior que 30 ou e igual a 30");
            }
            else
            {
                lbNumeroMaiorIgual30.Text = Convert.ToString("Numero não e maior e nem igual a 30");
            }





            if (Numero > 10)
            {
                lbResultadoMaiorQue10.Text = Convert.ToString("Numero é maior que 10");     
            }
            else
            {
                lbResultadoMaiorQue10.Text = Convert.ToString("Numero não é maior que 10");  
            }

            if (Numero <= 50)
            {
                lbResultadoMenorIgual50.Text = Convert.ToString("Numero e menor ou igual a 50");
            }
            else
            {
                lbResultadoMenorIgual50.Text = Convert.ToString("Numero não e menor ou igual a 50");
            }


            if (Numero < 0) 
            {
                lbResultadoNegativoPositivo.Text = Convert.ToString("Numero Negativo");
            }
            else if (Numero > 10)
            {
                lbResultadoNegativoPositivo.Text = Convert.ToString("Numero Positivo");
            }
            else
            {
                lbResultadoNegativoPositivo.Text = Convert.ToString("Numero neutro");
            }

            if (Numero % 2 == 0) 
            {
                lbResultadoParImpar.Text = Convert.ToString("Numero Par");
            }
            else if (Numero % 2 == 1)
            {
                lbResultadoParImpar.Text = Convert.ToString("Numero Numero impar");
            }
            else
            {
                lbResultadoParImpar.Text = Convert.ToString("Numero neutro");
            }

        }
    }
}
