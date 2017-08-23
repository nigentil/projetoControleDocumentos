using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace projetoControleDocumentos
{
    public partial class frmPrincipal_Aprovacao : Form
    {
        
        public frmPrincipal_Aprovacao()
        {
            InitializeComponent();
        }

        clsArquivoEnviado myClass = new clsArquivoEnviado();

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {

            if (!rdbAprovado.Checked && !rdbReprovado.Checked)
            {
                clsMensagem.Atencao("Informe se o o arquivo esta aprovado ou reprovado!");

            }
            else
            {
                if (rdbAprovado.Checked)
                {
                    myClass.CodigoUsuario_aprov = clsGlobal.Login;
                    myClass.CodigoEnvio = clsGlobal.Arquivo;
                    myClass.ProtocoloAutorizacao = DateTime.Now.Year * 10000 + Convert.ToInt16(myClass.Dlookup("protocolo_envio", "empresa", "")) + 1;
                    myClass.Aprovar();
                    this.Close();
                }
                else
                {
                    if (rdbReprovado.Checked && txtMotivoRejeicao.Text == "")
                        clsMensagem.Atencao("Informe o motivo da rejeição");
                    else
                    {
                        myClass.CodigoUsuarioReprov = clsGlobal.Login;
                        myClass.CodigoEnvio = clsGlobal.Arquivo;
                        myClass.MotivoReprov = txtMotivoRejeicao.Text;
                        myClass.Reprovar();
                        this.Close();
                    }
                }
            }
        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            
            myClass.Carregar(clsGlobal.Arquivo);

            txtCodigoEnvio.Text = myClass.CodigoEnvio.ToString();
            txtTipoArquivo.Text = myClass.DescricaoTipo;
            txtDescricaoArquivo.Text = myClass.DescricaoArquivo;
            txtNomeArquivo.Text = myClass.NomeArquivo;
            txtDataEnvio.Text = myClass.DataEnvio.ToString();
            txtMotivoRejeicao.Text = myClass.MotivoReprov;
        }

        public void mudarStatusAprovacao()
        {
            if (rdbAprovado.Checked)
            {
                rdbReprovado.Checked = false;
                rdbAprovado.Checked = true;
                txtMotivoRejeicao.Text = "";
                txtMotivoRejeicao.Enabled = false;
            }
            else
            {
                rdbAprovado.Checked = false;
                rdbReprovado.Checked = true;
                txtMotivoRejeicao.Enabled = true;

            }
        }

        private void rdbAprovado_CheckedChanged(object sender, EventArgs e)
        {
            mudarStatusAprovacao();
        }

        private void rdbReprovado_CheckedChanged(object sender, EventArgs e)
        {
            mudarStatusAprovacao();
        }

        private void txtMotivoRejeicao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

