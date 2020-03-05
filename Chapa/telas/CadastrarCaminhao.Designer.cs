namespace Chapa.telas
{
    partial class CadastrarCaminhao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarCaminhao));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExclu = new System.Windows.Forms.Button();
            this.btnAlt = new System.Windows.Forms.Button();
            this.btnCad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.LB = new System.Windows.Forms.Label();
            this.txtChassi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValidar = new System.Windows.Forms.TextBox();
            this.lbIdusu = new System.Windows.Forms.Label();
            this.txtIdcaminhao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 303);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(918, 239);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnExclu
            // 
            this.btnExclu.Image = global::Chapa.Properties.Resources.B_VERMELHA;
            this.btnExclu.Location = new System.Drawing.Point(865, 239);
            this.btnExclu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExclu.Name = "btnExclu";
            this.btnExclu.Size = new System.Drawing.Size(65, 60);
            this.btnExclu.TabIndex = 17;
            this.btnExclu.Tag = "CADASTRAR";
            this.btnExclu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExclu.UseVisualStyleBackColor = true;
            this.btnExclu.Click += new System.EventHandler(this.btnExclu_Click);
            // 
            // btnAlt
            // 
            this.btnAlt.Image = global::Chapa.Properties.Resources.B_AZUL;
            this.btnAlt.Location = new System.Drawing.Point(777, 239);
            this.btnAlt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlt.Name = "btnAlt";
            this.btnAlt.Size = new System.Drawing.Size(65, 60);
            this.btnAlt.TabIndex = 16;
            this.btnAlt.Tag = "ALTERAR";
            this.btnAlt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAlt.UseVisualStyleBackColor = true;
            this.btnAlt.Click += new System.EventHandler(this.btnAlt_Click);
            // 
            // btnCad
            // 
            this.btnCad.Image = global::Chapa.Properties.Resources.B_VERDE;
            this.btnCad.Location = new System.Drawing.Point(691, 239);
            this.btnCad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(65, 60);
            this.btnCad.TabIndex = 15;
            this.btnCad.Tag = "CADASTRAR";
            this.btnCad.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "NOME";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(12, 31);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(903, 34);
            this.txtNome.TabIndex = 1;
            // 
            // LB
            // 
            this.LB.AutoSize = true;
            this.LB.Location = new System.Drawing.Point(9, 74);
            this.LB.Name = "LB";
            this.LB.Size = new System.Drawing.Size(57, 17);
            this.LB.TabIndex = 21;
            this.LB.Text = "CHASSI";
            // 
            // txtChassi
            // 
            this.txtChassi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChassi.Location = new System.Drawing.Point(12, 94);
            this.txtChassi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChassi.Multiline = true;
            this.txtChassi.Name = "txtChassi";
            this.txtChassi.Size = new System.Drawing.Size(903, 34);
            this.txtChassi.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "OBSERVAÇÕES";
            // 
            // txtObs
            // 
            this.txtObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObs.Location = new System.Drawing.Point(12, 152);
            this.txtObs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(368, 130);
            this.txtObs.TabIndex = 5;
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "TOCO",
            "TRUCK",
            "CARRETA 2 EIXOS",
            "CARRETA BAÚ",
            "CARRETA 3 EIXOS",
            "CARRETA CAVALO TRUCKADO",
            "CARRETA CAVALO TRUCKADO BAÚ",
            "BI-TREM 7 EIXOS"});
            this.cbTipo.Location = new System.Drawing.Point(386, 152);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(390, 33);
            this.cbTipo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "TIPO DO CAMINHÃO";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.Location = new System.Drawing.Point(386, 222);
            this.txtPlaca.Mask = "LLL-0000";
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(162, 38);
            this.txtPlaca.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(386, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "PLACA";
            // 
            // txtValidar
            // 
            this.txtValidar.Location = new System.Drawing.Point(882, 163);
            this.txtValidar.Margin = new System.Windows.Forms.Padding(4);
            this.txtValidar.Name = "txtValidar";
            this.txtValidar.Size = new System.Drawing.Size(24, 22);
            this.txtValidar.TabIndex = 28;
            this.txtValidar.Visible = false;
            // 
            // lbIdusu
            // 
            this.lbIdusu.AutoSize = true;
            this.lbIdusu.Location = new System.Drawing.Point(878, 143);
            this.lbIdusu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIdusu.Name = "lbIdusu";
            this.lbIdusu.Size = new System.Drawing.Size(42, 17);
            this.lbIdusu.TabIndex = 27;
            this.lbIdusu.Text = "idusu";
            this.lbIdusu.Visible = false;
            // 
            // txtIdcaminhao
            // 
            this.txtIdcaminhao.AutoSize = true;
            this.txtIdcaminhao.Location = new System.Drawing.Point(873, 189);
            this.txtIdcaminhao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtIdcaminhao.Name = "txtIdcaminhao";
            this.txtIdcaminhao.Size = new System.Drawing.Size(42, 17);
            this.txtIdcaminhao.TabIndex = 29;
            this.txtIdcaminhao.Text = "idusu";
            this.txtIdcaminhao.Visible = false;
            // 
            // CadastrarCaminhao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(942, 553);
            this.Controls.Add(this.txtIdcaminhao);
            this.Controls.Add(this.txtValidar);
            this.Controls.Add(this.lbIdusu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.LB);
            this.Controls.Add(this.txtChassi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnExclu);
            this.Controls.Add(this.btnAlt);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastrarCaminhao";
            this.Text = "CadastrarCaminhao";
            this.Load += new System.EventHandler(this.CadastrarCaminhao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExclu;
        private System.Windows.Forms.Button btnAlt;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label LB;
        private System.Windows.Forms.TextBox txtChassi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtPlaca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValidar;
        private System.Windows.Forms.Label lbIdusu;
        private System.Windows.Forms.Label txtIdcaminhao;
    }
}