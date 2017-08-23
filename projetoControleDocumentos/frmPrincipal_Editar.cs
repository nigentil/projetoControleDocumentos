using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace projetoControleDocumentos
{
    public partial class frmPrincipal_Editar : Form
    {
        
        public frmPrincipal_Editar()
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

            if (txtDescricaoArquivo.Text == "")
            {
                clsMensagem.Atencao("informe código e nome!");
            }

            myClass.DescricaoArquivo = txtDescricaoArquivo.Text;

            if (!myClass.Salvar())
            {
                clsMensagem.Atencao("Erro ao salvar alterações no arquivo!");
            }
            else
            {
                clsMensagem.Informacao("Salvo com sucesso!");
            }
            this.Close();
        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            
            myClass.Carregar(clsGlobal.Arquivo);

            txtCodigoEnvio.Text = myClass.CodigoEnvio.ToString();
            txtTipoArquivo.Text = myClass.DescricaoTipo;
            txtDescricaoArquivo.Text = myClass.DescricaoArquivo;
            txtNomeArquivo.Text = myClass.NomeArquivo;
            txtDataEnvio.Text = myClass.DataEnvio.ToString();
            txtDataAprov.Text = myClass.DataAprov.ToString();
            txtCodigoUsuarioAprov.Text = myClass.CodigoUsuario_aprov;
            txtDataReprov.Text = myClass.DataReprov.ToString();
            txtCodigoUsuarioReprov.Text = myClass.CodigoUsuarioReprov;
            txtProtEnvio.Text = myClass.ProtocoloEnvio.ToString();
            txtProtAut.Text= myClass.ProtocoloAutorizacao.ToString();
            txtMotivoRejeicao.Text = myClass.MotivoReprov;
            txtCodigoUsuarioReprov.Text = myClass.CodigoUsuarioReprov;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtProtAut_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigoEmpresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProtEnvio_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

