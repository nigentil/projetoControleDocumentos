using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace projetoControleDocumentos
{
    public partial class frmPrincipal : Form
    {

        int _codigoEnvio;
        string _usuarioAprov;
        string _usuarioReprov;

        Form f;
        clsArquivoEnviado MyClass = new clsArquivoEnviado();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f = new frmUsuario();
            f.ShowDialog();
        }

        private void tipoDeDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f = new frmTipoDocumento();
            f.ShowDialog();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f = new frmEmpresa();
            f.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            dgvArquivo.DataSource = MyClass.dsArquivo();

            if (clsGlobal.Perfil == 0)
            {
                empresaToolStripMenuItem.Enabled = false;
                tipoDeDocumentoToolStripMenuItem.Enabled = false;
                usuáriosToolStripMenuItem.Enabled = false;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            f = new frmPrincipal_Adicionar();
            f.ShowDialog();
            frmPrincipal_Load(sender, e);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (clsMensagem.Pergunta("Confirma exclusão do arquivo enviado?"))
            {
                MyClass.Excluir(_codigoEnvio);
                frmPrincipal_Load(sender, e);
            }
        }

        private void dgvArquivo_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
           _codigoEnvio= Convert.ToUInt16(dgvArquivo.Rows[e.RowIndex].Cells["codigo_envio"].FormattedValue.ToString());
            _usuarioAprov = dgvArquivo.Rows[e.RowIndex].Cells["codigo_usuario_aprov"].FormattedValue.ToString();
            _usuarioReprov = dgvArquivo.Rows[e.RowIndex].Cells["codigo_usuario_reprov"].FormattedValue.ToString();
            clsGlobal.Arquivo = _codigoEnvio;
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dgvArquivo_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dgvArquivo.Rows[e.RowIndex].Cells["codigo_usuario_aprov"].FormattedValue == "")
            {
                dgvArquivo.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
            }
            else
            {
                dgvArquivo.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Green;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (_codigoEnvio != 0)
            {
                f = new frmPrincipal_Editar();
                f.ShowDialog();
                frmPrincipal_Load(sender, e);
            }
        }

        private void btnAbrirArquivo_Click(object sender, EventArgs e)
        {
            clsAcesso myClass = new clsAcesso();

            byte[] buffer = null;
            string _nomeArquivo;

            buffer = myClass.DlookupArrayByte("arquivo", "arquivo_enviado", "codigo_envio=" + (clsGlobal.Arquivo).ToString());
            _nomeArquivo = myClass.Dlookup("nome_arquivo", "arquivo_enviado", "codigo_envio=" + (clsGlobal.Arquivo).ToString());

            StreamWriter oStreamWriter = new StreamWriter(_nomeArquivo);

            oStreamWriter.BaseStream.Write(buffer, 0, buffer.Length);

            oStreamWriter.Close();
            oStreamWriter.Dispose();

            //abrir arquivo
            System.Diagnostics.Process.Start(_nomeArquivo);
        }

        private void btnAprovReprov_Click(object sender, EventArgs e)
        {
            if (clsGlobal.Perfil == 1)
            {
                if (_usuarioAprov != "")
                    clsMensagem.Informacao("Este arquivo já esta aprovado!");
                else if (_usuarioReprov != "")
                    clsMensagem.Informacao("Este documento ja esta reprovado!");
                else
                {
                    f = new frmPrincipal_Aprovacao();
                    f.ShowDialog();
                    frmPrincipal_Load(sender, e);
                }
            }
            else
            {
                clsMensagem.Informacao("Sem permissões para aprovar arquivos!");
            }
        }

        private void arquivosEnviadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f = new frmRelatorioArquivosEnviados();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f = new frmRelatorioArquivoEnviado();
            f.ShowDialog();
        }
    }
}
