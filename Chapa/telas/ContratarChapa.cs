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
using System.Collections;
using System.Globalization;
using Excel = Microsoft.Office.Interop.Excel;

namespace Chapa.telas
{
    public partial class ContratarChapa : Form
    {
        SQLiteConnection conexao = new SQLiteConnection(@"Data Source=" + System.AppDomain.CurrentDomain.BaseDirectory.ToString() + System.Configuration.ConfigurationManager.ConnectionStrings["DWC"].ConnectionString.ToString());
        SQLiteCommand cmd;
        SQLiteDataReader dr;

        public ContratarChapa(string idUsu)
        {
            InitializeComponent();
            lbIdusu.Text = idUsu;

        }

       

        private void form2_OnDataChange(Hashtable info) //usa o pacote use coletion
        {
            txtIdMotorista.Text = info["Valor1"].ToString();//nomeando o campo.
            txtNomeMotorista.Text = info["Valor2"].ToString();//nomeando o campo.

        }

        private void btnPMotorista_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<telas.PESQUISA>().Count() > 0)
            {
                //para impedir que a janela abra mais de uma vez.
                //  Application.OpenForms.OfType<telas.CadastroUsuario>().First().Focus();
                telas.PESQUISA MeuFormulario = new telas.PESQUISA("MOTORISTA");
                Application.OpenForms[MeuFormulario.Name].Activate();
                Application.OpenForms[MeuFormulario.Name].WindowState = FormWindowState.Normal;
            }
            else
            {
                telas.PESQUISA c = new telas.PESQUISA("MOTORISTA"); 
               // c.MdiParent = this.MdiParent;
                c.Show();
                c.OnDataChange += new telas.PESQUISA.OnDataChangeHandler(form2_OnDataChange);
            }
        }

        private void form1_OnDataChange(Hashtable info) //usa o pacote use coletion
        {
            txtIdCaminhao.Text = info["Valor1"].ToString();//nomeando o campo.
            txtNomeCaminhao.Text = info["Valor2"].ToString();//nomeando o campo.

        }

        private void btnPCaminhao_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<telas.PESQUISA>().Count() > 0)
            {
                //para impedir que a janela abra mais de uma vez.
                //  Application.OpenForms.OfType<telas.CadastroUsuario>().First().Focus();
                telas.PESQUISA MeuFormulario = new telas.PESQUISA("CAMINHAO");
                Application.OpenForms[MeuFormulario.Name].Activate();
                Application.OpenForms[MeuFormulario.Name].WindowState = FormWindowState.Normal;
            }
            else
            {
                telas.PESQUISA c = new telas.PESQUISA("CAMINHAO");
              //  c.MdiParent = this.MdiParent;
                c.Show();
                c.OnDataChange += new telas.PESQUISA.OnDataChangeHandler(form1_OnDataChange);
            }
        }


        private void form0_OnDataChange(Hashtable info) //usa o pacote use coletion
        {
            txtIdChapa.Text = info["Valor1"].ToString();//nomeando o campo.
            txtNomeChapa.Text = info["Valor2"].ToString();//nomeando o campo.

        }

        private void btnPChapa_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<telas.PESQUISA>().Count() > 0)
            {
                //para impedir que a janela abra mais de uma vez.
                //  Application.OpenForms.OfType<telas.CadastroUsuario>().First().Focus();
                telas.PESQUISA MeuFormulario = new telas.PESQUISA("CHAPA");
                Application.OpenForms[MeuFormulario.Name].Activate();
                Application.OpenForms[MeuFormulario.Name].WindowState = FormWindowState.Normal;
            }
            else
            {
                telas.PESQUISA c = new telas.PESQUISA("CHAPA");
             //   c.MdiParent = this.MdiParent;
                c.Show();
                c.OnDataChange += new telas.PESQUISA.OnDataChangeHandler(form0_OnDataChange);
            }
        }

        private void txtValorChapa_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasNumeroPonto(sender, e);
        }

        public void apenasNumeroPonto(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ',') && (e.KeyChar != (char)8))
            {
                //Apenas numero e ponto
                e.Handled = true;
            }
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("TEM CERTEZA QUE DESEJA EFETUAR ESTA OPERAÇÃO?", "DW NEW SOFTWARE",
  MessageBoxButtons.YesNo, MessageBoxIcon.Question)
  == DialogResult.Yes)
            {

                if (txtIdMotorista.Text != "")
                {
                    if (txtIdCaminhao.Text != "")
                    {

                        if (txtIdChapa.Text != "")
                        {

                            contratarChapa();
                         //   limpaCampos();


                        }
                        else
                        {
                            MessageBox.Show("INFORME O CHAPA.");
                        }


                    }
                    else
                    {
                        MessageBox.Show("INFORME O COMINHÃO.");
                    }

                }
                else
                {
                    MessageBox.Show("INFORME O MOTORISTA.");
                }

            }
        }

        public void contratarChapa()
        {
            if (conexao.State == ConnectionState.Closed) //Validar a conexão
            {
                conexao.Open();
            }
            try
            {

                string sql = "insert into utilizado_chapa (idmotorista,idchapa,idcaminhao,idusu,nota,dtcad,delet,localde,localpara,valorchapa)values('" +
                       txtIdMotorista.Text + "','" + txtIdChapa.Text + "','" + txtIdCaminhao.Text + "','" + lbIdusu.Text + "','" + txtNota.Text + "' ,datetime('now'),'','"+txtLocalDe.Text+"','"+txtLocalAte.Text+"','"+txtValorChapa.Text.Replace(",",".")+"')";

                SQLiteCommand cmd1 = new SQLiteCommand(sql, conexao);

                cmd1.ExecuteNonQuery();
               // chapaCadastrados(conexao);
                MessageBox.Show("OPERAÇÃO REALIZADA COM SUCESSO.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conexao.Close();

        }


        public string dataFormatoCorreto1(string data)
        {

            string texto = data;
            CultureInfo culturaBrasileira = new CultureInfo("pt-BR");

            DateTime dataHora = DateTime.Parse(texto, culturaBrasileira);

            string dataFormatada = dataHora.ToString("yyyyMMdd ");

            return dataFormatada.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pesquisaCadastrados(conexao);
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

        public void pesquisaCadastrados(SQLiteConnection conexao)
        {
            if (conexao.State == ConnectionState.Closed) //Validar a conexão
            {
                conexao.Open();
            }

            //este metodo esta carregando os nome dos modulos
            try
            {
                string sql = "select a.id as ID,c.nome as MOTORISTA,d.nome as CHAPA_CONTRATADO,a.nota as NOTA,a.valorchapa as VALOR_CHAPA,a.localde as LOCAL_ORIGEM,a.localpara as LOCAL_DESTINO,b.placa as PLACA,b.tipo as TIPO_CAMINHAO,b.nome as NOME_CAMINHAO,a.dtcad as CADASTRADO " +
                    " from utilizado_chapa  as a inner join caminhao as b on a.idcaminhao = b.idcaminhao" +
                                   " inner join motorista as c on a.idmotorista = c.idmotorista " +
                                   " inner join chapa as d on a.idchapa = d.idchapa " +
                                   " where strftime('%Y%m%d', a.dtcad) >= '" + dataFormatoCorreto1(dtDe.Text.TrimEnd()).TrimEnd() + "'" +
                                   " and strftime('%Y%m%d', a.dtcad) <= '" + dataFormatoCorreto1(dtAte.Text.TrimEnd()).TrimEnd() + "'";
                SQLiteDataAdapter ADAP = new SQLiteDataAdapter(sql, conexao);

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


        public void geraDocExcelgrid(DataGridView grid)
        {
            try
            {
                SaveFileDialog salvar = new SaveFileDialog();


                Excel.Application App; // Aplicação Excel 
                Excel.Workbook WorkBook; // Pasta 
                Excel.Worksheet WorkSheet; // Planilha 
                object misValue = System.Reflection.Missing.Value;

                App = new Excel.Application();
                WorkBook = App.Workbooks.Add(misValue);
                WorkSheet = (Excel.Worksheet)WorkBook.Worksheets.get_Item(1);
                int i = 0;
                int j = 0;


                for (int c = 1; c < grid.Columns.Count + 1; c++)
                {

                    WorkSheet.Cells[1, c] = grid.Columns[c - 1].HeaderText;

                }

                // passa as celulas do DataGridView para a Pasta do Excel 
                for (i = 0; i <= grid.RowCount - 1; i++)
                {

                    for (j = 0; j <= grid.ColumnCount - 1; j++)
                    {
                        DataGridViewCell cell = grid[j, i];
                        WorkSheet.Cells[i + 2, j + 1] = cell.Value.ToString();
                    }
                }



                // define algumas propriedades da caixa salvar 
                salvar.Title = "Meu Titulo";
                salvar.Filter = "Arquivo do Excel *.xls | *.xls";
                salvar.ShowDialog(); // mostra 

                // salva o arquivo 
                WorkBook.SaveAs(salvar.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,

                Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

                WorkBook.Close(true, misValue, misValue);
                App.Quit(); // encerra o excel 

                MessageBox.Show("Exportado com sucesso!");
            }
            catch { }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("PRIMEIRO VOCÊ DEVE PESQUISAR PARA EXPORTAR ALGUMA COISA.");
            }
            else
            {
                geraDocExcelgrid(dataGridView1);
            }
        }




    }
}
