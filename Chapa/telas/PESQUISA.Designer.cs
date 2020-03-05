namespace Chapa.telas
{
    partial class PESQUISA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PESQUISA));
            this.gdvCliente = new System.Windows.Forms.DataGridView();
            this.btnPesq = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // gdvCliente
            // 
            this.gdvCliente.AllowUserToAddRows = false;
            this.gdvCliente.AllowUserToDeleteRows = false;
            this.gdvCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvCliente.Location = new System.Drawing.Point(31, 117);
            this.gdvCliente.Margin = new System.Windows.Forms.Padding(4);
            this.gdvCliente.Name = "gdvCliente";
            this.gdvCliente.ReadOnly = true;
            this.gdvCliente.Size = new System.Drawing.Size(740, 308);
            this.gdvCliente.TabIndex = 7;
            this.gdvCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdvCliente_CellDoubleClick);
            // 
            // btnPesq
            // 
            this.btnPesq.BackColor = System.Drawing.Color.White;
            this.btnPesq.Image = global::Chapa.Properties.Resources.Botoes_Site_5739_Knob_Search;
            this.btnPesq.Location = new System.Drawing.Point(704, 39);
            this.btnPesq.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesq.Name = "btnPesq";
            this.btnPesq.Size = new System.Drawing.Size(67, 48);
            this.btnPesq.TabIndex = 6;
            this.btnPesq.UseVisualStyleBackColor = false;
            this.btnPesq.Click += new System.EventHandler(this.btnPesq_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "DIGITE O NOME NO CAMPO ABAIXO OU CLIQUE NA LUPA";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(31, 42);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesquisa.Multiline = true;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(665, 45);
            this.txtPesquisa.TabIndex = 4;
            // 
            // PESQUISA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gdvCliente);
            this.Controls.Add(this.btnPesq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PESQUISA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PESQUISA";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.gdvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gdvCliente;
        private System.Windows.Forms.Button btnPesq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisa;
    }
}