using System;
using System.Windows.Forms;

namespace projetoControleDocumentos
{
    public partial class frmTipoDocumento : Form
    {
        
        public frmTipoDocumento()
        {
            InitializeComponent();
        }

        clsTipoDocumento myClass = new clsTipoDocumento();

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTipoDocumento_Load(object sender, EventArgs e)
        {

            dgvTipoDocumento.DataSource = myClass.dsTipoDocumento();
          
        }

        private void dgvUsuarios_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvTipoDocumento.RowCount != 1)
            {
                //txtUsuarioSelecionado.Text = dgvUsuarios.Rows[e.RowIndex].Cells["codigo_usuario"].FormattedValue.ToString();
                txtTipoSelecionado.Text = dgvTipoDocumento.Rows[e.RowIndex].Cells["codigo_tipo"].FormattedValue.ToString();
                myClass.Carregar(Convert.ToInt16(txtTipoSelecionado.Text));
                txtDescricao.Text = myClass.DescricaoTipo;
                BtnConfirmar.Text = "Salvar";
            }

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            BtnConfirmar.Text = "Incluir";
            txtTipoSelecionado.Text = "";
            txtDescricao.Text = "";
     
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            try
            {
                if (clsMensagem.Pergunta("Confirma Exclusão de cadastro?"))
                {
                    myClass.Excluir(Convert.ToInt16(txtTipoSelecionado.Text));
                    frmTipoDocumento_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {

            if (txtDescricao.Text == "")
            {
                clsMensagem.Atencao("informe a descrição!");
            }

            myClass.DescricaoTipo = txtDescricao.Text;

            if (BtnConfirmar.Text == "Incluir")
            {
                if (!myClass.Incluir())
                {
                    clsMensagem.Atencao("Erro ao incluir tipo de documento!");
                }
            }
            else
            {
                if (!myClass.Salvar())
                {
                    clsMensagem.Atencao("Erro ao salvar tipo de documento!");
                }
            }
            frmTipoDocumento_Load(sender, e);
        }

        private void dgvTipoDocumento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
