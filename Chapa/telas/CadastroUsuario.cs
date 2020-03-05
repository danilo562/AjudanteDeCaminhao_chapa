using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace Chapa.telas
{
    public partial class CadastroUsuario : Form
    {

        SQLiteConnection conexao = new SQLiteConnection(@"Data Source=" + System.AppDomain.CurrentDomain.BaseDirectory.ToString() + System.Configuration.ConfigurationManager.ConnectionStrings["DWC"].ConnectionString.ToString());
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        public CadastroUsuario()
        {
            InitializeComponent();
            usuariosCadastrados(conexao);
        }

     

        public void cadastrarUsuario()
        {
            if (conexao.State == ConnectionState.Closed) //Validar a conexão
            {
                conexao.Open();
            }
            try
            {

                string sql = "insert into usuario (nome,login,senha,dtcreat,delet,email)values('"+txtNome.Text+"','"+txtLogin.Text+"','"+txtSenha.Text+"',datetime('now'),'','"+txtEmail.Text+"')";

                SQLiteCommand cmd1 = new SQLiteCommand(sql, conexao);

                cmd1.ExecuteNonQuery();
                usuariosCadastrados(conexao);
                MessageBox.Show("USUÁRIO CADASTRADO COM SUCESSO.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conexao.Close();

        }


        public void usuariosCadastrados(SQLiteConnection conexao)
        {
            if (conexao.State == ConnectionState.Closed) //Validar a conexão
            {
                conexao.Open();
            }

            //este metodo esta carregando os nome dos modulos
            try
            {

                SQLiteDataAdapter ADAP = new SQLiteDataAdapter("select * from usuario where delet=''", conexao);

                //Inicializa o  Dataset.
                DataSet DS = new DataSet();

                //Preenche o dataset com a tabela Imagens
                ADAP.Fill(DS, "CodB");

                dataGridView1.DataSource = DS.Tables["CodB"];

               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conexao.Close();
        }

        private void btnCad_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("CADASTRAR USUÁRIO", btnCad);
        }

        private void btnAlt_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("ALTERAR INFORMAÇÔES DE USUÁRIO", btnAlt);
        }

        private void btnExclu_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("EXCLUIR USUÁRIO", btnExclu);
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("TEM CERTEZA QUE DESEJA CADASTRAR ESTE USUARIO?", "DW NEW SOFTWARE",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question)
       == DialogResult.Yes)
            {

                if (txtSenha.Text == txtConfSenha.Text)
                {
                    if (txtLogin.Text != "")
                    {

                        cadastrarUsuario();
                        limpaCampos();
                    }
                    else
                    {
                        MessageBox.Show("INFORME O LOGIN.");
                    }

                }
                else {
                    MessageBox.Show("AS DUAS SENHAS DEVEM SER IGUAIS.");
                }
            
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNome.Text = (dataGridView1.CurrentRow.Cells[1].Value).ToString();
            txtEmail.Text = (dataGridView1.CurrentRow.Cells[6].Value).ToString();
            txtLogin.Text = (dataGridView1.CurrentRow.Cells[2].Value).ToString();
            txtSenha.Text = (dataGridView1.CurrentRow.Cells[3].Value).ToString();
            lbIdusu.Text = (dataGridView1.CurrentRow.Cells[0].Value).ToString();
            txtValidar.Text = "SIM";
        }

        private void btnAlt_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("TEM CERTEZA QUE DESEJA ALTERAR ESTE USUARIO?", "DW NEW SOFTWARE",
      MessageBoxButtons.YesNo, MessageBoxIcon.Question)
      == DialogResult.Yes)
            {
                if (txtValidar.Text == "")
                {
                    MessageBox.Show("SELECIONE PRIMEIRO UM USUÁRIO PARA EDITAR");
                }
                else
                {

                    if (txtSenha.Text == txtConfSenha.Text)
                    {
                        

                            alterarUsuario();
                            limpaCampos();
                      

                    }
                    else
                    {
                        MessageBox.Show("AS DUAS SENHAS DEVEM SER IGUAIS.");
                    }

                }
            }//primeiro if

          
        }


        public void alterarUsuario()
        {
            if (conexao.State == ConnectionState.Closed) //Validar a conexão
            {
                conexao.Open();
            }
            try
            {

                string sql = "update  usuario set nome ='" + txtNome.Text + "',login ='" + txtLogin.Text + "',senha='" + txtSenha.Text + "',dtcreat=datetime('now'),email ='"+txtEmail.Text+"' where idusu='"+lbIdusu.Text+"'";

                SQLiteCommand cmd1 = new SQLiteCommand(sql, conexao);

                cmd1.ExecuteNonQuery();
                usuariosCadastrados(conexao);
                MessageBox.Show("USUÁRIO ALTERADO COM SUCESSO.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conexao.Close();

        }

        public void deletarUsuario()
        {
            if (conexao.State == ConnectionState.Closed) //Validar a conexão
            {
                conexao.Open();
            }
            try
            {

                string sql = "update  usuario set delet ='*' where idusu='" + lbIdusu.Text + "'";

                SQLiteCommand cmd1 = new SQLiteCommand(sql, conexao);

                cmd1.ExecuteNonQuery();
                usuariosCadastrados(conexao);
                MessageBox.Show("USUÁRIO DELETADO COM SUCESSO.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conexao.Close();

        }

        private void btnExclu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("TEM CERTEZA QUE DESEJA EXCLUIR ESTE USUARIO?", "DW NEW SOFTWARE",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    == DialogResult.Yes)
            {
                if (txtValidar.Text == "")
                {
                    MessageBox.Show("SELECIONE PRIMEIRO UM USUÁRIO PARA EXCLUIR");
                }
                else
                {

                   

                        deletarUsuario();
                        limpaCampos();


                   }
                  

                
            }//primeiro if
           
        }


        public void limpaCampos() {
            txtNome.Text = "";
            txtLogin.Text = "";
            txtSenha.Text = "";
            txtConfSenha.Text = "";
            txtEmail.Text = "";
            txtValidar.Text = "";
            lbIdusu.Text = "";


        }

        

      
    }
}
