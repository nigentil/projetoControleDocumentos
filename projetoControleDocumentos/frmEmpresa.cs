using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace projetoControleDocumentos
{
    public partial class frmEmpresa : Form
    {
        
        public frmEmpresa()
        {
            InitializeComponent();
        }

        clsEmpresa myClass = new clsEmpresa();

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {

            if (txtCodigoEmpresa.Text =="" || txtRazaoSocial.Text == "")
            {
                clsMensagem.Atencao("informe código e nome!");
            }

            myClass.CodigoEmpresa = Convert.ToInt16(txtCodigoEmpresa.Text);
            myClass.RazaoSocial = txtRazaoSocial.Text;
            myClass.ProtocoloEnvio = Convert.ToInt16(txtProtEnvio.Text);
            myClass.ProtocoloAutorizacao = Convert.ToInt16(txtProtAut.Text);

            if (!myClass.Salvar())
            {
                clsMensagem.Atencao("Erro ao salvar cadastro!");
            }
        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            
            var bsDados = myClass.dsEmpresa();
            
            txtCodigoEmpresa.DataBindings.Add("Text", bsDados, "codigo_empresa");
            txtRazaoSocial.DataBindings.Add("Text", bsDados, "razao_social");
            txtProtEnvio.DataBindings.Add("Text", bsDados, "protocolo_envio");
            txtProtAut.DataBindings.Add("Text", bsDados, "protocolo_autorizacao");
        }

    }
}

