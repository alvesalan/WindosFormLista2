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
    public partial class Lista2Ex01 : Form
    {

        int Numero = 0;
        public Lista2Ex01()
        {
            InitializeComponent();
        }

        private void Lista2Ex01_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            try 
	    {
            Numero = Convert.ToInt32(txt_Numero.Text);
	    }
	    catch (Exception)
	    {
            
	    
	    }
           
        }

        private void txt_Numero_KeyDown(object sender, KeyEventArgs e)
        {

            if (Numero == 0)
            {
                lb_Resultado.Text = Convert.ToString("Neutro");
            }
            else if (Numero > 0)
            {
                lb_Resultado.Text = Convert.ToString("Positivo");
            }
            else if (Numero < 0)
            {
                lb_Resultado.Text = Convert.ToString("Negativo");
            }


        }
    }
}
