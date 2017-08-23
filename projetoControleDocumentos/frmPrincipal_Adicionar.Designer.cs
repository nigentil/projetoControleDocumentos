namespace projetoControleDocumentos
{
    partial class frmPrincipal_Adicionar
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
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbTipoArquivo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricaoArquivo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtArquivo
            // 
            this.txtArquivo.Location = new System.Drawing.Point(103, 12);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(301, 20);
            this.txtArquivo.TabIndex = 1;
            this.txtArquivo.TextChanged += new System.EventHandler(this.txtArquivo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Selecionar arquivo:";
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Image = global::projetoControleDocumentos.Properties.Resources.database_save;
            this.BtnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConfirmar.Location = new System.Drawing.Point(260, 146);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(88, 30);
            this.BtnConfirmar.TabIndex = 4;
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
            this.btnCancelar.Location = new System.Drawing.Point(354, 146);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 30);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Image = global::projetoControleDocumentos.Properties.Resources.find;
            this.btnLocalizar.Location = new System.Drawing.Point(410, 9);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(32, 25);
            this.btnLocalizar.TabIndex = 1;
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // cmbTipoArquivo
            // 
            this.cmbTipoArquivo.FormattingEnabled = true;
            this.cmbTipoArquivo.Location = new System.Drawing.Point(103, 38);
            this.cmbTipoArquivo.Name = "cmbTipoArquivo";
            this.cmbTipoArquivo.Size = new System.Drawing.Size(301, 21);
            this.cmbTipoArquivo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tipo de Arquivo:";
            // 
            // txtDescricaoArquivo
            // 
            this.txtDescricaoArquivo.Location = new System.Drawing.Point(103, 65);
            this.txtDescricaoArquivo.Multiline = true;
            this.txtDescricaoArquivo.Name = "txtDescricaoArquivo";
            this.txtDescricaoArquivo.Size = new System.Drawing.Size(339, 75);
            this.txtDescricaoArquivo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Descrição Arquivo";
            // 
            // frmPrincipal_Adicionar
            // 
            this.AcceptButton = this.BtnConfirmar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(454, 188);
            this.ControlBox = false;
            this.Controls.Add(this.txtDescricaoArquivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTipoArquivo);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.BtnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtArquivo);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Name = "frmPrincipal_Adicionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enviar Arquivo";
            this.Load += new System.EventHandler(this.frmPrincipal_Adicionar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.ComboBox cmbTipoArquivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricaoArquivo;
        private System.Windows.Forms.Label label2;
    }
}