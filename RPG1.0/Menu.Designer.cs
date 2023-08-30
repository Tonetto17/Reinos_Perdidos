namespace RPG1._0
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAbrirFicha = new System.Windows.Forms.Button();
            this.btnSelecionarImagem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox98 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox98)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(421, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 574);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seu personagem:";
            // 
            // btnAbrirFicha
            // 
            this.btnAbrirFicha.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAbrirFicha.Location = new System.Drawing.Point(932, 716);
            this.btnAbrirFicha.Name = "btnAbrirFicha";
            this.btnAbrirFicha.Size = new System.Drawing.Size(94, 57);
            this.btnAbrirFicha.TabIndex = 9;
            this.btnAbrirFicha.Text = "Entrar ";
            this.btnAbrirFicha.UseVisualStyleBackColor = false;
            this.btnAbrirFicha.Click += new System.EventHandler(this.btnAbrirFicha_Click);
            // 
            // btnSelecionarImagem
            // 
            this.btnSelecionarImagem.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSelecionarImagem.Location = new System.Drawing.Point(797, 716);
            this.btnSelecionarImagem.Name = "btnSelecionarImagem";
            this.btnSelecionarImagem.Size = new System.Drawing.Size(94, 57);
            this.btnSelecionarImagem.TabIndex = 8;
            this.btnSelecionarImagem.Text = "Upload";
            this.btnSelecionarImagem.UseVisualStyleBackColor = false;
            this.btnSelecionarImagem.Click += new System.EventHandler(this.btnSelecionarImagem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RosyBrown;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(434, 729);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Faça o upload da sua imagem:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(593, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seja bem vinda(o)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(51, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(537, 492);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox98
            // 
            this.pictureBox98.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox98.Enabled = false;
            this.pictureBox98.Image = global::RPG1._0.Properties.Resources.Reinos_Perdidos;
            this.pictureBox98.Location = new System.Drawing.Point(0, 0);
            this.pictureBox98.Name = "pictureBox98";
            this.pictureBox98.Size = new System.Drawing.Size(1276, 852);
            this.pictureBox98.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox98.TabIndex = 0;
            this.pictureBox98.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 852);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAbrirFicha);
            this.Controls.Add(this.btnSelecionarImagem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox98);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox98)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox98;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAbrirFicha;
        private System.Windows.Forms.Button btnSelecionarImagem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}