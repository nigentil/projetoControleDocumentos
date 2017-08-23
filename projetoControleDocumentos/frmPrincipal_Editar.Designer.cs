namespace projetoControleDocumentos
{
    partial class frmPrincipal_Editar
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
            this.txtCodigoUsuarioReprov = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtTipoArquivo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProtAut = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigoUsuarioAprov = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDataReprov = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMotivoRejeicao = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDataAprov = new System.Windows.Forms.TextBox();
            this.txtDataEnvio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtProtEnvio = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNomeArquivo = new System.Windows.Forms.TextBox();
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
            this.txtCodigoEnvio.TextChanged += new System.EventHandler(this.txtCodigoEmpresa_TextChanged);
            // 
            // txtDescricaoArquivo
            // 
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
            this.BtnConfirmar.Location = new System.Drawing.Point(339, 290);
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
            this.btnCancelar.Location = new System.Drawing.Point(433, 290);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 30);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtCodigoUsuarioReprov
            // 
            this.txtCodigoUsuarioReprov.Enabled = false;
            this.txtCodigoUsuarioReprov.Location = new System.Drawing.Point(387, 169);
            this.txtCodigoUsuarioReprov.Name = "txtCodigoUsuarioReprov";
            this.txtCodigoUsuarioReprov.Size = new System.Drawing.Size(134, 20);
            this.txtCodigoUsuarioReprov.TabIndex = 9;
            this.txtCodigoUsuarioReprov.TextChanged += new System.EventHandler(this.txtProtAut_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Usuário Reprov.:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTipoArquivo
            // 
            this.txtTipoArquivo.Enabled = false;
            this.txtTipoArquivo.Location = new System.Drawing.Point(78, 39);
            this.txtTipoArquivo.Name = "txtTipoArquivo";
            this.txtTipoArquivo.Size = new System.Drawing.Size(443, 20);
            this.txtTipoArquivo.TabIndex = 3;
            this.txtTipoArquivo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // txtProtAut
            // 
            this.txtProtAut.Enabled = false;
            this.txtProtAut.Location = new System.Drawing.Point(387, 195);
            this.txtProtAut.Name = "txtProtAut";
            this.txtProtAut.Size = new System.Drawing.Size(134, 20);
            this.txtProtAut.TabIndex = 10;
            this.txtProtAut.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Protocolo Aut.:";
            // 
            // txtCodigoUsuarioAprov
            // 
            this.txtCodigoUsuarioAprov.Enabled = false;
            this.txtCodigoUsuarioAprov.Location = new System.Drawing.Point(387, 140);
            this.txtCodigoUsuarioAprov.Name = "txtCodigoUsuarioAprov";
            this.txtCodigoUsuarioAprov.Size = new System.Drawing.Size(134, 20);
            this.txtCodigoUsuarioAprov.TabIndex = 6;
            this.txtCodigoUsuarioAprov.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Usuário aprov.:";
            // 
            // txtDataReprov
            // 
            this.txtDataReprov.Enabled = false;
            this.txtDataReprov.Location = new System.Drawing.Point(78, 169);
            this.txtDataReprov.Name = "txtDataReprov";
            this.txtDataReprov.Size = new System.Drawing.Size(169, 20);
            this.txtDataReprov.TabIndex = 8;
            this.txtDataReprov.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Dta Reprov:";
            // 
            // txtMotivoRejeicao
            // 
            this.txtMotivoRejeicao.Enabled = false;
            this.txtMotivoRejeicao.Location = new System.Drawing.Point(15, 241);
            this.txtMotivoRejeicao.Multiline = true;
            this.txtMotivoRejeicao.Name = "txtMotivoRejeicao";
            this.txtMotivoRejeicao.Size = new System.Drawing.Size(506, 43);
            this.txtMotivoRejeicao.TabIndex = 11;
            this.txtMotivoRejeicao.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Motivo da reprovação";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dta Aprov:";
            // 
            // txtDataAprov
            // 
            this.txtDataAprov.Enabled = false;
            this.txtDataAprov.Location = new System.Drawing.Point(78, 143);
            this.txtDataAprov.Name = "txtDataAprov";
            this.txtDataAprov.Size = new System.Drawing.Size(169, 20);
            this.txtDataAprov.TabIndex = 5;
            this.txtDataAprov.TextChanged += new System.EventHandler(this.txtProtEnvio_TextChanged);
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
            // txtProtEnvio
            // 
            this.txtProtEnvio.Enabled = false;
            this.txtProtEnvio.Location = new System.Drawing.Point(78, 198);
            this.txtProtEnvio.Name = "txtProtEnvio";
            this.txtProtEnvio.Size = new System.Drawing.Size(169, 20);
            this.txtProtEnvio.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Prot. Env.:";
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
            // frmPrincipal_Editar
            // 
            this.AcceptButton = this.BtnConfirmar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(533, 331);
            this.ControlBox = false;
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtNomeArquivo);
            this.Controls.Add(this.txtProtEnvio);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDataEnvio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMotivoRejeicao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDataReprov);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCodigoUsuarioAprov);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtProtAut);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTipoArquivo);
            this.Controls.Add(this.txtCodigoUsuarioReprov);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtDataAprov);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescricaoArquivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodigoEnvio);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Name = "frmPrincipal_Editar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arquivo enviado";
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
        private System.Windows.Forms.TextBox txtCodigoUsuarioReprov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txtTipoArquivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProtAut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigoUsuarioAprov;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDataReprov;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMotivoRejeicao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDataAprov;
        private System.Windows.Forms.TextBox txtDataEnvio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtProtEnvio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNomeArquivo;
    }
}