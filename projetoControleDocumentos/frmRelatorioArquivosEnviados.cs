using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Office.Interop;
using System.Text;
using System.IO;

namespace projetoControleDocumentos
{
    public partial class frmRelatorioArquivosEnviados : Form
    {

        public frmRelatorioArquivosEnviados()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (dgvReport.Rows.Count > 0)
            {
                try
                {
                    string linha="";
                    
                   
                    //Cabeçalho
                    for (int i = 1; i < dgvReport.Columns.Count + 1; i++)
                    {
                        //XcelApp.Cells[1, i] = dgvReport.Columns[i - 1].HeaderText;
                        linha = linha + dgvReport.Columns[i - 1].HeaderText.ToString() + ";";
                    }

                    linha = linha + Environment.NewLine;

                    //detalhes
                    for (int i = 0; i <= dgvReport.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dgvReport.Columns.Count; j++)
                        {
                            linha = linha + dgvReport.Rows[i].Cells[j].Value.ToString() + ";";
                        }

                        linha = linha + Environment.NewLine;
                    }

                    string filePath = Environment.CurrentDirectory + @"\ArquivosEnviados.csv";

                    File.WriteAllText(filePath, linha);

                    //abrir arquivo
                    System.Diagnostics.Process.Start(filePath);
                }
                catch (Exception ex)
                {
                    clsMensagem.Atencao(ex.Message.ToString());
                }
            }


        }

        private void dgvReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {

            if (dtpDataDe.Text == "" || dtpDataAte.Text == "")
            {
                clsMensagem.Atencao("informe a data de e a data até!");
            }


            string strSQL = "Select " +
                                "data_envio 'Data Envio', " +
                                "nome_usuario 'Nome do usuário', " +
                                "nome_Arquivo 'Nome do Arquivo', " +
                                "descricao_tipo 'Tipo de Arquivo', " +
                                "tamanho_arquivo 'Tamanho Arquivo', " +
                                "descricao_arquivo 'Descrição do arquivo', " +
                                "data_aprov 'Data Aprovação', " +
                                "data_reprov 'Data Reprovação', " +
                                "motivo_reprov 'Motivo da reprovação' " +
                            "From arquivo_enviado arq " +
                                "inner join usuario usuEnv " +
                                    "on arq.codigo_usuario_envio = usuEnv.codigo_usuario " +
                                "inner join tipo_documento tipo " +
                                    "on arq.tipo_Arquivo = tipo.codigo_tipo " +
                            "where data_envio between '"  + dtpDataDe.Value.Date.ToString("yyyy-MM-dd") + "' and '" + 
                                                            dtpDataAte.Value.Date.ToString("yyyy-MM-dd") + "' " +
                            "order by data_envio, nome_usuario";

            clsArquivoEnviado myClass = new clsArquivoEnviado();
            dgvReport.DataSource = myClass.dsRelatorio(strSQL);
        }

        private void frmRelatorioArquivosEnviados_Load(object sender, EventArgs e)
        {
            dtpDataDe.Format = DateTimePickerFormat.Custom;
            dtpDataAte.Format = DateTimePickerFormat.Custom;
            dtpDataDe.CustomFormat = "yyyy-MM-dd";
            dtpDataAte.CustomFormat = "yyyy-MM-dd";

        }
    }
}

