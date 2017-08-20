using System.Windows.Forms;

namespace projetoControleDocumentos
{
    static class clsMensagem
    {
        public static bool Erro(string mensagem)
        {
            MessageBox.Show(mensagem, "Quadrante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return true;
        }

        public static bool Informacao(string mensagem)
        {
            MessageBox.Show(mensagem, "Quadrante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        public static bool Pergunta(string mensagem)
        {
            return MessageBox.Show(mensagem, "Quadrante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        public static bool Atencao(string mensagem)
        {
            MessageBox.Show(mensagem, "Quadrante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return true;
        }

    }
}
