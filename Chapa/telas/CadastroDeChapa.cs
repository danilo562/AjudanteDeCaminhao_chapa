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
    public partial class CadastroDeChapa : Form
    {
        SQLiteConnection conexao = new SQLiteConnection(@"Data Source=" + System.AppDomain.CurrentDomain.BaseDirectory.ToString() + System.Configuration.ConfigurationManager.ConnectionStrings["DWC"].ConnectionString.ToString());
        SQLiteCommand cmd;
        SQLiteDataReader dr;


        public CadastroDeChapa(string idUsu)
        {
            InitializeComponent();
            lbIdusu.Text = idUsu;
            chapaCadastrados(conexao);
        }


        private void btnCad_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("TEM CERTEZA QUE DESEJA CADASTRAR ESTE CHAPA?", "DW NEW SOFTWARE",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    == DialogResult.Yes)
            {

                if (txtNome.Text != "")
                {
                   
                        cadastrarChapa();
                         limpaCampos();
                   

                }
                else
                {
                    MessageBox.Show("INFORME O NOME.");
                }

            }
        }

        public void cadastrarChapa()
        {
            if (conexao.State == ConnectionState.Closed) //Validar a conexão
            {
                conexao.Open();
            }
            try
            {

                string sql = "insert into chapa (nome,rg,cpf,tel,idusu,dtcad,delet)values('" +
                       txtNome.Text + "','" + txtRg.Text + "','" + txtCpf.Text + "','" + txtTel.Text + "','" + lbIdusu.Text + "' ,datetime('now'),'')";

                SQLiteCommand cmd1 = new SQLiteCommand(sql, conexao);

                cmd1.ExecuteNonQuery();
                chapaCadastrados(conexao);
                MessageBox.Show("CAMINHÃO CADASTRADO COM SUCESSO.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conexao.Close();

        }

        public void chapaCadastrados(SQLiteConnection conexao)
        {
            if (conexao.State == ConnectionState.Closed) //Validar a conexão
            {
                conexao.Open();
            }

            //este metodo esta carregando os nome dos modulos
            try
            {

                SQLiteDataAdapter ADAP = new SQLiteDataAdapter("select idchapa as ID,nome as NOME,rg as RG,cpf as CPF,tel as TEL_CEL,dtcad as DATA_CAD from chapa where delet=''", conexao);

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

        private void btnAlt_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("TEM CERTEZA QUE DESEJA ALTERAR AS INFORMAÇÕES DESTE CHAPA?", "DW NEW SOFTWARE",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    == DialogResult.Yes)
            {
                if (txtValidar.Text == "")
                {
                    MessageBox.Show("SELECIONE PRIMEIRO UM CHAPA PARA EDITAR");
                }
                else
                {

                    if (txtNome.Text != "")
                    {


                        alterarChapa();
                             limpaCampos();


                    }
                    else
                    {
                        MessageBox.Show("INFORME O NOME DO CHAPA.");
                    }

                }
            }//primeiro if
        }

        public void alterarChapa()
        {
            if (conexao.State == ConnectionState.Closed) //Validar a conexão
            {
                conexao.Open();
            }
            try
            {

                string sql = "update chapa set nome='"+txtNome.Text + "',rg='" + txtRg.Text + "',cpf='" + txtCpf.Text + "',tel='" + txtTel.Text + "',idusu='" + lbIdusu.Text + "' ,dtcad=datetime('now'),delet='' where idchapa='"+ txtIdChapa.Text+"'";

                SQLiteCommand cmd1 = new SQLiteCommand(sql, conexao);

                cmd1.ExecuteNonQuery();
                chapaCadastrados(conexao);
                MessageBox.Show("CHAPA ALTERADO COM SUCESSO.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conexao.Close();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNome.Text = (dataGridView1.CurrentRow.Cells[1].Value).ToString();
            txtRg.Text = (dataGridView1.CurrentRow.Cells[2].Value).ToString();
            txtCpf.Text = (dataGridView1.CurrentRow.Cells[3].Value).ToString();
            txtTel.Text = (dataGridView1.CurrentRow.Cells[4].Value).ToString();
            txtIdChapa.Text = (dataGridView1.CurrentRow.Cells[0].Value).ToString();
            txtValidar.Text = "SIM";
        }

        private void btnExclu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("TEM CERTEZA QUE DESEJA EXCLUIR ESTE CHAPA?", "DW NEW SOFTWARE",
  MessageBoxButtons.YesNo, MessageBoxIcon.Question)
  == DialogResult.Yes)
            {
                if (txtValidar.Text == "")
                {
                    MessageBox.Show("SELECIONE PRIMEIRO UM CHAPA PARA EXCLUIR");
                }
                else
                {



                    deletarChapa();
                      limpaCampos();


                }



            }//primeiro if
        }

        public void deletarChapa()
        {
            if (conexao.State == ConnectionState.Closed) //Validar a conexão
            {
                conexao.Open();
            }
            try
            {

                string sql = "update  chapa set delet ='*' where idchapa='" + txtIdChapa.Text + "'";

                SQLiteCommand cmd1 = new SQLiteCommand(sql, conexao);

                cmd1.ExecuteNonQuery();
                chapaCadastrados(conexao);
                MessageBox.Show("CHAPA DELETADO COM SUCESSO.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conexao.Close();

        }


        public void limpaCampos() {
            txtNome.Text = "";
            txtRg.Text = "";
            txtCpf.Text = "";
            txtTel.Text = "";
            txtIdChapa.Text = "";
            txtValidar.Text = "";

        }







    }


}
