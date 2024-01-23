namespace Aula2
{
    partial class frmPropriedadesCheckBox
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
            this.pessoaJuridica = new System.Windows.Forms.CheckBox();
            this.pessoaFisica = new System.Windows.Forms.CheckBox();
            this.gpPessoaFisica = new System.Windows.Forms.GroupBox();
            this.txtCpf1 = new System.Windows.Forms.TextBox();
            this.txtNome1 = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.gpPessoaJuridica = new System.Windows.Forms.GroupBox();
            this.txtCpf2 = new System.Windows.Forms.TextBox();
            this.txtNome2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gpPessoaFisica.SuspendLayout();
            this.gpPessoaJuridica.SuspendLayout();
            this.SuspendLayout();
            // 
            // pessoaJuridica
            // 
            this.pessoaJuridica.AutoSize = true;
            this.pessoaJuridica.Location = new System.Drawing.Point(50, 150);
            this.pessoaJuridica.Name = "pessoaJuridica";
            this.pessoaJuridica.Size = new System.Drawing.Size(121, 17);
            this.pessoaJuridica.TabIndex = 11;
            this.pessoaJuridica.Text = "PESSOA JURIDICA";
            this.pessoaJuridica.UseVisualStyleBackColor = true;
            this.pessoaJuridica.CheckStateChanged += new System.EventHandler(this.pessoaJuridica_CheckStateChanged);
            // 
            // pessoaFisica
            // 
            this.pessoaFisica.AutoSize = true;
            this.pessoaFisica.Location = new System.Drawing.Point(50, 116);
            this.pessoaFisica.Name = "pessoaFisica";
            this.pessoaFisica.Size = new System.Drawing.Size(105, 17);
            this.pessoaFisica.TabIndex = 10;
            this.pessoaFisica.Text = "PESSOA FISICA";
            this.pessoaFisica.UseVisualStyleBackColor = true;
            this.pessoaFisica.CheckStateChanged += new System.EventHandler(this.pessoaFisica_CheckStateChanged);
            // 
            // gpPessoaFisica
            // 
            this.gpPessoaFisica.Controls.Add(this.txtCpf1);
            this.gpPessoaFisica.Controls.Add(this.txtNome1);
            this.gpPessoaFisica.Controls.Add(this.lblCpf);
            this.gpPessoaFisica.Controls.Add(this.lblNome);
            this.gpPessoaFisica.Location = new System.Drawing.Point(245, 48);
            this.gpPessoaFisica.Name = "gpPessoaFisica";
            this.gpPessoaFisica.Size = new System.Drawing.Size(171, 85);
            this.gpPessoaFisica.TabIndex = 8;
            this.gpPessoaFisica.TabStop = false;
            this.gpPessoaFisica.Visible = false;
            // 
            // txtCpf1
            // 
            this.txtCpf1.Location = new System.Drawing.Point(64, 48);
            this.txtCpf1.Name = "txtCpf1";
            this.txtCpf1.Size = new System.Drawing.Size(85, 20);
            this.txtCpf1.TabIndex = 3;
            // 
            // txtNome1
            // 
            this.txtNome1.Location = new System.Drawing.Point(64, 19);
            this.txtNome1.Name = "txtNome1";
            this.txtNome1.Size = new System.Drawing.Size(85, 20);
            this.txtNome1.TabIndex = 2;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(20, 51);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(33, 13);
            this.lblCpf.TabIndex = 1;
            this.lblCpf.Text = "CPF: ";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(17, 22);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(42, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "NOME:";
            // 
            // gpPessoaJuridica
            // 
            this.gpPessoaJuridica.Controls.Add(this.txtCpf2);
            this.gpPessoaJuridica.Controls.Add(this.txtNome2);
            this.gpPessoaJuridica.Controls.Add(this.label1);
            this.gpPessoaJuridica.Controls.Add(this.label2);
            this.gpPessoaJuridica.Location = new System.Drawing.Point(245, 154);
            this.gpPessoaJuridica.Name = "gpPessoaJuridica";
            this.gpPessoaJuridica.Size = new System.Drawing.Size(171, 85);
            this.gpPessoaJuridica.TabIndex = 9;
            this.gpPessoaJuridica.TabStop = false;
            this.gpPessoaJuridica.Text = "\'";
            this.gpPessoaJuridica.Visible = false;
            // 
            // txtCpf2
            // 
            this.txtCpf2.Location = new System.Drawing.Point(64, 48);
            this.txtCpf2.Name = "txtCpf2";
            this.txtCpf2.Size = new System.Drawing.Size(85, 20);
            this.txtCpf2.TabIndex = 3;
            // 
            // txtNome2
            // 
            this.txtNome2.Location = new System.Drawing.Point(64, 19);
            this.txtNome2.Name = "txtNome2";
            this.txtNome2.Size = new System.Drawing.Size(85, 20);
            this.txtNome2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CNPJ: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "NOME: ";
            // 
            // frmPropriedadesCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 308);
            this.Controls.Add(this.pessoaJuridica);
            this.Controls.Add(this.pessoaFisica);
            this.Controls.Add(this.gpPessoaFisica);
            this.Controls.Add(this.gpPessoaJuridica);
            this.Name = "frmPropriedadesCheckBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Propriedades do Check Box";
            this.gpPessoaFisica.ResumeLayout(false);
            this.gpPessoaFisica.PerformLayout();
            this.gpPessoaJuridica.ResumeLayout(false);
            this.gpPessoaJuridica.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox pessoaJuridica;
        private System.Windows.Forms.CheckBox pessoaFisica;
        private System.Windows.Forms.GroupBox gpPessoaFisica;
        private System.Windows.Forms.TextBox txtCpf1;
        private System.Windows.Forms.TextBox txtNome1;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox gpPessoaJuridica;
        private System.Windows.Forms.TextBox txtCpf2;
        private System.Windows.Forms.TextBox txtNome2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}