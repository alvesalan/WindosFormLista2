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
    public partial class Lista2Ex08Contiacao1 : Form
    {
        Lista2Ex08Contiacao2 lista2ex08continuacao2 = new Lista2Ex08Contiacao2();

        public Lista2Ex08Contiacao1()
        {
            InitializeComponent();
        }

        private void Lista2Ex08Contiacao1_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("\tTipo\tNome\tValor");
            sb.AppendLine("1-\tBolos\tbolo brigadeiro\tR$ 29,50");
            sb.AppendLine("2-\tBolos\tbolo floresta negra\tR$ 2,00");
            sb.AppendLine("3-\tBolos\tbolo leite com nutella\tR$ 29,23");
            sb.AppendLine("4-\tBolos\tbolo mousse com chocolate\tR$ 7,10");
            sb.AppendLine("5-\tBolos\tbolo nega Maluca\tR$ 19,33");
            sb.AppendLine("6-\tDoces\tbomba de creme\tR$ 17,71");
            sb.AppendLine("7-\tDoces\tbomba de morango\tR$ 4,82");
            sb.AppendLine("8-\tSanduiches\tfile-Mignon com fritas e chedar\tR$ 21,16");
            sb.AppendLine("9-\tSanduiches\thamburguer com queijos, champignon e rúcula\tR$ 12,70");
            sb.AppendLine("10-\tSanduiches\tprovolome com salame\tR$ 19,70");
            sb.AppendLine("11-\tSanduiches\tvegetariano de berinjela\tR$ 28,22");
            sb.AppendLine("12-\tPizzas\tcalabresa\tR$ 8,98");
            sb.AppendLine("13-\tPizzas\tnapolitana\tR$ 0,42");
            sb.AppendLine("14-\tPizzas\tperuana\tR$ 18,36");
            sb.AppendLine("15-\tPizzas\tportuguesa\tR$ 27,50");



            txtMenu.Text = Convert.ToString(sb);
        }

        private void txtMenu_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtbOpcao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {


                int Opcao = Convert.ToInt32(mtbOpcao.Text);

                double Valor = 0;

                if (Opcao == 01)
                {

                    Valor = 29.50;

                }
                else if (Opcao == 02)
                {
                    Valor = 2.00;
                }
                else if (Opcao == 03)
                {
                    Valor = 29.23;
                }
                else if (Opcao == 04)
                {
                    Valor = 7.10;
                }
                else if (Opcao == 05)
                {
                    Valor = 19.33;
                }
                else if (Opcao == 06)
                {
                    Valor = 17.71;
                }
                else if (Opcao == 07)
                {
                    Valor = 4.82;
                }
                else if (Opcao == 08)
                {
                    Valor = 21.16;
                }
                else if (Opcao == 09)
                {
                    Valor = 12.70;
                }
                else if (Opcao == 10)
                {
                    Valor = 19.70;
                }
                else if (Opcao == 11)
                {
                    Valor = 28.22;
                }
                else if (Opcao == 12)
                {
                    Valor = 8.98;
                }
                else if (Opcao == 13)
                {
                    Valor = 0.42;
                }
                else if (Opcao == 14)
                {
                    Valor = 18.36;
                }
                else if (Opcao == 15)
                {
                    Valor = 27.50;
                }

                DialogResult confirm = MessageBox.Show("Você tem certeza que e a opcão: " + Opcao + " de " + Valor + " R$", "Salvar Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);


                lista2ex08continuacao2.Show();
            }
        }
    }
}
