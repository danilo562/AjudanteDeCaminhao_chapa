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
    public partial class CadastrarCaminhao : Form
    {
        SQLiteConnection conexao = new SQLiteConnection(@"Data Source=" + System.AppDomain.CurrentDomain.BaseDirectory.ToString() + System.Configuration.ConfigurationManager.ConnectionStrings["DWC"].ConnectionString.ToString());
        SQLiteCommand cmd;
        SQLiteDataReader dr;

        public CadastrarCaminhao(string idUsu)
        {
            InitializeComponent();
            lbIdusu.Text = idUsu;
            caminhaoCadastrados(conexao);
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("TEM CERTEZA QUE DESEJA CADASTRAR ESTE CAMINHÃO?", "DW NEW SOFTWARE",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
     == DialogResult.Yes)
            {

                if (txtPlaca.Text.Length == 8)
                {
                    if (txtNome.Text != "")
                    {

                        cadastrarCaminhao();
                        limpaCampos();
                    }
                    else
                    {
                        MessageBox.Show("INFORME O MARCA/MODELO DO CAMINHAO.");
                    }

                }
                else
                {
                    MessageBox.Show("INFORME A PLACA.");
                }

            }
        }

        public void caminhaoCadastrados(SQLiteConnection conexao)
        {
            if (conexao.State == ConnectionState.Closed) //Validar a conexão
            {
                conexao.Open();
            }

            //este metodo esta carregando os nome dos modulos
            try
            {

                SQLiteDataAdapter ADAP = new SQLiteDataAdapter("select idcaminhao as ID,placa as PLACA,tipo as TIPO_CAMINHÃO,nome as NOME_CAMINHÃO,chassi as CHASSI,obs as OBS,dtcad as DATA_CADASTRO from caminhao where delet=''", conexao);

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

        private void CadastrarCaminhao_Load(object sender, EventArgs e)
        {

        }

        public void cadastrarCaminhao()
        {
            if (conexao.State == ConnectionState.Closed) //Validar a conexão
            {
                conexao.Open();
            }
            try
            {

                string sql = "insert into caminhao (nome,placa,tipo,obs,idusu,dtcad,delet,chassi)values('" + 
                       txtNome.Text + "','" + txtPlaca.Text + "','" + cbTipo.Text + "','"+txtObs.Text+"','"+lbIdusu.Text+"' ,datetime('now'),'','" + txtChassi.Text + "')";

                SQLiteCommand cmd1 = new SQLiteCommand(sql, conexao);

                cmd1.ExecuteNonQuery();
                caminhaoCadastrados(conexao);
                MessageBox.Show("CAMINHÃO CADASTRADO COM SUCESSO.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conexao.Close();

        }

        private void btnAlt_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("TEM CERTEZA QUE DESEJA ALTERAR AS INFORMAÇÕES DESTE CAMINHÃO?", "DW NEW SOFTWARE",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
     == DialogResult.Yes)
            {
                if (txtValidar.Text == "")
                {
                    MessageBox.Show("SELECIONE PRIMEIRO UM CAMINHÃO PARA EDITAR");
                }
                else
                {

                    if (txtPlaca.Text.Length == 8)
                    {


                        alterarCaminhao();
                       limpaCampos();


                    }
                    else
                    {
                        MessageBox.Show("A PLACA DEVE CONTER 8 DIGITOS.");
                    }

                }
            }//primeiro if
        }

        public void alterarCaminhao()
        {
            if (conexao.State == ConnectionState.Closed) //Validar a conexão
            {
                conexao.Open();
            }
            try
            {

                string sql = "update caminhao set nome='"+ txtNome.Text + "',placa='" + txtPlaca.Text + "',tipo='" + cbTipo.Text + "',obs='" + txtObs.Text + "',idusu='" + lbIdusu.Text + "' ,dtcad=datetime('now'),chassi='" + txtChassi.Text + "' where idcaminhao='"+txtIdcaminhao.Text+"'";
                SQLiteCommand cmd1 = new SQLiteCommand(sql, conexao);

                cmd1.ExecuteNonQuery();
                caminhaoCadastrados(conexao);
                MessageBox.Show("CAMINHÃO ALTERADO COM SUCESSO.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conexao.Close();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNome.Text = (dataGridView1.CurrentRow.Cells[3].Value).ToString();
            txtChassi.Text = (dataGridView1.CurrentRow.Cells[4].Value).ToString();
            txtObs.Text = (dataGridView1.CurrentRow.Cells[5].Value).ToString();
            cbTipo.Text = (dataGridView1.CurrentRow.Cells[2].Value).ToString();
            txtPlaca.Text = (dataGridView1.CurrentRow.Cells[1].Value).ToString();
            txtIdcaminhao.Text = (dataGridView1.CurrentRow.Cells[0].Value).ToString();
            txtValidar.Text = "SIM";
        }

        private void btnExclu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("TEM CERTEZA QUE DESEJA EXCLUIR ESTE CAMINHÃO?", "DW NEW SOFTWARE",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    == DialogResult.Yes)
            {
                if (txtValidar.Text == "")
                {
                    MessageBox.Show("SELECIONE PRIMEIRO UM CAMINHÃO PARA EXCLUIR");
                }
                else
                {



                    deletarCaminhao();
                    limpaCampos();


                }



            }//primeiro if
        }

        public void deletarCaminhao()
        {
            if (conexao.State == ConnectionState.Closed) //Validar a conexão
            {
                conexao.Open();
            }
            try
            {

                string sql = "update  caminhao set delet ='*' where idcaminhao='" + txtIdcaminhao.Text + "'";

                SQLiteCommand cmd1 = new SQLiteCommand(sql, conexao);

                cmd1.ExecuteNonQuery();
                caminhaoCadastrados(conexao);
                limpaCampos();
                MessageBox.Show("CAMINHÃO DELETADO COM SUCESSO.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conexao.Close();

        }

        public void limpaCampos() {
            txtNome.Text = "";
            txtChassi.Text = "";
            txtObs.Text = "";
            cbTipo.Text = "";
            txtPlaca.Text = "";
            txtIdcaminhao.Text = "";
            txtValidar.Text = "";

        }



    }
}
