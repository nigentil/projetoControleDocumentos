namespace projetoControleDocumentos
{
    partial class frmPrincipal_Aprovacao
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoEnvio = new System.Windows.Forms.TextBox();
            this.txtDescricaoArquivo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtTipoArquivo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMotivoRejeicao = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDataEnvio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNomeArquivo = new System.Windows.Forms.TextBox();
            this.rdbAprovado = new System.Windows.Forms.RadioButton();
            this.rdbReprovado = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // txtCodigoEnvio
            // 
            this.txtCodigoEnvio.Enabled = false;
            this.txtCodigoEnvio.Location = new System.Drawing.Point(78, 13);
            this.txtCodigoEnvio.Name = "txtCodigoEnvio";
            this.txtCodigoEnvio.Size = new System.Drawing.Size(49, 20);
            this.txtCodigoEnvio.TabIndex = 1;
            // 
            // txtDescricaoArquivo
            // 
            this.txtDescricaoArquivo.Enabled = false;
            this.txtDescricaoArquivo.Location = new System.Drawing.Point(78, 91);
            this.txtDescricaoArquivo.Multiline = true;
            this.txtDescricaoArquivo.Name = "txtDescricaoArquivo";
            this.txtDescricaoArquivo.Size = new System.Drawing.Size(443, 43);
            this.txtDescricaoArquivo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descrição:";
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Image = global::projetoControleDocumentos.Properties.Resources.database_save;
            this.BtnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConfirmar.Location = new System.Drawing.Point(339, 232);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(88, 30);
            this.BtnConfirmar.TabIndex = 12;
            this.BtnConfirmar.Text = "Salvar";
            this.BtnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::projetoControleDocumentos.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(433, 232);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 30);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtTipoArquivo
            // 
            this.txtTipoArquivo.Enabled = false;
            this.txtTipoArquivo.Location = new System.Drawing.Point(78, 39);
            this.txtTipoArquivo.Name = "txtTipoArquivo";
            this.txtTipoArquivo.Size = new System.Drawing.Size(443, 20);
            this.txtTipoArquivo.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tipo Arq:";
            // 
            // txtMotivoRejeicao
            // 
            this.txtMotivoRejeicao.Enabled = false;
            this.txtMotivoRejeicao.Location = new System.Drawing.Point(78, 183);
            this.txtMotivoRejeicao.Multiline = true;
            this.txtMotivoRejeicao.Name = "txtMotivoRejeicao";
            this.txtMotivoRejeicao.Size = new System.Drawing.Size(443, 43);
            this.txtMotivoRejeicao.TabIndex = 11;
            this.txtMotivoRejeicao.TextChanged += new System.EventHandler(this.txtMotivoRejeicao_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(75, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Motivo da reprovação";
            // 
            // txtDataEnvio
            // 
            this.txtDataEnvio.Enabled = false;
            this.txtDataEnvio.Location = new System.Drawing.Point(370, 13);
            this.txtDataEnvio.Name = "txtDataEnvio";
            this.txtDataEnvio.Size = new System.Drawing.Size(151, 20);
            this.txtDataEnvio.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(307, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Dta Envio:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Nome:";
            // 
            // txtNomeArquivo
            // 
            this.txtNomeArquivo.Enabled = false;
            this.txtNomeArquivo.Location = new System.Drawing.Point(78, 65);
            this.txtNomeArquivo.Name = "txtNomeArquivo";
            this.txtNomeArquivo.Size = new System.Drawing.Size(443, 20);
            this.txtNomeArquivo.TabIndex = 34;
            // 
            // rdbAprovado
            // 
            this.rdbAprovado.AutoSize = true;
            this.rdbAprovado.Location = new System.Drawing.Point(197, 149);
            this.rdbAprovado.Name = "rdbAprovado";
            this.rdbAprovado.Size = new System.Drawing.Size(71, 17);
            this.rdbAprovado.TabIndex = 36;
            this.rdbAprovado.TabStop = true;
            this.rdbAprovado.Text = "Aprovado";
            this.rdbAprovado.UseVisualStyleBackColor = true;
            this.rdbAprovado.CheckedChanged += new System.EventHandler(this.rdbAprovado_CheckedChanged);
            // 
            // rdbReprovado
            // 
            this.rdbReprovado.AutoSize = true;
            this.rdbReprovado.Location = new System.Drawing.Point(288, 149);
            this.rdbReprovado.Name = "rdbReprovado";
            this.rdbReprovado.Size = new System.Drawing.Size(78, 17);
            this.rdbReprovado.TabIndex = 37;
            this.rdbReprovado.TabStop = true;
            this.rdbReprovado.Text = "Reprovado";
            this.rdbReprovado.UseVisualStyleBackColor = true;
            this.rdbReprovado.CheckedChanged += new System.EventHandler(this.rdbReprovado_CheckedChanged);
            // 
            // frmPrincipal_Aprovacao
            // 
            this.AcceptButton = this.BtnConfirmar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(533, 270);
            this.ControlBox = false;
            this.Controls.Add(this.rdbReprovado);
            this.Controls.Add(this.rdbAprovado);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtNomeArquivo);
            this.Controls.Add(this.txtDataEnvio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMotivoRejeicao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTipoArquivo);
            this.Controls.Add(this.BtnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtDescricaoArquivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodigoEnvio);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Name = "frmPrincipal_Aprovacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aprovação Arquivo";
            this.Load += new System.EventHandler(this.frmEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoEnvio;
        private System.Windows.Forms.TextBox txtDescricaoArquivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txtTipoArquivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMotivoRejeicao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDataEnvio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNomeArquivo;
        private System.Windows.Forms.RadioButton rdbAprovado;
        private System.Windows.Forms.RadioButton rdbReprovado;
    }
}