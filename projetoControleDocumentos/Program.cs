using System;
using System.Windows.Forms;
using System.Runtime.Remoting.Contexts;

namespace projetoControleDocumentos
{
    static class Program
    {
        static ApplicationContext MainContext = new ApplicationContext();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //clsMensagem.Informacao(Convert.ToDecimal("3.4,234").ToString());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainContext.MainForm = new frmIdentificacao();
            Application.Run(MainContext);
        }

        public static void SetMainForm(Form MainForm)
        {
            MainContext.MainForm = MainForm;
        }

        public static void ShowMainForm()
        {
            MainContext.MainForm.Show();
        }

    }
}
