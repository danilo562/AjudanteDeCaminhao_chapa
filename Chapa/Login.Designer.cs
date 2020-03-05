namespace Chapa
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pgLoad = new System.Windows.Forms.ProgressBar();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Entrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtIDusu = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSenhaConsult = new System.Windows.Forms.TextBox();
            this.txtReConsult = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pgLoad
            // 
            this.pgLoad.Location = new System.Drawing.Point(194, 271);
            this.pgLoad.Margin = new System.Windows.Forms.Padding(4);
            this.pgLoad.Name = "pgLoad";
            this.pgLoad.Size = new System.Drawing.Size(133, 28);
            this.pgLoad.TabIndex = 73;
            this.pgLoad.Visible = false;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(134, 149);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.Multiline = true;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(276, 30);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 30);
            this.label2.TabIndex = 71;
            this.label2.Text = "SENHA";
            // 
            // Entrar
            // 
            this.Entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entrar.Location = new System.Drawing.Point(194, 202);
            this.Entrar.Margin = new System.Windows.Forms.Padding(4);
            this.Entrar.Name = "Entrar";
            this.Entrar.Size = new System.Drawing.Size(133, 44);
            this.Entrar.TabIndex = 3;
            this.Entrar.Text = "Entrar";
            this.Entrar.UseVisualStyleBackColor = true;
            this.Entrar.Click += new System.EventHandler(this.Entrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 35);
            this.label1.TabIndex = 70;
            this.label1.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Chapa.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(533, 379);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtLogin.Location = new System.Drawing.Point(134, 74);
            this.txtLogin.Multiline = true;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(276, 38);
            this.txtLogin.TabIndex = 1;
            // 
            // txtIDusu
            // 
            this.txtIDusu.Location = new System.Drawing.Point(856, 162);
            this.txtIDusu.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDusu.Name = "txtIDusu";
            this.txtIDusu.Size = new System.Drawing.Size(132, 22);
            this.txtIDusu.TabIndex = 78;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(686, 162);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(132, 22);
            this.txtNome.TabIndex = 77;
            // 
            // txtSenhaConsult
            // 
            this.txtSenhaConsult.Location = new System.Drawing.Point(787, 130);
            this.txtSenhaConsult.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenhaConsult.Name = "txtSenhaConsult";
            this.txtSenhaConsult.Size = new System.Drawing.Size(132, 22);
            this.txtSenhaConsult.TabIndex = 76;
            // 
            // txtReConsult
            // 
            this.txtReConsult.Location = new System.Drawing.Point(586, 130);
            this.txtReConsult.Margin = new System.Windows.Forms.Padding(4);
            this.txtReConsult.Name = "txtReConsult";
            this.txtReConsult.Size = new System.Drawing.Size(132, 22);
            this.txtReConsult.TabIndex = 75;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(586, 27);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(335, 85);
            this.dataGridView1.TabIndex = 74;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(542, 384);
            this.Controls.Add(this.txtIDusu);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtSenhaConsult);
            this.Controls.Add(this.txtReConsult);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.pgLoad);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Entrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar pgLoad;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Entrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtIDusu;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSenhaConsult;
        private System.Windows.Forms.TextBox txtReConsult;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}