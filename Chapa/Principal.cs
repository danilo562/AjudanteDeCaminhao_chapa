using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapa
{
    public partial class Principal : Form
    {
        private int childFormNumber = 0;

        public Principal(string nome, string Idusu)
        {
            InitializeComponent();
            txtIDusu.Text = Idusu;
            txtUsuario.Text = nome;
        }

       

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

      

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Close();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
            if (Application.OpenForms.OfType<telas.CadastroUsuario>().Count() > 0)
            {
                //para impedir que a janela abra mais de uma vez.
              //  Application.OpenForms.OfType<telas.CadastroUsuario>().First().Focus();
                telas.CadastroUsuario MeuFormulario = new telas.CadastroUsuario();
                Application.OpenForms[MeuFormulario.Name].Activate();
                Application.OpenForms[MeuFormulario.Name].WindowState = FormWindowState.Normal;
            }
            else
            {
                telas.CadastroUsuario c = new telas.CadastroUsuario();
                c.MdiParent = this;
                c.Show();
            }
           

        }


        public void rolarLabel_Marquee(Label ondeMostrar)
        {
            // metodo para ficar passando a labal 
            ondeMostrar.Left += 5;
            if (ondeMostrar.Left > this.Width)
            {
                ondeMostrar.Location = new Point(0 - ondeMostrar.Width, ondeMostrar.Location.Y);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rolarLabel_Marquee(lbMensagem);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<telas.CadastrarCaminhao>().Count() > 0)
            {
                //para impedir que a janela abra mais de uma vez.
                //  Application.OpenForms.OfType<telas.CadastroUsuario>().First().Focus();
                telas.CadastrarCaminhao MeuFormulario = new telas.CadastrarCaminhao(txtIDusu.Text);
                Application.OpenForms[MeuFormulario.Name].Activate();
                Application.OpenForms[MeuFormulario.Name].WindowState = FormWindowState.Normal;
            }
            else
            {
                telas.CadastrarCaminhao c = new telas.CadastrarCaminhao(txtIDusu.Text);
                c.MdiParent = this;
                c.Show();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<telas.CadastroDeChapa>().Count() > 0)
            {
                //para impedir que a janela abra mais de uma vez.
                //  Application.OpenForms.OfType<telas.CadastroUsuario>().First().Focus();
                telas.CadastroDeChapa MeuFormulario = new telas.CadastroDeChapa(txtIDusu.Text);
                Application.OpenForms[MeuFormulario.Name].Activate();
                Application.OpenForms[MeuFormulario.Name].WindowState = FormWindowState.Normal;
            }
            else
            {
                telas.CadastroDeChapa c = new telas.CadastroDeChapa(txtIDusu.Text);
                c.MdiParent = this;
                c.Show();
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<telas.CadastroDeMotorista>().Count() > 0)
            {
                //para impedir que a janela abra mais de uma vez.
                //  Application.OpenForms.OfType<telas.CadastroUsuario>().First().Focus();
                telas.CadastroDeMotorista MeuFormulario = new telas.CadastroDeMotorista(txtIDusu.Text);
                Application.OpenForms[MeuFormulario.Name].Activate();
                Application.OpenForms[MeuFormulario.Name].WindowState = FormWindowState.Normal;
            }
            else
            {
                telas.CadastroDeMotorista c = new telas.CadastroDeMotorista(txtIDusu.Text);
                c.MdiParent = this;
                c.Show();
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<telas.ContratarChapa>().Count() > 0)
            {
                //para impedir que a janela abra mais de uma vez.
                //  Application.OpenForms.OfType<telas.CadastroUsuario>().First().Focus();
                telas.ContratarChapa MeuFormulario = new telas.ContratarChapa(txtIDusu.Text);
                Application.OpenForms[MeuFormulario.Name].Activate();
                Application.OpenForms[MeuFormulario.Name].WindowState = FormWindowState.Normal;
            }
            else
            {
                telas.ContratarChapa c = new telas.ContratarChapa(txtIDusu.Text);
                c.MdiParent = this;
                c.Show();
            }
        }



    }
}
