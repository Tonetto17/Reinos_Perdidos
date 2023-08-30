using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace RPG1._0
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnSelecionarImagem_Click(object sender, EventArgs e)
        {
            // Cria um novo OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Define os filtros para permitir apenas arquivos de imagem
            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            // Exibe a caixa de diálogo e verifica se o usuário selecionou um arquivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtém o caminho completo do arquivo selecionado
                string caminhoImagem = openFileDialog.FileName;

                // Carrega a imagem no controle PictureBox
                pictureBox1.Image = Image.FromFile(caminhoImagem);
            }
        }

        private void btnAbrirFicha_Click(object sender, EventArgs e)
        {
            // Verifica se o usuário selecionou uma imagem antes de abrir o segundo formulário
            if (pictureBox1.Image != null)
            {
                // Cria o segundo formulário (Form2) e passe a imagem selecionada como argumento
                Ficha form2 = new Ficha(pictureBox1.Image);
                form2.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma imagem antes de abrir o segundo formulário.");
            }
        }

    }
}
