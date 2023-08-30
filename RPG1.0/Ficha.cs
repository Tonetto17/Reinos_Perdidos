using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RPG1._0
{
    public partial class Ficha : Form
    {
        int faces;
        Random random = new Random();

        public Ficha()
        {
            InitializeComponent();
            AtualizarGrid();
            tbox_Per_Ficha.Focus();
        }

        public Ficha(Image userImage)
        {
            InitializeComponent();
            pictureBox1.Image = userImage;
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {


                Personagem per = new Personagem();
                SqlConnection con = new SqlConnection(BDConnection.ConnectionPath);
                con.Open();
                string sql = "INSERT INTO TB_FICHA(S_PER_FICHA, S_CLAS_FICHA, I_VIG_FICHA, I_AGIL_FICHA, I_FOR_FICHA, I_VEL_FICHA, I_PERC_FICHA, S_TAM_FICHA, I_CAR_FICHA, I_FORV_FICHA, I_INTE_FICHA, I_XP_FICHA, S_DEF_FICHA, S_APT_FICHA, S_ANT_FICHA)" +
                                "VALUES (@S_PER_FICHA, @S_CLAS_FICHA, @I_VIG_FICHA, @I_AGIL_FICHA, @I_FOR_FICHA, @I_VEL_FICHA, @I_PERC_FICHA, @S_TAM_FICHA, @I_CAR_FICHA, @I_FORV_FICHA, @I_INTE_FICHA, @I_XP_FICHA,  @S_DEF_FICHA, @S_APT_FICHA, @S_ANT_FICHA)";

                SqlCommand tela = new SqlCommand(sql, con);
                tela.Parameters.Add("@S_PER_FICHA", SqlDbType.VarChar).Value = tbox_Per_Ficha.Text;
                tela.Parameters.Add("@S_CLAS_FICHA", SqlDbType.VarChar).Value = cbbox_Clas_Ficha.Text;
                tela.Parameters.Add("@I_VIG_FICHA", SqlDbType.Int).Value = tbox_Vig_Ficha.Text;
                tela.Parameters.Add("@I_AGIL_FICHA", SqlDbType.Int).Value = tbox_Agil_Ficha.Text;
                tela.Parameters.Add("@I_FOR_FICHA", SqlDbType.Int).Value = tbox_For_Ficha.Text;
                tela.Parameters.Add("@I_VEL_FICHA", SqlDbType.Int).Value = tbox_Vel_Ficha.Text;
                tela.Parameters.Add("@I_PERC_FICHA", SqlDbType.Int).Value = tbox_Perc_Ficha.Text;
                tela.Parameters.Add("@S_TAM_FICHA", SqlDbType.VarChar).Value = cbbox_Tam_Ficha.Text;
                tela.Parameters.Add("@I_CAR_FICHA", SqlDbType.Int).Value = tbox_Car_Ficha.Text;
                tela.Parameters.Add("@I_FORV_FICHA", SqlDbType.Int).Value = tbox_Forv_Ficha.Text;
                tela.Parameters.Add("@I_INTE_FICHA", SqlDbType.Int).Value = tbox_Inte_Ficha.Text;
                tela.Parameters.Add("@I_XP_FICHA", SqlDbType.Int).Value = tbox_Xp_Ficha.Text;
                tela.Parameters.Add("@S_DEF_FICHA", SqlDbType.VarChar).Value = tbox_Def_Ficha.Text;
                tela.Parameters.Add("@S_APT_FICHA", SqlDbType.VarChar).Value = tbox_Apt_Ficha.Text;
                tela.Parameters.Add("@S_ANT_FICHA", SqlDbType.VarChar).Value = tbox_Ant_Ficha.Text;



                tela.ExecuteNonQuery();
                MessageBox.Show("Seu personagem foi incluido com sucesso!");
                con.Close();
                AtualizarGrid();


            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao inserir personagem!" + erro.Message);
            }
        }

        public void AtualizarGrid()
        {

            dt_Ficha.DataSource = ListarPersonagem();


            dt_Ficha.Columns[0].HeaderText = "Código";
            dt_Ficha.Columns[1].HeaderText = "Personagem";
            dt_Ficha.Columns[2].HeaderText = "Classe";



            dt_Ficha.Columns[0].Width = 30;
            dt_Ficha.Columns[1].Width = 100;
            dt_Ficha.Columns[2].Width = 100;


            dt_Ficha.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dt_Ficha.AllowUserToAddRows = false;//usuário não pode adicionar linhas
            dt_Ficha.AllowUserToDeleteRows = false;//usuario não pode deletar linhas
            dt_Ficha.ReadOnly = true;//deixará o datagrid para apenas leitura
        }

        public static DataTable ListarPersonagem()
        {
            try
            {
                SqlConnection con = new SqlConnection(BDConnection.ConnectionPath);
                con.Open();

                string sql = "SELECT  I_COD_FICHA, S_PER_FICHA, S_CLAS_FICHA FROM TB_FICHA";

                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();

                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;

            }
        }

        private void dt_Ficha_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {

                int linha = dt_Ficha.SelectedRows[0].Index;
                if (linha >= 0)
                {
                    btn_Salvar.Enabled = false;
                    btn_Excluir.Enabled = true;
                    btn_Alt_Ficha.Enabled = true;
                    btn_Calc.Enabled = true;
                    btn_Home.Enabled = true;

                    int codigo = Convert.ToInt32(dt_Ficha.Rows[linha].Cells[0].Value);
                    Personagem per = SelecionarPersonagem(codigo);
                    if (per != null)
                    {
                        tbox_Cod_Ficha.Text = per.Cod_Ficha.ToString();
                        tbox_Per_Ficha.Text = per.Per_Ficha.ToString();
                        cbbox_Clas_Ficha.Text = per.Clas_Ficha;
                        tbox_Vig_Ficha.Text = per.Vig_Ficha.ToString();
                        tbox_Agil_Ficha.Text = per.Agil_Ficha.ToString();
                        tbox_For_Ficha.Text = per.For_Ficha.ToString();
                        tbox_Vel_Ficha.Text = per.Vel_Ficha.ToString();
                        tbox_Perc_Ficha.Text = per.Perc_Ficha.ToString();
                        cbbox_Tam_Ficha.Text = per.Tam_Ficha;
                        tbox_Car_Ficha.Text = per.Car_Ficha.ToString();
                        tbox_Forv_Ficha.Text = per.Forv_Ficha.ToString();
                        tbox_Inte_Ficha.Text = per.Inte_Ficha.ToString();
                        tbox_Xp_Ficha.Text = per.Xp_Ficha.ToString();
                        tbox_Def_Ficha.Text = per.Def_Ficha;
                        tbox_Apt_Ficha.Text = per.Apt_Ficha;
                        tbox_Ant_Ficha.Text = per.Ant_Ficha;
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao clicar no personagem: " + erro.Message);
            }

        }
        public static Personagem SelecionarPersonagem(int codigo)
        {
            try
            {
                SqlConnection con = new SqlConnection(BDConnection.ConnectionPath);
                con.Open();
                string sql = "SELECT * FROM TB_FICHA WHERE I_COD_FICHA=@I_COD_FICHA";
                SqlCommand cmd = new SqlCommand(sql, con);


                cmd.Parameters.AddWithValue("@I_COD_FICHA", codigo);



                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    Personagem per = new Personagem();
                    per.Cod_Ficha = Convert.ToInt32(dr[0]);
                    per.Per_Ficha = dr[1].ToString();
                    per.Clas_Ficha = dr[2].ToString();
                    per.Vig_Ficha = Convert.ToInt32(dr[3]);
                    per.Agil_Ficha = Convert.ToInt32(dr[4]);
                    per.For_Ficha = Convert.ToInt32(dr[5]);
                    per.Vel_Ficha = Convert.ToInt32(dr[6]);
                    per.Perc_Ficha = Convert.ToInt32(dr[7]);
                    per.Tam_Ficha = dr[8].ToString();
                    per.Car_Ficha = Convert.ToInt32(dr[9]);
                    per.Forv_Ficha = Convert.ToInt32(dr[10]);
                    per.Inte_Ficha = Convert.ToInt32(dr[11]);
                    per.Xp_Ficha = Convert.ToInt32(dr[12]);
                    per.Def_Ficha = dr[13].ToString();
                    per.Apt_Ficha = dr[14].ToString();
                    per.Ant_Ficha = dr[15].ToString();
                    con.Close();
                    return per;
                }
                else
                {
                    con.Close();
                    return null;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar personagem." + erro.Message);
                return null;

            }
        }
        private void dt_Ficha_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dt_Ficha.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Purple;
        }

        private void btn_Alt_Ficha_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Tem certeza de que deseja alterar?",
                    "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {

                    int linha = dt_Ficha.SelectedRows[0].Index;
                    Personagem per = new Personagem();
                    per.Cod_Ficha = Convert.ToInt32(tbox_Cod_Ficha.Text);
                    per.Per_Ficha = tbox_Per_Ficha.Text;
                    per.Clas_Ficha = cbbox_Clas_Ficha.Text;
                    per.Vig_Ficha = Convert.ToInt32(tbox_Vig_Ficha.Text);
                    per.Agil_Ficha = Convert.ToInt32(tbox_Agil_Ficha.Text);
                    per.For_Ficha = Convert.ToInt32(tbox_For_Ficha.Text);
                    per.Vel_Ficha = Convert.ToInt32(tbox_Vel_Ficha.Text);
                    per.Perc_Ficha = Convert.ToInt32(tbox_Perc_Ficha.Text);
                    per.Tam_Ficha = cbbox_Tam_Ficha.Text;
                    per.Perc_Ficha = Convert.ToInt32(tbox_Perc_Ficha.Text);
                    per.Car_Ficha = Convert.ToInt32(tbox_Car_Ficha.Text);
                    per.Forv_Ficha = Convert.ToInt32(tbox_Forv_Ficha.Text);
                    per.Inte_Ficha = Convert.ToInt32(tbox_Inte_Ficha.Text);
                    per.Xp_Ficha = Convert.ToInt32(tbox_Xp_Ficha.Text);
                    per.Def_Ficha = tbox_Def_Ficha.Text;
                    per.Apt_Ficha = tbox_Apt_Ficha.Text;
                    per.Ant_Ficha = tbox_Ant_Ficha.Text;





                    SqlConnection con = new SqlConnection(BDConnection.ConnectionPath);
                    con.Open();
                    string sql = "UPDATE TB_FICHA SET S_PER_FICHA=@S_PER_FICHA, S_CLAS_FICHA=@S_CLAS_FICHA, I_VIG_FICHA=@I_VIG_FICHA," +
                        "I_AGIL_FICHA=@I_AGIL_FICHA, I_FOR_FICHA=@I_FOR_FICHA, I_VEL_FICHA=@I_VEL_FICHA, I_PERC_FICHA=@I_PERC_FICHA, " +
                        "S_TAM_FICHA=@S_TAM_FICHA, I_CAR_FICHA=@I_CAR_FICHA, I_FORV_FICHA=@I_FORV_FICHA, I_INTE_FICHA=@I_INTE_FICHA,   " +
                        "I_XP_FICHA=@I_XP_FICHA, S_DEF_FICHA=@S_DEF_FICHA, S_APT_FICHA=@S_APT_FICHA, S_ANT_FICHA=@S_ANT_FICHA       " +
                        "WHERE I_COD_FICHA= @I_COD_FICHA";
                    SqlCommand tela = new SqlCommand(sql, con);



                    tela.Parameters.Add("@S_PER_FICHA", SqlDbType.VarChar).Value = per.Per_Ficha;
                    tela.Parameters.Add("@S_CLAS_FICHA", SqlDbType.VarChar).Value = per.Clas_Ficha;
                    tela.Parameters.Add("@I_VIG_FICHA", SqlDbType.Int).Value = per.Vig_Ficha;
                    tela.Parameters.Add("@I_AGIL_FICHA", SqlDbType.Int).Value = per.Agil_Ficha;
                    tela.Parameters.Add("@I_FOR_FICHA", SqlDbType.Int).Value = per.For_Ficha;
                    tela.Parameters.Add("@I_VEL_FICHA", SqlDbType.Int).Value = per.Vel_Ficha;
                    tela.Parameters.Add("@I_PERC_FICHA", SqlDbType.Int).Value = per.Perc_Ficha;
                    tela.Parameters.Add("@S_TAM_FICHA", SqlDbType.VarChar).Value = per.Tam_Ficha;
                    tela.Parameters.Add("@I_CAR_FICHA", SqlDbType.Int).Value = per.Car_Ficha;
                    tela.Parameters.Add("@I_FORV_FICHA", SqlDbType.Int).Value = per.Forv_Ficha;
                    tela.Parameters.Add("@I_INTE_FICHA", SqlDbType.Int).Value = per.Inte_Ficha;
                    tela.Parameters.Add("@I_XP_FICHA", SqlDbType.Int).Value = per.Xp_Ficha;
                    tela.Parameters.Add("@S_DEF_FICHA", SqlDbType.VarChar).Value = per.Def_Ficha;
                    tela.Parameters.Add("@S_APT_FICHA", SqlDbType.VarChar).Value = per.Apt_Ficha;
                    tela.Parameters.Add("@S_ANT_FICHA", SqlDbType.VarChar).Value = per.Ant_Ficha;
                    tela.Parameters.Add("@I_COD_FICHA", SqlDbType.Int).Value = per.Cod_Ficha;

                    tela.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Personagem alterado com sucesso!");
                    AtualizarGrid();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao alterar Personagem!" + erro.Message);
            }
        }
        private void Ficha_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
            btn_Excluir.Enabled = false;
            btn_Alt_Ficha.Enabled = false;
            btn_Calc.Enabled = false;
        }

        private void btn_Calc_Click(object sender, EventArgs e)
        {
            Calc calculadora = new Calc();
            calculadora.Show();
        }
        private int RollDice(int faces)
        {
            return random.Next(1, faces + 1);
        }

        private void LimparDados()
        {
            lb_Resultadod6.Text = string.Empty;
            lb_Resultadod10.Text = string.Empty;
            lb_Resultadod20.Text = string.Empty;

        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            LimparDados();
        }

        private void btn_D6_Click(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.Button button && button == btn_D6)
            {
                faces = 6;
                lb_Resultadod6.Text = RollDice(faces).ToString();
            }
        }

        private void btn_D10_Click(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.Button button && button == btn_D10)
            {
                faces = 10;
                lb_Resultadod10.Text = RollDice(faces).ToString();
            }
        }

        private void btn_D20_Click(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.Button button && button == btn_D20)
            {
                faces = 20;
                lb_Resultadod20.Text = RollDice(faces).ToString();
            }
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {

            try
            {
                int codigoFicha = Convert.ToInt32(tbox_Cod_Ficha.Text);

                using (SqlConnection con = new SqlConnection(BDConnection.ConnectionPath))
                {
                    con.Open();

                    string sql = "DELETE FROM TB_FICHA WHERE I_COD_FICHA = @I_COD_FICHA";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@I_COD_FICHA", codigoFicha);
                        int exc = cmd.ExecuteNonQuery();

                        DialogResult res = MessageBox.Show("Tem certeza de que deseja excluir?",
                   "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (res == DialogResult.Yes)
                        {
                            MessageBox.Show("Personagem excluído com sucesso!");
                            LimparDados();
                            AtualizarGrid();
                            LimparFormulario();

                        }
                        else
                        {
                            MessageBox.Show("Nenhum personagem encontrado com o código especificado.");
                        }
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao excluir personagem: " + erro.Message);
            }

        }
        private void LimparFormulario()
        {
            tbox_Cod_Ficha.Clear();
            tbox_Per_Ficha.Clear();
            cbbox_Clas_Ficha.SelectedIndex = -1;
            tbox_Vig_Ficha.Clear();
            tbox_Agil_Ficha.Clear();
            tbox_For_Ficha.Clear();
            tbox_Vel_Ficha.Clear();
            tbox_Perc_Ficha.Clear();
            cbbox_Tam_Ficha.SelectedIndex = -1;
            tbox_Car_Ficha.Clear();
            tbox_Forv_Ficha.Clear();
            tbox_Inte_Ficha.Clear();
            tbox_Xp_Ficha.Clear();
            tbox_Def_Ficha.Clear();
            tbox_Apt_Ficha.Clear();
            tbox_Ant_Ficha.Clear();

            tbox_Per_Ficha.Focus();

        }

    }
}



