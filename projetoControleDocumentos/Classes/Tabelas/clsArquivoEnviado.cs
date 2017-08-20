using System;
using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;

namespace projetoControleDocumentos
{
    class clsArquivoEnviado
    {

        private readonly clsConexao _meuBd= new clsConexao();

        private const string _retorna = "select codigo_envio, " +
                                               "tipo_arquivo," +
                                               "descricao_arquivo, " +
                                               "nome_Arquivo, " +
                                               "tamanho_arquivo, " +
                                               "codigo_usuario_envio, " +
                                               "data_envio, " +
                                               "codigo_usuario_aprov, " +
                                               "data_aprov, " +
                                               "codigo_usuario_reprov, " +
                                               "data_reprov, " +
                                               "motivo_reprov " +
                                        "from arquivo_enviado order by data_envio";
        private const string _carrega = "select * from arquivo_enviado where codigo_envio = ?";
        private const string _exclui = "delete from arquivo_enviado where codigo_envio = ?";

        private const string _adiciona = "insert into arquivo_enviado (codigo_envio, tipo_arquivo, descricao_arquivo, " +
                                         "nome_Arquivo, tamanho_arquivo, codigo_usuario_envio, data_envio, codigo_usuario_aprov, " +
                                         "data_aprov, codigo_usuario_reprov, data_reprov, motivo_reprov) " +
                                         "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
        private const string _edita = "update arquivo_enviado " +
                                      "set " + 
                                                "tipo_arquivo=?," +
                                               "descricao_arquivo=?, " +
                                               "nome_Arquivo=?, " +
                                               "tamanho_arquivo=?, " +
                                               "codigo_usuario_envio=?, " +
                                               "data_envio=?, " +
                                               "codigo_usuario_aprov=?, " +
                                               "data_aprov=?, " +
                                               "codigo_usuario_reprov=?, " +
                                               "data_reprov=?, " +
                                               "motivo_reprov=? " +
                                      "WHERE codigo_envio = ?";

        private int _codigoEnvio = 0;
        private int _tipoArquivo =0;
        private string _descricaoArquivo = "";
        private string _nomeArquivo = "";
        private int _tamanhoArquivo = 0;
        private string _codigoUsuarioEnvio;
        private DateTime _dataEnvio;
        private string _codigoUsuario_aprov = "";
        private DateTime _dataAprov;
        private string _codigoUsuarioReprov = "";
        private DateTime _dataReprov;
        private string _motivoReprov;
        
        public int CodigoEnvio
        {
            get {
                    return _codigoEnvio;
                }

            set {
                    _codigoEnvio = value;
                }
        }

        public int TipoArquivo
        {
            get
            {
                return _tipoArquivo;
            }

            set
            {
                _tipoArquivo = value;
            }
        }

        public string DescricaoArquivo
        {
            get
            {
                return _descricaoArquivo;
            }

            set
            {
                _descricaoArquivo = value;
            }
        }

        public string NomeArquivo
        {
            get
            {
                return _nomeArquivo;
            }

            set
            {
                _nomeArquivo = value;
            }
        }

        public int TamanhoArquivo
        {
            get
            {
                return _tamanhoArquivo;
            }

            set
            {
                _tamanhoArquivo = value;
            }
        }

        public string CodigoUsuarioEnvio
        {
            get
            {
                return _codigoUsuarioEnvio;
            }

            set
            {
                _codigoUsuarioEnvio = value;
            }
        }

        public DateTime DataEnvio
        {
            get
            {
                return _dataEnvio;
            }

            set
            {
                _dataEnvio = value;
            }
        }

        public string CodigoUsuario_aprov
        {
            get
            {
                return _codigoUsuario_aprov;
            }

            set
            {
                _codigoUsuario_aprov = value;
            }
        }

        public DateTime DataAprov
        {
            get
            {
                return _dataAprov;
            }

            set
            {
                _dataAprov = value;
            }
        }

        public string CodigoUsuarioReprov
        {
            get
            {
                return _codigoUsuarioReprov;
            }

            set
            {
                _codigoUsuarioReprov = value;
            }
        }

        public DateTime DataReprov
        {
            get
            {
                return _dataReprov;
            }

            set
            {
                _dataReprov = value;
            }
        }

        public string MotivoReprov
        {
            get
            {
                return _motivoReprov;
            }

            set
            {
                _motivoReprov = value;
            }
        }

        public clsArquivoEnviado()
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
                odbcCMD.Parameters.Add("codigo_envio", OdbcType.Int).Value = usuario;

                OdbcDataReader reader = odbcCMD.ExecuteReader();

                while (reader.Read())
                {

                    _codigoEnvio = Convert.ToInt16(reader[0].ToString());
                    _tipoArquivo = Convert.ToInt16(reader[0].ToString());
                    _descricaoArquivo = reader[0].ToString();
                    _nomeArquivo = reader[0].ToString();
                    _tamanhoArquivo = Convert.ToInt16(reader[0].ToString());
                    _codigoUsuarioEnvio = reader[0].ToString();
                    _dataEnvio = Convert.ToDateTime(reader[0].ToString());
                    _codigoUsuario_aprov = reader[0].ToString();
                    _dataAprov = Convert.ToDateTime(reader[0].ToString());
                    _codigoUsuarioReprov = reader[0].ToString();
                    _dataReprov = Convert.ToDateTime(reader[0].ToString());
                    _motivoReprov = reader[0].ToString();

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

        public bool Incluir()
        {
            try
            {
                if (_meuBd.VerificarStatusConexao() == ConnectionState.Closed)
                    _meuBd.Conectar();

                OdbcCommand odbcCMD = new OdbcCommand(_adiciona, _meuBd.Connection);

                odbcCMD.Parameters.Add("codigo_envio", OdbcType.Int).Value = _codigoEnvio;
                odbcCMD.Parameters.Add("TipoArquivo", OdbcType.VarChar, 50).Value = _tipoArquivo;
                odbcCMD.Parameters.Add("Descricao_Arquivo", OdbcType.VarChar, 20).Value = _descricaoArquivo;
                odbcCMD.Parameters.Add("Nome_Arquivo", OdbcType.VarChar, 100).Value = _nomeArquivo;
                odbcCMD.Parameters.Add("Tamanho_Arquivo", OdbcType.TinyInt).Value = _tamanhoArquivo;
                odbcCMD.Parameters.Add("CodigoUsuarioEnvio", OdbcType.Bit).Value = _codigoUsuarioEnvio;
                odbcCMD.Parameters.Add("Data_Envio", OdbcType.VarChar, 20).Value = _dataEnvio;
                odbcCMD.Parameters.Add("Codigo_Usuario_aprov", OdbcType.VarChar, 50).Value = _codigoUsuario_aprov;
                odbcCMD.Parameters.Add("Data_Aprov", OdbcType.VarChar, 20).Value = _dataAprov;
                odbcCMD.Parameters.Add("Codigo_Usuario_Reprov", OdbcType.VarChar, 100).Value = _codigoUsuarioReprov;
                odbcCMD.Parameters.Add("Data_Reprov", OdbcType.TinyInt).Value = _dataReprov;
                odbcCMD.Parameters.Add("Motivo_Reprov", OdbcType.Bit).Value = _motivoReprov;


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
                odbcCMD.Parameters.Add("TipoArquivo", OdbcType.VarChar, 50).Value = _tipoArquivo;
                odbcCMD.Parameters.Add("Descricao_Arquivo", OdbcType.VarChar, 20).Value = _descricaoArquivo;
                odbcCMD.Parameters.Add("Nome_Arquivo", OdbcType.VarChar, 100).Value = _nomeArquivo;
                odbcCMD.Parameters.Add("Tamanho_Arquivo", OdbcType.TinyInt).Value = _tamanhoArquivo;
                odbcCMD.Parameters.Add("CodigoUsuarioEnvio", OdbcType.Bit).Value = _codigoUsuarioEnvio;
                odbcCMD.Parameters.Add("Data_Envio", OdbcType.VarChar, 20).Value = _dataEnvio;
                odbcCMD.Parameters.Add("Codigo_Usuario_aprov", OdbcType.VarChar, 50).Value = _codigoUsuario_aprov;
                odbcCMD.Parameters.Add("Data_Aprov", OdbcType.VarChar, 20).Value = _dataAprov;
                odbcCMD.Parameters.Add("Codigo_Usuario_Reprov", OdbcType.VarChar, 100).Value = _codigoUsuarioReprov;
                odbcCMD.Parameters.Add("Data_Reprov", OdbcType.TinyInt).Value = _dataReprov;
                odbcCMD.Parameters.Add("Motivo_Reprov", OdbcType.Bit).Value = _motivoReprov;
                odbcCMD.Parameters.Add("codigo_envio", OdbcType.Int).Value = _codigoEnvio;
                return odbcCMD.ExecuteNonQuery() == 1;
            }
            catch (OdbcException ex)
            {
                throw ex;
            }

        }

    }
}
