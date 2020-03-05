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

namespace Chapa.telas
{
    public partial class PESQUISA : Form
    {
        SQLiteConnection conexao = new SQLiteConnection(@"Data Source=" + System.AppDomain.CurrentDomain.BaseDirectory.ToString() + System.Configuration.ConfigurationManager.ConnectionStrings["DWC"].ConnectionString.ToString());
        SQLiteCommand cmd;
        SQLiteDataReader dr;

        public Form FormOwner { get; set; }
        public delegate void OnDataChangeHandler(Hashtable info);//
        public event OnDataChangeHandler OnDataChange;////////////necessario para passar os valores para o outro form com ele aberto

        string telaSel;
        public PESQUISA(string tela)
        {
            InitializeComponent();
            telaSel=tela;
        }

        private void btnPesq_Click(object sender, EventArgs e)
        {
            if (telaSel == "MOTORISTA") {
                CarregaMotorista(conexao);
            }
            else if (telaSel == "CHAPA")
            {
                CarregaChapa(conexao);
            }
            else if (telaSel == "CAMINHAO")
            {
                CarregaCaminhao(conexao);
            }
        }

        private void gdvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gdvCliente.Rows.Count != 0)
            {
                if (telaSel == "MOTORISTA")
                {
                    Hashtable info = new Hashtable();// cria uma informacao
                    info.Add("Valor1", (gdvCliente.CurrentRow.Cells[0].Value).ToString());//pevagando a referencia para onde mandar
                    info.Add("Valor2", (gdvCliente.CurrentRow.Cells[1].Value).ToString());//pevagando a referencia para onde mandar
                    OnDataChange(info); //enviando
                    Close();
                }
                else if (telaSel == "CHAPA")
                {
                    Hashtable info = new Hashtable();// cria uma informacao
                    info.Add("Valor1", (gdvCliente.CurrentRow.Cells[0].Value).ToString());//pevagando a referencia para onde mandar
                    info.Add("Valor2", (gdvCliente.CurrentRow.Cells[1].Value).ToString());//pevagando a referencia para onde mandar
                    OnDataChange(info); //enviando
                    Close();
                }
                else if (telaSel == "CAMINHAO")
                {
                    Hashtable info = new Hashtable();// cria uma informacao
                    info.Add("Valor1", (gdvCliente.CurrentRow.Cells[0].Value).ToString());//pevagando a referencia para onde mandar
                    info.Add("Valor2", (gdvCliente.CurrentRow.Cells[1].Value).ToString() +" [ "+ (gdvCliente.CurrentRow.Cells[3].Value).ToString()+" ] " + (gdvCliente.CurrentRow.Cells[2].Value).ToString());//pevagando a referencia para onde mandar
                    OnDataChange(info); //enviando
                    Close();
                }
                
            }
        }


       public void CarregaMotorista(SQLiteConnection conexao)
        {//esta carregando a grid quando insere um novo usuario.
            try
            {
                //Inicializar o SQL adapter.
                SQLiteDataAdapter ADAP = new SQLiteDataAdapter("select idmotorista as ID ,nome as NOME_MOTORISTA,cpf as CPF,rg as RG from motorista where nome like '%" + txtPesquisa.Text + "%' and delet =''", conexao);

                //Inicializa o  Dataset.
                DataSet DS = new DataSet();

                //Preenche o dataset com a tabela Imagens
                ADAP.Fill(DS, "cliente");

                //preenche o datagridviewe com o dataset.
                gdvCliente.DataSource = DS.Tables["cliente"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        public void CarregaCaminhao(SQLiteConnection conexao)
        {//esta carregando a grid quando insere um novo usuario.
            try
            {
                //Inicializar o SQL adapter.
                SQLiteDataAdapter ADAP = new SQLiteDataAdapter("select idcaminhao as ID,placa as PLACA,nome as NOME,tipo as TIPO_CAMINHAO from caminhao where nome like '%" + txtPesquisa.Text + "%' and delet =''", conexao);

                //Inicializa o  Dataset.
                DataSet DS = new DataSet();

                //Preenche o dataset com a tabela Imagens
                ADAP.Fill(DS, "cliente");

                //preenche o datagridviewe com o dataset.
                gdvCliente.DataSource = DS.Tables["cliente"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        public void CarregaChapa(SQLiteConnection conexao)
        {//esta carregando a grid quando insere um novo usuario.
            try
            {
                //Inicializar o SQL adapter.
                SQLiteDataAdapter ADAP = new SQLiteDataAdapter("select idchapa as ID,nome as NOME,tel as TEL,cpf as CPF,rg as RG from chapa where nome like '%" + txtPesquisa.Text + "%' and delet =''", conexao);

                //Inicializa o  Dataset.
                DataSet DS = new DataSet();

                //Preenche o dataset com a tabela Imagens
                ADAP.Fill(DS, "cliente");

                //preenche o datagridviewe com o dataset.
                gdvCliente.DataSource = DS.Tables["cliente"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }






    }
}
