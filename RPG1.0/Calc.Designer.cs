namespace RPG1._0
{
    partial class Calc
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_Total = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Dividir = new System.Windows.Forms.Button();
            this.btn_Multiplicar = new System.Windows.Forms.Button();
            this.btn_Subtrair = new System.Windows.Forms.Button();
            this.btn_Somar = new System.Windows.Forms.Button();
            this.tbox_Val2 = new System.Windows.Forms.TextBox();
            this.tbox_Val1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RPG1._0.Properties.Resources.calculadora;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 159);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lb_Total
            // 
            this.lb_Total.AutoSize = true;
            this.lb_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Total.Location = new System.Drawing.Point(82, 134);
            this.lb_Total.Name = "lb_Total";
            this.lb_Total.Size = new System.Drawing.Size(16, 16);
            this.lb_Total.TabIndex = 21;
            this.lb_Total.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Khaki;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Total=";
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_Limpar.Location = new System.Drawing.Point(134, 99);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(54, 23);
            this.btn_Limpar.TabIndex = 19;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = false;
            // 
            // btn_Dividir
            // 
            this.btn_Dividir.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_Dividir.Location = new System.Drawing.Point(104, 99);
            this.btn_Dividir.Name = "btn_Dividir";
            this.btn_Dividir.Size = new System.Drawing.Size(24, 23);
            this.btn_Dividir.TabIndex = 18;
            this.btn_Dividir.Text = "/";
            this.btn_Dividir.UseVisualStyleBackColor = false;
            // 
            // btn_Multiplicar
            // 
            this.btn_Multiplicar.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_Multiplicar.Location = new System.Drawing.Point(74, 99);
            this.btn_Multiplicar.Name = "btn_Multiplicar";
            this.btn_Multiplicar.Size = new System.Drawing.Size(24, 23);
            this.btn_Multiplicar.TabIndex = 17;
            this.btn_Multiplicar.Text = "x";
            this.btn_Multiplicar.UseVisualStyleBackColor = false;
            // 
            // btn_Subtrair
            // 
            this.btn_Subtrair.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_Subtrair.Location = new System.Drawing.Point(44, 99);
            this.btn_Subtrair.Name = "btn_Subtrair";
            this.btn_Subtrair.Size = new System.Drawing.Size(24, 23);
            this.btn_Subtrair.TabIndex = 16;
            this.btn_Subtrair.Text = "-";
            this.btn_Subtrair.UseVisualStyleBackColor = false;
            // 
            // btn_Somar
            // 
            this.btn_Somar.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_Somar.Location = new System.Drawing.Point(14, 99);
            this.btn_Somar.Name = "btn_Somar";
            this.btn_Somar.Size = new System.Drawing.Size(24, 23);
            this.btn_Somar.TabIndex = 15;
            this.btn_Somar.Text = "+";
            this.btn_Somar.UseVisualStyleBackColor = false;
            // 
            // tbox_Val2
            // 
            this.tbox_Val2.Location = new System.Drawing.Point(14, 73);
            this.tbox_Val2.Name = "tbox_Val2";
            this.tbox_Val2.Size = new System.Drawing.Size(100, 20);
            this.tbox_Val2.TabIndex = 14;
            // 
            // tbox_Val1
            // 
            this.tbox_Val1.Location = new System.Drawing.Point(14, 23);
            this.tbox_Val1.Name = "tbox_Val1";
            this.tbox_Val1.Size = new System.Drawing.Size(100, 20);
            this.tbox_Val1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Khaki;
            this.label2.Location = new System.Drawing.Point(14, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Valor 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(14, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Valor 1:";
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 156);
            this.Controls.Add(this.lb_Total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Dividir);
            this.Controls.Add(this.btn_Multiplicar);
            this.Controls.Add(this.btn_Subtrair);
            this.Controls.Add(this.btn_Somar);
            this.Controls.Add(this.tbox_Val2);
            this.Controls.Add(this.tbox_Val1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(1500, 250);
            this.Name = "Calc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_Total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_Dividir;
        private System.Windows.Forms.Button btn_Multiplicar;
        private System.Windows.Forms.Button btn_Subtrair;
        private System.Windows.Forms.Button btn_Somar;
        private System.Windows.Forms.TextBox tbox_Val2;
        private System.Windows.Forms.TextBox tbox_Val1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}