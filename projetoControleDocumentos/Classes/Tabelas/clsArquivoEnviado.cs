using System;
using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace projetoControleDocumentos
{
    class clsArquivoEnviado : clsAcesso
    {

        private readonly clsConexao _meuBd= new clsConexao();

        private const string _retorna = "select codigo_envio, " +
                                               "descricao_tipo," +
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
                                        "from arquivo_enviado arq " + 
                                            "inner join tipo_documento tipo " +
                                                "on arq.tipo_arquivo = tipo.codigo_tipo " +
                                        "order by data_envio";

        private const string _retornaUser = "select codigo_envio, " +
                                       "descricao_tipo," +
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
                                "from arquivo_enviado arq " +
                                    "inner join tipo_documento tipo " +
                                        "on arq.tipo_arquivo = tipo.codigo_tipo " +
                                "where codigo_usuario_envio= ? " +
                                "order by data_envio";
        private const string _carrega = "select Arq.*, descricao_tipo from arquivo_enviado arq " +
                                            "inner join tipo_documento tipo "  +
                                                "on arq.tipo_Arquivo = tipo.codigo_tipo " +
                                        "where codigo_envio = ?";

        private const string _exclui = "delete from arquivo_enviado where codigo_envio = ?";

        private const string _adiciona = "insert into arquivo_enviado (tipo_arquivo, descricao_arquivo, " +
                                         "nome_Arquivo, tamanho_arquivo, arquivo, codigo_usuario_envio, data_envio, protocolo_envio) " +
                                         "VALUES (?, ?, ?, ?, ?, ?, ?, ?)";

        private const string _edita = "update arquivo_enviado " +
                                      "set " + 
                                               "descricao_arquivo=? " +
                                      "WHERE codigo_envio = ?";

        private const string _aprova = "update arquivo_enviado " +
                                     "set " +
                                              "codigo_usuario_aprov=?, " +
                                              "data_aprov = ?, " +
                                              "protocolo_aut=? " +
                                     "WHERE codigo_envio = ?";

        private const string _reprova = "update arquivo_enviado " +
                                     "set " +
                                              "codigo_usuario_reprov=?, " +
                                              "data_reprov = ?, " +
                                              "motivo_reprov = ? " +
                                      "WHERE codigo_envio = ?";

        private int _codigoEnvio = 0;
        private int _tipoArquivo =0;
        private string _descricaoTipo = "";
        private string _descricaoArquivo = "";
        private string _nomeArquivo = "";
        private string _caminhoArquivo = "";
        private int _tamanhoArquivo = 0;
        private string _codigoUsuarioEnvio;
        private DateTime _dataEnvio;
        private int _protocoloEnvio;
        private string _codigoUsuario_aprov = "";
        private DateTime _dataAprov;
        private int _protocoloAutorizacao;
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

        public string CaminhoArquivo
        {
            get
            {
                return _caminhoArquivo;
            }

            set
            {
                _caminhoArquivo = value;
            }
        }

        public string DescricaoTipo
        {
            get
            {
                return _descricaoTipo;
            }

            set
            {
                _descricaoTipo = value;
            }
        }

        public int ProtocoloEnvio
        {
            get
            {
                return _protocoloEnvio;
            }

            set
            {
                _protocoloEnvio = value;
            }
        }

        public int ProtocoloAutorizacao
        {
            get
            {
                return _protocoloAutorizacao;
            }

            set
            {
                _protocoloAutorizacao = value;
            }
        }

        public clsArquivoEnviado()
        {
        
        }

        public BindingSource dsArquivo()
        {
            try
            {
                if (_meuBd.VerificarStatusConexao() == ConnectionState.Closed)
                    _meuBd.Conectar();

                OdbcCommand odbcCMD = new OdbcCommand(clsGlobal.Perfil==1 ? _retorna :_retornaUser, _meuBd.Connection);

                //só entra aqui se usuário não for aprovador
                if (clsGlobal.Perfil==0)
                    odbcCMD.Parameters.Add("codigo_usuario_envio", OdbcType.VarChar, 20).Value = clsGlobal.Login;

                BindingSource bs = new BindingSource();
                bs.DataSource = odbcCMD.ExecuteReader();

                return bs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BindingSource dsRelatorio(string strSQL)
        {
            try
            {
                if (_meuBd.VerificarStatusConexao() == ConnectionState.Closed)
                    _meuBd.Conectar();

                OdbcCommand odbcCMD = new OdbcCommand(strSQL, _meuBd.Connection);
                BindingSource bs = new BindingSource();
                bs.DataSource = odbcCMD.ExecuteReader();

                return bs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Carregar(int arquivo)
        {
            try
            {
                if (_meuBd.VerificarStatusConexao() == ConnectionState.Closed)
                    _meuBd.Conectar();

                OdbcCommand odbcCMD = new OdbcCommand(_carrega, _meuBd.Connection);
                odbcCMD.Parameters.Add("codigo_envio", OdbcType.Int).Value = arquivo;

                OdbcDataReader reader = odbcCMD.ExecuteReader();

                while (reader.Read())
                {

                    _codigoEnvio = Convert.ToInt16(reader["codigo_envio"].ToString());
                    _tipoArquivo = Convert.ToInt16(reader["tipo_arquivo"].ToString());
                    _descricaoTipo = reader["descricao_tipo"].ToString();
                    _descricaoArquivo = reader["descricao_arquivo"].ToString();
                    _nomeArquivo = reader["nome_arquivo"].ToString();
                    _tamanhoArquivo = Convert.ToInt16(reader["tamanho_arquivo"].ToString());
                    _codigoUsuarioEnvio = reader["codigo_usuario_envio"].ToString();
                    _dataEnvio = Convert.ToDateTime(reader["data_envio"].ToString());
                    _codigoUsuario_aprov = reader["codigo_usuario_aprov"].ToString();

                    if (reader["data_aprov"].ToString()!="")
                        _dataAprov = Convert.ToDateTime(reader["data_aprov"].ToString());

                    _codigoUsuarioReprov = reader["codigo_usuario_reprov"].ToString();
                    if(reader["data_reprov"].ToString()!="")
                        _dataReprov = Convert.ToDateTime(reader["data_reprov"].ToString());

                    _motivoReprov = reader["motivo_reprov"].ToString();
                    _protocoloEnvio = Convert.ToInt32(reader["protocolo_envio"].ToString());
                    if(reader["protocolo_aut"].ToString() != "")
                        _protocoloAutorizacao = Convert.ToInt32(reader["protocolo_aut"].ToString());

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

        public bool Incluir()
        {
            try
            {
                if (_meuBd.VerificarStatusConexao() == ConnectionState.Closed)
                    _meuBd.Conectar();

                clsAcesso myClass = new clsAcesso();

                int _protEnvio = DateTime.Now.Year * 10000 + Convert.ToInt16(myClass.Dlookup("protocolo_envio", "empresa", "")) + 1;
                
                //Carrega o arquivo em um array de bytes
                StreamReader stread = new StreamReader(_caminhoArquivo);

                byte[] buffer = new byte[stread.BaseStream.Length];
                _tamanhoArquivo = Convert.ToInt32(stread.BaseStream.Length) /1024;

                stread.BaseStream.Read(buffer, 0, buffer.Length);

                stread.Close();
                stread.Dispose();

                OdbcCommand odbcCMD = new OdbcCommand(_adiciona, _meuBd.Connection);

                odbcCMD.Parameters.Add("TipoArquivo", OdbcType.VarChar, 50).Value = _tipoArquivo;
                odbcCMD.Parameters.Add("Descricao_Arquivo", OdbcType.VarChar, 20).Value = _descricaoArquivo;
                odbcCMD.Parameters.Add("Nome_Arquivo", OdbcType.VarChar, 100).Value = Path.GetFileName(_caminhoArquivo);
                odbcCMD.Parameters.Add("Tamanho_Arquivo", OdbcType.BigInt).Value = _tamanhoArquivo;
                odbcCMD.Parameters.Add("Arquivo", OdbcType.Image).Value = buffer;
                odbcCMD.Parameters.Add("CodigoUsuarioEnvio", OdbcType.VarChar,20).Value = clsGlobal.Login;
                odbcCMD.Parameters.Add("Data_Envio", OdbcType.DateTime).Value = DateTime.Now;
                odbcCMD.Parameters.Add("Protocolo_Envio", OdbcType.Int).Value = _protEnvio;

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

        public bool Excluir(int codigo)
        {

            bool bolDeuCerto;
            try
            {

                if (_meuBd.VerificarStatusConexao() == ConnectionState.Closed)
                    _meuBd.Conectar();

                OdbcCommand odbcCMD = new OdbcCommand(_exclui, _meuBd.Connection);
                odbcCMD.Parameters.Add("codigo_envio", OdbcType.Int).Value = codigo;
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
                odbcCMD.Parameters.Add("Descricao_Arquivo", OdbcType.VarChar, 255).Value = _descricaoArquivo;
                odbcCMD.Parameters.Add("codigo_envio", OdbcType.Int).Value = _codigoEnvio;
                return odbcCMD.ExecuteNonQuery() == 1;
            }
            catch (OdbcException ex)
            {
                throw ex;
            }

        }

        public bool Aprovar()
        {
            try
            {
                if (_meuBd.VerificarStatusConexao() == ConnectionState.Closed)
                    _meuBd.Conectar();

                OdbcCommand odbcCMD = new OdbcCommand(_aprova, _meuBd.Connection);
                odbcCMD.Parameters.Add("Codigo_Usuario_aprov", OdbcType.VarChar, 20).Value = _codigoUsuario_aprov;
                odbcCMD.Parameters.Add("Data_Aprov", OdbcType.DateTime).Value = DateTime.Now;
                odbcCMD.Parameters.Add("Protocolo_aut", OdbcType.Int).Value = _protocoloAutorizacao;
                odbcCMD.Parameters.Add("codigo_envio", OdbcType.Int).Value = _codigoEnvio;
                return odbcCMD.ExecuteNonQuery() == 1;
            }
            catch (OdbcException ex)
            {
                throw ex;
            }

        }

        public bool Reprovar()
        {
            try
            {
                if (_meuBd.VerificarStatusConexao() == ConnectionState.Closed)
                    _meuBd.Conectar();

                OdbcCommand odbcCMD = new OdbcCommand(_reprova, _meuBd.Connection);
                odbcCMD.Parameters.Add("Codigo_Usuario_Reprov", OdbcType.VarChar, 20).Value = _codigoUsuarioReprov;
                odbcCMD.Parameters.Add("Data_Reprov", OdbcType.DateTime).Value = DateTime.Now;
                odbcCMD.Parameters.Add("Motivo_Reprov", OdbcType.VarChar, 255).Value = _motivoReprov;
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
