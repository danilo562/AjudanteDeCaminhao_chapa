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

namespace Chapa
{
    public partial class Login : Form
    {

        SQLiteConnection conexao = new SQLiteConnection(@"Data Source=" + System.AppDomain.CurrentDomain.BaseDirectory.ToString() + System.Configuration.ConfigurationManager.ConnectionStrings["DWC"].ConnectionString.ToString());
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        public Login()
        {
            InitializeComponent();
          //  Verificar(conexao);
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Os Campos Nome e Senha Devem ser preenchidos ");
            }
            else
            {
                pgLoad.Visible = true;
                pgLoad.Value = 50;

                Valida(Convert.ToString(txtLogin.Text), Convert.ToString(txtSenha.Text));

                if (txtLogin.Text == txtReConsult.Text || txtSenha.Text == txtSenhaConsult.Text)
                {
                    pgLoad.Value = 100;
                    Principal r = new Principal(txtNome.Text, txtIDusu.Text);




                    r.Show();
                    this.WindowState = FormWindowState.Minimized;
                    this.Hide();
                    LimpaCampos();
                    pgLoad.Visible = false;

                }//Valida permissao de entrar na tela


            }//valida campo RE e SEnha
        }

        public void Valida(string nome, string senha)
        {
            if (conexao.State == ConnectionState.Closed)
            {
                conexao.Open();
            }
            try
            {
                SQLiteDataAdapter ADAP = new SQLiteDataAdapter("select idusu,nome,senha from usuario where login='" + nome + "' And senha='" + senha + "' and delet =''", conexao);
                DataSet DS = new DataSet();

                //Preenche o dataset com a tabela Imagens
                ADAP.Fill(DS, "usu");
                if (DS.Tables["usu"].Rows.Count == 0)
                {


                    MessageBox.Show("login ou senha incorreta");
                    pgLoad.Visible = false;

                }
                else
                {

                    dataGridView1.DataSource = DS.Tables["usu"];
                    txtSenhaConsult.Text = (dataGridView1.CurrentRow.Cells[2].Value).ToString();
                    txtReConsult.Text = (dataGridView1.CurrentRow.Cells[1].Value).ToString();
                    txtIDusu.Text = (dataGridView1.CurrentRow.Cells[0].Value).ToString();
                    txtNome.Text = (dataGridView1.CurrentRow.Cells[1].Value).ToString();

                }
                conexao.Close();
            }
            catch (Exception d) {
                MessageBox.Show(d.ToString());
            }

        }

        public void LimpaCampos()
        {
            txtSenhaConsult.Text = "";
            txtReConsult.Text = "";
            txtIDusu.Text = "";
            txtNome.Text = "";
            txtSenha.Text = "";

        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {

                case (char)Keys.Enter:
                    Entrar_Click(sender, e);
                    break;

            }
        }

        public void Verificar(SQLiteConnection conexao)
        {
            if (conexao.State == ConnectionState.Closed) //Validar a conexão
            {
                conexao.Open();
            }

            //este metodo esta carregando os nome dos modulos
            try
            {

                SQLiteDataAdapter ADAP = new SQLiteDataAdapter("select * from usuario", conexao);

                //Inicializa o  Dataset.
                DataSet DS = new DataSet();

                //Preenche o dataset com a tabela Imagens
                ADAP.Fill(DS, "CodB");

                //preenche o datagridviewe com o dataset.
                dataGridView1.DataSource = DS.Tables["CodB"];

                //DataTable dt = new DataTable();

                //String insSQL = "select * from Alunos";
                //String strConn = @"Data Source=C:\dados\MacorattiSQLite.db";

                //SQLiteConnection conn = new SQLiteConnection(strConn);

                //SQLiteDataAdapter da = new SQLiteDataAdapter(insSQL, strConn);
                //da.Fill(dt);
                //gdvAlunos.DataSource = dt.DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conexao.Close();
        }










    }
}
