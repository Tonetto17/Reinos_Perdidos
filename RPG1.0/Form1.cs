using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RPG1._0
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            Menu Menu = new Menu();
            Menu.Show();


        }

        private void btn_Sair_Form_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
