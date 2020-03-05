namespace Chapa.telas
{
    partial class CadastroDeChapa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroDeChapa));
            this.btnExclu = new System.Windows.Forms.Button();
            this.btnAlt = new System.Windows.Forms.Button();
            this.btnCad = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtIdChapa = new System.Windows.Forms.Label();
            this.txtValidar = new System.Windows.Forms.TextBox();
            this.lbIdusu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.MaskedTextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExclu
            // 
            this.btnExclu.Image = global::Chapa.Properties.Resources.B_VERMELHA;
            this.btnExclu.Location = new System.Drawing.Point(855, 239);
            this.btnExclu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExclu.Name = "btnExclu";
            this.btnExclu.Size = new System.Drawing.Size(65, 60);
            this.btnExclu.TabIndex = 21;
            this.btnExclu.Tag = "CADASTRAR";
            this.btnExclu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExclu.UseVisualStyleBackColor = true;
            this.btnExclu.Click += new System.EventHandler(this.btnExclu_Click);
            // 
            // btnAlt
            // 
            this.btnAlt.Image = global::Chapa.Properties.Resources.B_AZUL;
            this.btnAlt.Location = new System.Drawing.Point(767, 239);
            this.btnAlt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlt.Name = "btnAlt";
            this.btnAlt.Size = new System.Drawing.Size(65, 60);
            this.btnAlt.TabIndex = 20;
            this.btnAlt.Tag = "ALTERAR";
            this.btnAlt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAlt.UseVisualStyleBackColor = true;
            this.btnAlt.Click += new System.EventHandler(this.btnAlt_Click);
            // 
            // btnCad
            // 
            this.btnCad.Image = global::Chapa.Properties.Resources.B_VERDE;
            this.btnCad.Location = new System.Drawing.Point(681, 239);
            this.btnCad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(65, 60);
            this.btnCad.TabIndex = 19;
            this.btnCad.Tag = "CADASTRAR";
            this.btnCad.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 303);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(918, 239);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txtIdChapa
            // 
            this.txtIdChapa.AutoSize = true;
            this.txtIdChapa.Location = new System.Drawing.Point(877, 211);
            this.txtIdChapa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtIdChapa.Name = "txtIdChapa";
            this.txtIdChapa.Size = new System.Drawing.Size(58, 17);
            this.txtIdChapa.TabIndex = 32;
            this.txtIdChapa.Text = "idchapa";
            this.txtIdChapa.Visible = false;
            // 
            // txtValidar
            // 
            this.txtValidar.Location = new System.Drawing.Point(886, 185);
            this.txtValidar.Margin = new System.Windows.Forms.Padding(4);
            this.txtValidar.Name = "txtValidar";
            this.txtValidar.Size = new System.Drawing.Size(24, 22);
            this.txtValidar.TabIndex = 31;
            this.txtValidar.Visible = false;
            // 
            // lbIdusu
            // 
            this.lbIdusu.AutoSize = true;
            this.lbIdusu.Location = new System.Drawing.Point(882, 165);
            this.lbIdusu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIdusu.Name = "lbIdusu";
            this.lbIdusu.Size = new System.Drawing.Size(42, 17);
            this.lbIdusu.TabIndex = 30;
            this.lbIdusu.Text = "idusu";
            this.lbIdusu.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "NOME";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(12, 30);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(903, 34);
            this.txtNome.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "RG";
            // 
            // txtRg
            // 
            this.txtRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRg.Location = new System.Drawing.Point(13, 104);
            this.txtRg.Mask = "00.000.000-a";
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(320, 30);
            this.txtRg.TabIndex = 38;
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(339, 104);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(372, 30);
            this.txtCpf.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "CPF";
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(15, 165);
            this.txtTel.Mask = "(00) 0 0000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(318, 30);
            this.txtTel.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "TELEFONE / CELULAR";
            // 
            // CadastroDeChapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtIdChapa);
            this.Controls.Add(this.txtValidar);
            this.Controls.Add(this.lbIdusu);
            this.Controls.Add(this.btnExclu);
            this.Controls.Add(this.btnAlt);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroDeChapa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroDeChapa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExclu;
        private System.Windows.Forms.Button btnAlt;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label txtIdChapa;
        private System.Windows.Forms.TextBox txtValidar;
        private System.Windows.Forms.Label lbIdusu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtRg;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.Label label2;
    }
}