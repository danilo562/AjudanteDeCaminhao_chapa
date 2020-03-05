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
    public partial class CadastroDeMotorista : Form
    {
        SQLiteConnection conexao = new SQLiteConnection(@"Data Source=" + System.AppDomain.CurrentDomain.BaseDirectory.ToString() + System.Configuration.ConfigurationManager.ConnectionStrings["DWC"].ConnectionString.ToString());
        SQLiteCommand cmd;
        SQLiteDataReader dr;


        public CadastroDeMotorista(string idUsu)
        {
            InitializeComponent();
            lbIdusu.Text = idUsu;
            motoristaCadastrados(conexao);
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("TEM CERTEZA QUE DESEJA CADASTRAR ESTE MOTORISTA?", "DW NEW SOFTWARE",
  MessageBoxButtons.YesNo, MessageBoxIcon.Question)
  == DialogResult.Yes)
            {

                if (txtNome.Text != "")
                {

                    cadastrarMotorista();
                    limpaCampos();


                }
                else
                {
                    MessageBox.Show("INFORME O NOME.");
                }

            }
        }

        public void motoristaCadastrados(SQLiteConnection conexao)
        {
            if (conexao.State == ConnectionState.Closed) //Validar a conexão
            {
                conexao.Open();
            }

            //este metodo esta carregando os nome dos modulos
            try
            {

                SQLiteDataAdapter ADAP = new SQLiteDataAdapter("select idmotorista as ID,nome as NOME,rg as RG,cpf as CPF,tel as TEL_CEL,email as EMAIL,habilitacao as NUM_HABILITACAO, dtcad as DATA_CAD from motorista where delet=''", conexao);

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

        public void cadastrarMotorista()
        {
            if (conexao.State == ConnectionState.Closed) //Validar a conexão
            {
                conexao.Open();
            }
            try
            {

                string sql = "insert into motorista (nome,rg,cpf,tel,idusu,dtcad,delet,email,habilitacao)values('" +
                       txtNome.Text + "','" + txtRg.Text + "','" + txtCpf.Text + "','" + txtTel.Text + "','" + lbIdusu.Text + "' ,datetime('now'),'','"+txtEmail.Text+"','"+txtHabilitacao.Text+"')";

                SQLiteCommand cmd1 = new SQLiteCommand(sql, conexao);

                cmd1.ExecuteNonQuery();
                motoristaCadastrados(conexao);
                MessageBox.Show("MOTORISTA CADASTRADO COM SUCESSO.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conexao.Close();

        }

        private void btnAlt_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("TEM CERTEZA QUE DESEJA ALTERAR AS INFORMAÇÕES DESTE MOTORISTA?", "DW NEW SOFTWARE",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question)
   == DialogResult.Yes)
            {
                if (txtValidar.Text == "")
                {
                    MessageBox.Show("SELECIONE PRIMEIRO UM MOTORISTA PARA EDITAR");
                }
                else
                {

                    if (txtNome.Text != "")
                    {


                        alterarMotorista();
                        limpaCampos();


                    }
                    else
                    {
                        MessageBox.Show("INFORME O NOME DO MOTORISTA.");
                    }

                }
            }//primeiro if
        }

        public void alterarMotorista()
        {
            if (conexao.State == ConnectionState.Closed) //Validar a conexão
            {
                conexao.Open();
            }
            try
            {

                string sql = "update motorista set nome='" + txtNome.Text + "',rg='" + txtRg.Text + "',cpf='" + txtCpf.Text + "',tel='" + txtTel.Text + "',idusu='" + lbIdusu.Text + "' ,dtcad=datetime('now'),delet='',email='"+txtEmail.Text+"',habilitacao='"+txtHabilitacao.Text+"' where idmotorista='" + txtIdMotorista.Text + "'";

                SQLiteCommand cmd1 = new SQLiteCommand(sql, conexao);

                cmd1.ExecuteNonQuery();
                motoristaCadastrados(conexao);
                MessageBox.Show("MOTORISTA ALTERADO COM SUCESSO.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conexao.Close();

        }

        private void btnExclu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("TEM CERTEZA QUE DESEJA EXCLUIR ESTE MOTORISTA?", "DW NEW SOFTWARE",
 MessageBoxButtons.YesNo, MessageBoxIcon.Question)
 == DialogResult.Yes)
            {
                if (txtValidar.Text == "")
                {
                    MessageBox.Show("SELECIONE PRIMEIRO UM MOTORISTA PARA EXCLUIR");
                }
                else
                {



                    deletarMotorista();
                    limpaCampos();


                }



            }//primeiro if
        }

            public void deletarMotorista()
            {
                if (conexao.State == ConnectionState.Closed) //Validar a conexão
                {
                    conexao.Open();
                }
                try
                {

                    string sql = "update  motorista set delet ='*' where idmotorista='" + txtIdMotorista.Text + "'";

                    SQLiteCommand cmd1 = new SQLiteCommand(sql, conexao);

                    cmd1.ExecuteNonQuery();
                    motoristaCadastrados(conexao);
                    MessageBox.Show("MOTORISTA DELETADO COM SUCESSO.");
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
            txtIdMotorista.Text = (dataGridView1.CurrentRow.Cells[0].Value).ToString();
            txtEmail.Text = (dataGridView1.CurrentRow.Cells[5].Value).ToString();
            txtHabilitacao.Text = (dataGridView1.CurrentRow.Cells[6].Value).ToString();
            txtValidar.Text = "SIM";
        }

        public void limpaCampos()
        {
            txtNome.Text = "";
            txtRg.Text = "";
            txtCpf.Text = "";
            txtTel.Text = "";
            txtIdMotorista.Text = "";
            txtValidar.Text = "";
            txtEmail.Text = "";
            txtHabilitacao.Text = "";

        }






    }
    
}
