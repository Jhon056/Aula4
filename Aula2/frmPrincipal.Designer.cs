namespace Aula2
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnMostrarMensagem = new System.Windows.Forms.Button();
            this.btnTabuada = new System.Windows.Forms.Button();
            this.btnImagens = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Freestyle Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(36, 102);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 37);
            this.lblMensagem.TabIndex = 0;
            // 
            // btnMostrarMensagem
            // 
            this.btnMostrarMensagem.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarMensagem.Location = new System.Drawing.Point(80, 200);
            this.btnMostrarMensagem.Name = "btnMostrarMensagem";
            this.btnMostrarMensagem.Size = new System.Drawing.Size(136, 28);
            this.btnMostrarMensagem.TabIndex = 1;
            this.btnMostrarMensagem.Text = "Mostrar Mensagem";
            this.btnMostrarMensagem.UseVisualStyleBackColor = true;
            this.btnMostrarMensagem.Click += new System.EventHandler(this.btnMostrarMensagem_Click);
            // 
            // btnTabuada
            // 
            this.btnTabuada.Image = global::Aula2.Properties.Resources.Calculadora_certaaa2;
            this.btnTabuada.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTabuada.Location = new System.Drawing.Point(211, 27);
            this.btnTabuada.Name = "btnTabuada";
            this.btnTabuada.Size = new System.Drawing.Size(81, 58);
            this.btnTabuada.TabIndex = 4;
            this.btnTabuada.Text = "Calculadora";
            this.btnTabuada.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTabuada.UseVisualStyleBackColor = true;
            this.btnTabuada.Click += new System.EventHandler(this.btnTabuada_Click);
            // 
            // btnImagens
            // 
            this.btnImagens.Image = global::Aula2.Properties.Resources.Simbolo_imagem_1;
            this.btnImagens.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImagens.Location = new System.Drawing.Point(119, 27);
            this.btnImagens.Name = "btnImagens";
            this.btnImagens.Size = new System.Drawing.Size(86, 58);
            this.btnImagens.TabIndex = 3;
            this.btnImagens.Text = "Imagens";
            this.btnImagens.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImagens.UseVisualStyleBackColor = true;
            this.btnImagens.Click += new System.EventHandler(this.btnImagens_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Aula2.Properties.Resources.CheckBox_Redimensionada_4;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(12, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "CheckBox";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 261);
            this.Controls.Add(this.btnTabuada);
            this.Controls.Add(this.btnImagens);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMostrarMensagem);
            this.Controls.Add(this.lblMensagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Primeiro Aplicativo em C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Button btnMostrarMensagem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnImagens;
        private System.Windows.Forms.Button btnTabuada;
    }
}

