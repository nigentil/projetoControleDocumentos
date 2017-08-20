using System;
using System.Data;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace projetoControleDocumentos
{
    public partial class frmParametrosConexao : Form
    {
        clsConexao MeuBD = new clsConexao();
        
        public frmParametrosConexao()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            XmlDocument myDocument = new XmlDocument();

            if (Directory.Exists(Environment.CurrentDirectory.ToString()))
            {
                if (File.Exists(Environment.CurrentDirectory.ToString() + @"\conexao.xml"))
                {
                    myDocument.Load(Environment.CurrentDirectory.ToString() + @"\conexao.xml");
                }
                else
                {
                    myDocument.CreateDocumentType(Environment.CurrentDirectory.ToString() + @"\conexao.xml", null, null, null);
                }
            }

            XmlNode node = myDocument.DocumentElement;

            foreach (XmlNode node1 in node)
            {
                foreach (XmlNode node2 in node1)
                {
                    if (node2.Name.Equals("Servidor"))
                        node2.InnerText= txtServidor.Text;
                    else if (node2.Name.Equals("Banco"))
                        node2.InnerText=txtBanco.Text;
                    else if (node2.Name.Equals("Usuario"))
                        node2.InnerText=txtUsuario.Text;
                    else if (node2.Name.Equals("Senha"))
                        node2.InnerText=txtSenha.Text;
                }
            }

            myDocument.Save(Environment.CurrentDirectory.ToString() + @"\conexao.xml");
            clsMensagem.Informacao("Informações salvas com sucesso. Para que as alterações tenham efeito você precisa finalizar a aplicação e entrar novamente!");
            Application.Exit();
        }

        private void frm_Parametros_Conexao_Load(object sender, EventArgs e)
        {
            try
            {
                MeuBD.CarregarDadosConexao();
                txtServidor.Text = MeuBD.Servidor;
                txtBanco.Text = MeuBD.Banco;
                txtUsuario.Text = MeuBD.Usuario;
                txtSenha.Text = MeuBD.Senha;

            }
            catch (Exception ex)
            {
                clsMensagem.Erro("Erro ao acessar Configuração de banco de dados !" + Environment.NewLine + ex.Message.ToString());
            }
            finally
            {
                if (MeuBD.VerificarStatusConexao() == ConnectionState.Open)
                    MeuBD.FecharBanco();
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
