using System;
using System.Data;
using System.Data.Odbc;
using System.Globalization;
using System.IO;
using System.Threading;

namespace projetoControleDocumentos
{
    class clsAcesso
    {
        clsConexao _meuBd = new clsConexao();

        public clsAcesso()
        {
        
        }

        public string Dlookup(string Campo, string Tabela, string Criterio)
        {
            try
            {
                if (_meuBd.VerificarStatusConexao() == ConnectionState.Closed)
                    _meuBd.Conectar();

                string strSQL = "select " + Campo + " from " + Tabela + (Criterio != "" ? " where " + Criterio: "" );
                OdbcCommand odbcCMD = new OdbcCommand( strSQL, _meuBd.Connection);

                OdbcDataReader dr = odbcCMD.ExecuteReader();

                if (dr.HasRows)
                    return dr[0].ToString();
                else
                    return null;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public byte[] DlookupArrayByte(string Campo, string Tabela, string Criterio)
        {
            try
            {
                if (_meuBd.VerificarStatusConexao() == ConnectionState.Closed)
                    _meuBd.Conectar();

                string strSQL = "select " + Campo + " from " + Tabela + (Criterio != "" ? " where " + Criterio : "");
                OdbcCommand odbcCMD = new OdbcCommand(strSQL, _meuBd.Connection);

                OdbcDataReader dr = odbcCMD.ExecuteReader();

                if (dr.HasRows)
                    return (byte[])dr.GetValue(0);
                else
                    return null;

                dr.Close();
                dr.Dispose();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }

}
