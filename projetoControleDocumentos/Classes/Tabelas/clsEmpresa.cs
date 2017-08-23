using System;
using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;

namespace projetoControleDocumentos
{
    class clsEmpresa{

        private readonly clsConexao _meuBd= new clsConexao();

        private const string _retorna = "select codigo_empresa, " +
                                               "razao_social, " +
                                               "protocolo_envio, " +
                                               "protocolo_autorizacao " +
                                        "from empresa order by codigo_empresa";
        private const string _carrega = "select * from empresa where codigo_empresa = ?";
        private const string _valida = "select * from empresa where codigo_empresa = ?";
        private const string _exclui = "delete from empresa where codigo_empresa = ?";
        private const string _adiciona = "insert into empresa (codigo_empresa, razao_social, protocolo_envio, protocolo_autorizacao) values (?, ?, ?, ?)";
        private const string _edita = "update empresa set razao_social = ?, protocolo_envio=?, protocolo_autorizacao=? WHERE codigo_empresa=?";
        private const string _editaProtocoloEnvio = "update empresa set protocolo_envio=protocolo_envio+1";
        private const string _editaProtocoloAut = "update empresa set protocolo_autorizacao=protocolo_autorizacao+1";

        private int _codigoEmpresa = 0;
        private string _razaoSocial = "";
        private int _protocoloEnvio = 0;
        private int _protocoloAutorizacao = 0;


        public int CodigoEmpresa
        {
            get { return _codigoEmpresa; }
            set { _codigoEmpresa = value; }
        }
        public string RazaoSocial
        {
            get { return _razaoSocial; }
            set { _razaoSocial = value; }
        }
        public int ProtocoloEnvio
        {
            get { return _protocoloEnvio; }
            set { _protocoloEnvio = value; }
        }
        public int ProtocoloAutorizacao
        {
            get { return _protocoloAutorizacao; }
            set { _protocoloAutorizacao = value; }
        }
       
        public clsEmpresa()
        {
        
        }

        public BindingSource dsEmpresa()
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

        public bool Carregar(int empresa)
        {
            try
            {
                if (_meuBd.VerificarStatusConexao() == ConnectionState.Closed)
                    _meuBd.Conectar();

                OdbcCommand odbcCMD = new OdbcCommand(_carrega, _meuBd.Connection);

                OdbcDataReader reader = odbcCMD.ExecuteReader();

                while (reader.Read())
                {

                    _codigoEmpresa = Convert.ToInt16(reader[0]);
                    _razaoSocial = reader[1].ToString();
                    _protocoloEnvio = Convert.ToInt32(reader[2]);
                    _protocoloAutorizacao = Convert.ToInt32(reader[3]);

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

                OdbcCommand odbcCMD = new OdbcCommand(_adiciona, _meuBd.Connection);

                odbcCMD.Parameters.Add("codigo_empresa", OdbcType.VarChar, 20).Value = _codigoEmpresa;
                odbcCMD.Parameters.Add("razao_social", OdbcType.VarChar, 50).Value = _razaoSocial;
                odbcCMD.Parameters.Add("protocolo_envio", OdbcType.Int).Value = _protocoloEnvio;
                odbcCMD.Parameters.Add("protocolo_autorizacao", OdbcType.Int).Value = _protocoloAutorizacao;

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
                odbcCMD.Parameters.Add("razao_social", OdbcType.VarChar, 50).Value = _razaoSocial;
                odbcCMD.Parameters.Add("protocolo_envio", OdbcType.Int).Value = _protocoloEnvio;
                odbcCMD.Parameters.Add("protocolo_autorizacao", OdbcType.Int).Value = _protocoloAutorizacao;
                odbcCMD.Parameters.Add("codigo_empresa", OdbcType.VarChar, 20).Value = _codigoEmpresa;
                return odbcCMD.ExecuteNonQuery() == 1;
            }
            catch (OdbcException ex)
            {
                throw ex;
            }
        }

        public bool AtualizarProtocoloEnvio()
        {
            try
            {
                if (_meuBd.VerificarStatusConexao() == ConnectionState.Closed)
                    _meuBd.Conectar();

                OdbcCommand odbcCMD = new OdbcCommand(_editaProtocoloEnvio, _meuBd.Connection);
                return odbcCMD.ExecuteNonQuery() == 1;
            }
            catch (OdbcException ex)
            {
                throw ex;
            }
        }

        public bool AtualizarProtocoloAutorizacao()
        {
            try
            {
                if (_meuBd.VerificarStatusConexao() == ConnectionState.Closed)
                    _meuBd.Conectar();

                OdbcCommand odbcCMD = new OdbcCommand(_editaProtocoloAut, _meuBd.Connection);
                return odbcCMD.ExecuteNonQuery() == 1;
            }
            catch (OdbcException ex)
            {
                throw ex;
            }
        }
    }
}
