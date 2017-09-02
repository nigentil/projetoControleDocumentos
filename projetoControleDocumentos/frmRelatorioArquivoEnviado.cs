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
    public partial class frmRelatorioArquivoEnviado : Form
    {
        public frmRelatorioArquivoEnviado()
        {
            InitializeComponent();
        }

        private void frmArquivoEnviado_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DB_ConDocDataSet.SP_Relatorio_ArquivoEnviado' table. You can move, or remove it, as needed.
            this.KeyPreview = true;
            this.SP_Relatorio_ArquivoEnviadoTableAdapter.Fill(this.DB_ConDocDataSet.SP_Relatorio_ArquivoEnviado,clsGlobal.Arquivo);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void frmRelatorioArquivoEnviado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.P)
            {
                reportViewer1.PrintDialog();
            }
        }

        private void reportViewer1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.P)
            {
                reportViewer1.PrintDialog();
            }
        }

        private void reportViewer1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
