using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Xml;

namespace projetoControleDocumentos
{
    public class clsConexao
    {
        public OdbcConnection Connection = new OdbcConnection();

        string _servidor;
        string _banco;
        string _usuario;
        string _senha;

        public string Servidor
        {
            get { return _servidor; }
            set { _servidor = value; }
        }

        public string Banco
        {
            get { return _banco; }
            set { _banco = value; }
        }

        public string Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        public string Senha
        {
            get { return _senha; }
            set { _senha = value; }
        } 

        public void Conectar()
        {
            try
            {

                if (_servidor == "" || _servidor == null)
                {
                    CarregarDadosConexao();
                }
                
                string connectionString ;

                if (_senha != "")
                    connectionString = "DRIVER=SQL Server;SERVER=" + _servidor + ";DATABASE=" + _banco + ";UID=" + _usuario + ";PWD=" + _senha + ";TRUSTED CONNECTION=TRUE;";
                else
                    connectionString = "DRIVER=SQL Server;SERVER=" + _servidor + ";DATABASE=" + _banco + ";TRUSTED CONNECTION=TRUE;";

                Connection.ConnectionString = connectionString;

                // abre a conexao
                Connection.Open();

            }
            catch (OdbcException exODBC)
            {
                if (exODBC.ToString().Substring(0, 45) == "System.Data.Odbc.OdbcException: ERROR [08001]")
                    MessageBox.Show("Não foi possível encontrar o servidor !","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                if (exODBC.ToString().Substring(0, 45) == "System.Data.Odbc.OdbcException: ERROR [28000]")
                    MessageBox.Show("Usuário ou senha inválidos !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Erro ao conectar ao banco de dados" + 
                                    System.Environment.NewLine + exODBC.Message.ToString(), 
                                    "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                frmParametrosConexao frmParam = new frmParametrosConexao();
                frmParam.ShowDialog();
 
            }

            catch (Exception e)
            {
                //if (connection.State != ConnectionState.Open)
                MessageBox.Show(e + Environment.NewLine + " Erro ao abrir Conexão !", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form f = new frmParametrosConexao();
                f.ShowDialog();
            }
        }

        public void FecharBanco()
        {
            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
                Connection.Dispose();
            }
        }

        public OdbcDataReader RetornaDataReader(string sqlString)
        {
            if (VerificarStatusConexao() == ConnectionState.Closed)
                Conectar();

            OdbcCommand command = new OdbcCommand();
            command = Connection.CreateCommand();
            command.CommandText = sqlString;

            OdbcDataReader dataReader = command.ExecuteReader();
            
            return dataReader;
        }

        public ConnectionState VerificarStatusConexao()
        {
            return Connection.State;
        }

        public  void CarregarDadosConexao()
        {
 
            XmlDocument myDocument = new XmlDocument();
            myDocument.Load(Environment.CurrentDirectory.ToString() + @"\conexao.xml");
            XmlNode node = myDocument.DocumentElement;

            foreach (XmlNode node1 in node)
            {
                foreach (XmlNode node2 in node1)
                {
                    if (node2.Name.Equals("Servidor"))
                        _servidor = node2.InnerText.ToString();
                    else if (node2.Name.Equals("Banco"))
                        _banco = node2.InnerText.ToString();
                    else if (node2.Name.Equals("Usuario"))
                        _usuario = node2.InnerText.ToString();
                    else if (node2.Name.Equals("Senha"))
                        _senha = node2.InnerText.ToString();

                }
            }

        }
    }





















}
