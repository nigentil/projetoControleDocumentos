using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoControleDocumentos
{
    public partial class frmIdentificacao : Form
    {
        public frmIdentificacao()
        {
            InitializeComponent();
        }

        clsUsuario user = new clsUsuario();


        private void frmIdentificacao_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == "" || txtUsuario.Text == "")
                clsMensagem.Atencao("Informe usuário e senha");
            else
            {
                if (user.Validar(txtUsuario.Text, txtSenha.Text))
                {
                    Program.SetMainForm(new frmPrincipal());
                    Program.ShowMainForm();
                    this.Close();
                }
                else
                    clsMensagem.Atencao("Usuário ou senha inválidos");
            }

   
        }
    }
}
