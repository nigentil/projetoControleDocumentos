using System;
using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;

namespace projetoControleDocumentos
{
    class clsTipoDocumento{

        private readonly clsConexao _meuBd= new clsConexao();

        private const string _retorna = "select codigo_tipo, " +
                                               "descricao_tipo " +
                                        "from tipo_documento order by descricao_tipo";
        private const string _carrega = "select * from tipo_documento where codigo_tipo = ?";
        private const string _exclui = "delete from tipo_documento where codigo_tipo = ?";
        private const string _adiciona = "insert into tipo_documento (descricao_tipo) VALUES (?)";
        private const string _edita = "update tipo_documento set descricao_tipo = ? WHERE codigo_usuario = ?";

        private int _codigoTipo = 0;
        private string _descricaoTipo = "";

        public int CodigoTipo
        {
            get { return _codigoTipo; }
            set { _codigoTipo = value; }
        }
        public string DescricaoTipo
        {
            get { return _descricaoTipo; }
            set { _descricaoTipo = value; }
        }
       
        public clsTipoDocumento()
        {
        
        }

        public BindingSource dsTipoDocumento()
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

        public bool Carregar(int codigo)
        {
            try
            {
                if (_meuBd.VerificarStatusConexao() == ConnectionState.Closed)
                    _meuBd.Conectar();

                OdbcCommand odbcCMD = new OdbcCommand(_carrega, _meuBd.Connection);
                odbcCMD.Parameters.Add("codigo_tipo", OdbcType.Int).Value = codigo;

                OdbcDataReader reader = odbcCMD.ExecuteReader();

                while (reader.Read())
                {

                    _codigoTipo = Convert.ToInt16(reader[0]);
                    _descricaoTipo = reader[1].ToString();
                    
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

                odbcCMD.Parameters.Add("descricao_tipo", OdbcType.VarChar, 50).Value = _descricaoTipo;

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
                odbcCMD.Parameters.Add("codigo_tipo", OdbcType.Int, 20).Value = codigo;
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
                odbcCMD.Parameters.Add("descricao_tipo", OdbcType.VarChar,50).Value = _descricaoTipo;
                odbcCMD.Parameters.Add("codigo_tipo", OdbcType.Int, 20).Value = _codigoTipo;
                return odbcCMD.ExecuteNonQuery() == 1;
            }
            catch (OdbcException ex)
            {
                throw ex;
            }

        }

    }
}
