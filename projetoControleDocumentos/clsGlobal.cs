using System;

namespace projetoControleDocumentos
{
    public static class clsGlobal
    {
        private static int _perfil = 0;
        private static string _login = "";
        private static int _arquivo;

        public static int Perfil
        {
            get { return _perfil; }
            set { _perfil = value; }
        }
        
        public static string Login
        {
            get { return _login; }
            set { _login = value; }
        }

        public static int Arquivo
        {
            get
            {
                return _arquivo;
            }

            set
            {
                _arquivo = value;
            }
        }
    }
}

