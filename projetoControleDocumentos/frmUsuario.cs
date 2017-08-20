using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace projetoControleDocumentos
{
    public partial class frmUsuario : Form
    {
        
        public frmUsuario()
        {
            InitializeComponent();
        }

        clsUsuario myClass = new clsUsuario();

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {

            dgvUsuarios.DataSource = myClass.dsUsuario();
        }

        private void dgvUsuarios_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            txtUsuarioSelecionado.Text = dgvUsuarios.Rows[e.RowIndex].Cells["codigo_usuario"].FormattedValue.ToString();
            myClass.Carregar(txtUsuarioSelecionado.Text);
            txtUsuario.Text = myClass.CodigoUsuario;
            txtNome.Text = myClass.NomeUsuario;
            txtSenha.Text = myClass.senhaUsuario;
            txtEmail.Text = myClass.EmailUsuario;
            BtnConfirmar.Text = "Salvar";

            //Combobox Situação
            var lista = new List<ComboSit>();
            lista.Add(new ComboSit { Nome = "Inativo", id = 0 });
            lista.Add(new ComboSit { Nome = "Ativo", id = 1 });

            cmbSituacao.DataSource = lista;
            cmbSituacao.ValueMember = "ID";
            cmbSituacao.DisplayMember = "Nome";
            cmbSituacao.SelectedValue = myClass.UsuarioAtivo;

            //Combobox Tipo
            var listaTipo = new List<ComboTipo>();
            listaTipo.Add(new ComboTipo { Nome = "Usuário", id = 0 });
            listaTipo.Add(new ComboTipo { Nome = "Aprovador", id = 1 });

            cmbTipoUsuario.DataSource = listaTipo;
            cmbTipoUsuario.ValueMember = "ID";
            cmbTipoUsuario.DisplayMember = "Nome";
            cmbTipoUsuario.SelectedValue = myClass.TipoUsuario;
            

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {

            txtUsuario.Text = "";
            txtNome.Text = "";
            txtSenha.Text = "";
            txtEmail.Text = "";
            BtnConfirmar.Text = "Incluir";
            txtUsuario.Focus();
     
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            try
            {
                if (clsMensagem.Pergunta("Confirma Exclusão de cadastro?"))
                {
                    myClass.Excluir(txtUsuario.Text);
                    frmUsuario_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {

            if (txtUsuario.Text =="" || txtNome.Text == "" || txtSenha.Text == "")
            {
                clsMensagem.Atencao("informe usuário, senha e nome do usuário!");
            }

            myClass.CodigoUsuario = txtUsuario.Text;
            myClass.NomeUsuario = txtNome.Text;
            myClass.senhaUsuario = txtSenha.Text;
            myClass.EmailUsuario = txtEmail.Text;
            myClass.TipoUsuario = Convert.ToInt16(cmbTipoUsuario.SelectedValue);
            myClass.UsuarioAtivo = Convert.ToInt16(cmbSituacao.SelectedValue);

            if (BtnConfirmar.Text == "Incluir")
            {
                if (!myClass.Incluir())
                {
                    clsMensagem.Atencao("Erro ao incluir usuário!");
                }
            }
            else
            {
                if (!myClass.Salvar())
                {
                    clsMensagem.Atencao("Erro ao salvar usuário!");
                }
            }
            frmUsuario_Load(sender, e);
        }

        class ComboSit
        {
            public string Nome { get; set; }
            public int id { get; set; }
        }

        class ComboTipo
        {
            public string Nome { get; set; }
            public int id { get; set; }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
