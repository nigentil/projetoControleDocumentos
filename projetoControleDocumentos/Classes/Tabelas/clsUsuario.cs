using System;
using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;

namespace projetoControleDocumentos
{
    class clsUsuario{

        private readonly clsConexao _meuBd= new clsConexao();

        private const string _retorna = "select codigo_usuario, " +
                                               "nome_usuario, " +
                                               "email_usuario, " +
                                               "tipo_usuario, " +
                                               "usuario_ativo " +
                                        "from usuario order by codigo_usuario";
        private const string _carrega = "select * from usuario where codigo_usuario = ?";
        private const string _valida = "select * from usuario where codigo_usuario = ? and senha_usuario=?";
        private const string _exclui = "delete from usuario where codigo_usuario = ?";
        private const string _adiciona = "insert into usuario (codigo_usuario, nome_usuario, senha_usuario, email_usuario, tipo_usuario, usuario_ativo) VALUES (?, ?, ?, ?, ?, ?)";
        private const string _edita = "update usuario set nome_usuario = ?, senha_usuario=?, email_usuario=?, tipo_usuario=?, usuario_ativo=? WHERE codigo_usuario = ?";

        private string _codigoUsuario = "";
        private string _nomeUsuario = "";
        private string _senhaUsuario = "";
        private string _emailUsuario = "";
        private int _tipoUsuario;
        private int _usuarioAtivo;

        public string CodigoUsuario
        {
            get { return _codigoUsuario; }
            set { _codigoUsuario = value; }
        }
        public string NomeUsuario
        {
            get { return _nomeUsuario; }
            set { _nomeUsuario = value; }
        }
        public string senhaUsuario
        {
            get { return _senhaUsuario; }
            set { _senhaUsuario = value; }
        }
        public string EmailUsuario
        {
            get { return _emailUsuario; }
            set { _emailUsuario = value; }
        }
        public int TipoUsuario
        {
            get { return _tipoUsuario; }
            set { _tipoUsuario = value; }
        }
        public int UsuarioAtivo
        {
            get { return _usuarioAtivo; }
            set { _usuarioAtivo = value; }
        }

        public clsUsuario()
        {
        
        }

        public BindingSource dsUsuario()
        {
            try
            {
                if (_meuBd.VerificarStatusConexao() == ConnectionState.Closed)
                    _meuBd.Conectar();

                OdbcCommand odbcCMD = new OdbcCommand(_retorna, _meuBd.Connection);

                BindingSource bs = new BindingSource();
                bs.DataSource = odbcCMD.ExecuteReader();

                return bs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Carregar(string usuario)
        {
            try
            {
                if (_meuBd.VerificarStatusConexao() == ConnectionState.Closed)
                    _meuBd.Conectar();

                OdbcCommand odbcCMD = new OdbcCommand(_carrega, _meuBd.Connection);
                odbcCMD.Parameters.Add("codigo_usuario", OdbcType.VarChar, 20).Value = usuario;

                OdbcDataReader reader = odbcCMD.ExecuteReader();

                while (reader.Read())
                {

                    _codigoUsuario = reader[0].ToString();
                    _nomeUsuario = reader[1].ToString();
                    _senhaUsuario = reader[2].ToString();
                    _emailUsuario = reader[3].ToString();
                    _tipoUsuario = Convert.ToInt16(reader[4]);
                    _usuarioAtivo = Convert.ToInt16(reader[5]);

                }

                reader.Close();
                reader.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Adicionar()
        {
            frmUsuario f = new frmUsuario();
            //f.Controls["btnGravar"].Text = "Incluir";
            f.ShowDialog();
            f.Close();
        }

        public bool Validar(string usuario, string senha)
        {

            if (_meuBd.VerificarStatusConexao() == ConnectionState.Closed)
                _meuBd.Conectar();

            OdbcCommand odbcCMD = new OdbcCommand(_valida, _meuBd.Connection);
            odbcCMD.Parameters.Add("codigo_usuario", OdbcType.VarChar, 20).Value = usuario;
            odbcCMD.Parameters.Add("senha_usuario", OdbcType.VarChar, 20).Value = senha;

            OdbcDataReader reader = odbcCMD.ExecuteReader();

            if (reader.HasRows)
            {
                clsGlobal.Login = usuario;
                clsGlobal.Perfil = Convert.ToInt16(reader["tipo_usuario"].ToString());
                reader.Close();
                reader.Dispose();
                return true; 
            }
            else
            {
                reader.Close();
                reader.Dispose();
                return false;
            }

        }

        public bool Incluir()
        {
            try
            {
                if (_meuBd.VerificarStatusConexao() == ConnectionState.Closed)
                    _meuBd.Conectar();

                OdbcCommand odbcCMD = new OdbcCommand(_adiciona, _meuBd.Connection);

                odbcCMD.Parameters.Add("codigo_usuario", OdbcType.VarChar, 20).Value = _codigoUsuario;
                odbcCMD.Parameters.Add("nome_usuario", OdbcType.VarChar, 50).Value = _nomeUsuario;
                odbcCMD.Parameters.Add("senha_usuario", OdbcType.VarChar, 20).Value = _senhaUsuario;
                odbcCMD.Parameters.Add("email_usuario", OdbcType.VarChar, 100).Value = _emailUsuario;
                odbcCMD.Parameters.Add("tipo_usuario", OdbcType.TinyInt).Value = _tipoUsuario;
                odbcCMD.Parameters.Add("usuario_ativo", OdbcType.Bit).Value = _usuarioAtivo;

                if (odbcCMD.ExecuteNonQuery() == 0)
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Excluir(string codigo)
        {

            bool bolDeuCerto;
            try
            {

                if (_meuBd.VerificarStatusConexao() == ConnectionState.Closed)
                    _meuBd.Conectar();

                OdbcCommand odbcCMD = new OdbcCommand(_exclui, _meuBd.Connection);
                odbcCMD.Parameters.Add("codigo_usuario", OdbcType.VarChar, 20).Value = codigo.ToString();
                bolDeuCerto = odbcCMD.ExecuteNonQuery() ==1;
                return bolDeuCerto;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        
        public bool Salvar()
        {
            try
            {
                if (_meuBd.VerificarStatusConexao() == ConnectionState.Closed)
                    _meuBd.Conectar();

                OdbcCommand odbcCMD = new OdbcCommand(_edita, _meuBd.Connection);
                odbcCMD.Parameters.Add("nome_usuario", OdbcType.VarChar,50).Value = _nomeUsuario;
                odbcCMD.Parameters.Add("senha_usuario", OdbcType.VarChar, 20).Value = _senhaUsuario;
                odbcCMD.Parameters.Add("email_usuario", OdbcType.VarChar, 100).Value = _emailUsuario;
                odbcCMD.Parameters.Add("tipo_usuario", OdbcType.TinyInt).Value = _tipoUsuario;
                odbcCMD.Parameters.Add("usuario_ativo", OdbcType.TinyInt).Value = _usuarioAtivo;
                odbcCMD.Parameters.Add("codigo_usuario", OdbcType.VarChar, 20).Value = _codigoUsuario;
                return odbcCMD.ExecuteNonQuery() == 1;
            }
            catch (OdbcException ex)
            {
                throw ex;
            }

        }

    }
}
