using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG1._0
{
    public partial class Calc : Form
    {
        int val1, val2, total;
        Operacoes op = new Operacoes();

        public Calc()
        {
            InitializeComponent();
        }

        private void btn_Somar_Click(object sender, EventArgs e)
        {
            if (tbox_Val1.Text == string.Empty || tbox_Val2.Text == string.Empty)
            {
                MessageBox.Show("Preencha os campos");
            }
            else
            {

                val1 = Convert.ToInt32(tbox_Val1.Text);
                val2 = Convert.ToInt32(tbox_Val2.Text);

                total = op.somar(val1, val2);
                lb_Total.Text = total.ToString();
            }
        }

        private void btn_Subtrair_Click(object sender, EventArgs e)
        {
            if (tbox_Val1.Text == string.Empty || tbox_Val2.Text == string.Empty)
            {
                MessageBox.Show("Preencha os campos");
            }
            else
            {
                val1 = Convert.ToInt32(tbox_Val1.Text);
                val2 = Convert.ToInt32(tbox_Val2.Text);

                total = op.subtrair(val1, val2);
                lb_Total.Text = total.ToString();
            }
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            tbox_Val1.Clear();
            tbox_Val2.Clear();
            lb_Total.Text = "";
            tbox_Val1.Focus();
        }

        private void btn_Multiplicar_Click(object sender, EventArgs e)
        {
            if (tbox_Val1.Text == string.Empty || tbox_Val2.Text == string.Empty)
            {
                MessageBox.Show("Preencha os campos");
            }
            else
            {
                val1 = Convert.ToInt32(tbox_Val1.Text);
                val2 = Convert.ToInt32(tbox_Val2.Text);

                total = op.multiplicar(val1, val2);
                lb_Total.Text = total.ToString();
            }
        }

        private void btn_Dividir_Click(object sender, EventArgs e)
        {
            if (tbox_Val1.Text == string.Empty || tbox_Val2.Text == string.Empty)
            {
                MessageBox.Show("Preencha os campos");
            }
            else
            {
                val1 = Convert.ToInt32(tbox_Val1.Text);
                val2 = Convert.ToInt32(tbox_Val2.Text);

                //Verificador se o val2 é 0
                if (val2 == 0)
                {
                    MessageBox.Show("Verifique o valor 2! \n Não há divisão por 0!");
                    tbox_Val2.Focus();
                }
                else
                {
                    total = op.dividir(val1, val2);
                    lb_Total.Text = total.ToString();
                }
            }
        }

       

        
    }
}
