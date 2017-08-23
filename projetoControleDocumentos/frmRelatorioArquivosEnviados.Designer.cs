namespace projetoControleDocumentos
{
    partial class frmRelatorioArquivosEnviados
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDataDe = new System.Windows.Forms.DateTimePicker();
            this.dtpDataAte = new System.Windows.Forms.DateTimePicker();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data de:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Data até:";
            // 
            // dtpDataDe
            // 
            this.dtpDataDe.CustomFormat = "yyyy-MM-dd";
            this.dtpDataDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDe.Location = new System.Drawing.Point(75, 17);
            this.dtpDataDe.Name = "dtpDataDe";
            this.dtpDataDe.Size = new System.Drawing.Size(107, 20);
            this.dtpDataDe.TabIndex = 13;
            // 
            // dtpDataAte
            // 
            this.dtpDataAte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataAte.Location = new System.Drawing.Point(253, 16);
            this.dtpDataAte.Name = "dtpDataAte";
            this.dtpDataAte.Size = new System.Drawing.Size(109, 20);
            this.dtpDataAte.TabIndex = 14;
            // 
            // dgvReport
            // 
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(18, 43);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.Size = new System.Drawing.Size(659, 177);
            this.dgvReport.TabIndex = 15;
            this.dgvReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReport_CellContentClick);
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnConfirmar.Image = global::projetoControleDocumentos.Properties.Resources.page_white_excel;
            this.BtnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConfirmar.Location = new System.Drawing.Point(495, 226);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(88, 30);
            this.BtnConfirmar.TabIndex = 9;
            this.BtnConfirmar.Text = "Gerar";
            this.BtnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfirmar.UseVisualStyleBackColor = false;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::projetoControleDocumentos.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(589, 226);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 30);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCarregar
            // 
            this.btnCarregar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCarregar.Image = global::projetoControleDocumentos.Properties.Resources.database_refresh;
            this.btnCarregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCarregar.Location = new System.Drawing.Point(368, 7);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(88, 30);
            this.btnCarregar.TabIndex = 16;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarregar.UseVisualStyleBackColor = false;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // frmRelatorioArquivosEnviados
            // 
            this.AcceptButton = this.BtnConfirmar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(689, 263);
            this.ControlBox = false;
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.dtpDataAte);
            this.Controls.Add(this.dtpDataDe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Name = "frmRelatorioArquivosEnviados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de arquivos enviados";
            this.Load += new System.EventHandler(this.frmRelatorioArquivosEnviados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDataDe;
        private System.Windows.Forms.DateTimePicker dtpDataAte;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Button btnCarregar;
    }
}