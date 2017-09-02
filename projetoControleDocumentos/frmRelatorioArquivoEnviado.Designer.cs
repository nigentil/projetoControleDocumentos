namespace projetoControleDocumentos
{
    partial class frmRelatorioArquivoEnviado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.SP_Relatorio_ArquivoEnviadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DB_ConDocDataSet = new projetoControleDocumentos.DB_ConDocDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SP_Relatorio_ArquivoEnviadoTableAdapter = new projetoControleDocumentos.DB_ConDocDataSetTableAdapters.SP_Relatorio_ArquivoEnviadoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SP_Relatorio_ArquivoEnviadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_ConDocDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // SP_Relatorio_ArquivoEnviadoBindingSource
            // 
            this.SP_Relatorio_ArquivoEnviadoBindingSource.DataMember = "SP_Relatorio_ArquivoEnviado";
            this.SP_Relatorio_ArquivoEnviadoBindingSource.DataSource = this.DB_ConDocDataSet;
            // 
            // DB_ConDocDataSet
            // 
            this.DB_ConDocDataSet.DataSetName = "DB_ConDocDataSet";
            this.DB_ConDocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SP_Relatorio_ArquivoEnviadoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "projetoControleDocumentos.rptArquivoEnviado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(731, 307);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            this.reportViewer1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.reportViewer1_KeyDown);
            this.reportViewer1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.reportViewer1_KeyPress);
            // 
            // SP_Relatorio_ArquivoEnviadoTableAdapter
            // 
            this.SP_Relatorio_ArquivoEnviadoTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatorioArquivoEnviado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 307);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "frmRelatorioArquivoEnviado";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Arquivo Enviado";
            this.Load += new System.EventHandler(this.frmArquivoEnviado_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRelatorioArquivoEnviado_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.SP_Relatorio_ArquivoEnviadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_ConDocDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_Relatorio_ArquivoEnviadoBindingSource;
        private DB_ConDocDataSet DB_ConDocDataSet;
        private DB_ConDocDataSetTableAdapters.SP_Relatorio_ArquivoEnviadoTableAdapter SP_Relatorio_ArquivoEnviadoTableAdapter;
    }
}