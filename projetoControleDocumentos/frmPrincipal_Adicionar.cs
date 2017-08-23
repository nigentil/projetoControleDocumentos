using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace projetoControleDocumentos
{
    public partial class frmPrincipal_Adicionar : Form
    {
        
        public frmPrincipal_Adicionar()
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

            if (txtArquivo.Text == "" || txtDescricaoArquivo.Text == "") 
            {
                clsMensagem.Atencao("informe o arquivo, tipo e descrição!");
            }
            else
            {

                myClass.CaminhoArquivo = txtArquivo.Text;
                myClass.TipoArquivo = Convert.ToInt16(cmbTipoArquivo.SelectedValue);
                myClass.DescricaoArquivo = txtDescricaoArquivo.Text;
                if (!myClass.Incluir())
                {
                    clsMensagem.Atencao("Erro ao salvar cadastro!");
                }
                else
                {
                    clsMensagem.Informacao("Arquivo gravado com sucesso!");
                    this.Close();
                }
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PDF Files(*.pdf)|*.pdf|WORD Files(*.doc;*.docx)|*.doc;*.docx|EXCEL Files(*.xlsx;*.xlsm;*.xlsb;*.xltx;*.xltm;*.xls;*.xlt)|*.xlsx;*.xlsm;*.xlsb;*.xltx;*.xltm;*.xls;*.xlt|Image Files(*.jpg;*.gif;*.bmp;*.png;*.jpeg)|*.jpg;*.gif;*.bmp;*.png;*.jpeg|All Files|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName.ToString();
                txtArquivo.Text = path;
            }
        }

        private void frmPrincipal_Adicionar_Load(object sender, EventArgs e)
        {

            clsTipoDocumento tipo = new clsTipoDocumento();
            cmbTipoArquivo.DataSource = tipo.dsTipoDocumento();
            cmbTipoArquivo.DisplayMember = "descricao_tipo";
            cmbTipoArquivo.ValueMember = "codigo_tipo";
        }

        private void txtArquivo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

