namespace P1___Gerenciamento_de_Biblioteca.Formularios
{
    partial class AtualizaUsuarios
    {
        /// <summary>
        /// Variável obrigatória do designer.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Libera os recursos utilizados pelo formulário.
        /// </summary>
        /// <param name="disposing">true para liberar recursos gerenciados; false caso contrário.</param>
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
        /// Método obrigatório para suporte ao Designer — não modifique
        /// o conteúdo deste método pelo editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtualizaUsuarios));
            this.bAtualizarTelefone = new System.Windows.Forms.Button();
            this.bAtualizarEmail = new System.Windows.Forms.Button();
            this.tEmail = new System.Windows.Forms.TextBox();
            this.tIdUsuario = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.tTelefone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bAtualizarTelefone
            // 
            this.bAtualizarTelefone.AutoSize = true;
            this.bAtualizarTelefone.Location = new System.Drawing.Point(239, 275);
            this.bAtualizarTelefone.Name = "bAtualizarTelefone";
            this.bAtualizarTelefone.Size = new System.Drawing.Size(149, 49);
            this.bAtualizarTelefone.TabIndex = 19;
            this.bAtualizarTelefone.Text = "Atualizar";
            this.bAtualizarTelefone.UseVisualStyleBackColor = true;
            this.bAtualizarTelefone.Click += new System.EventHandler(this.bAtualizarTelefone_Click);
            // 
            // bAtualizarEmail
            // 
            this.bAtualizarEmail.AutoSize = true;
            this.bAtualizarEmail.Location = new System.Drawing.Point(239, 163);
            this.bAtualizarEmail.Name = "bAtualizarEmail";
            this.bAtualizarEmail.Size = new System.Drawing.Size(149, 49);
            this.bAtualizarEmail.TabIndex = 17;
            this.bAtualizarEmail.Text = "Atualizar";
            this.bAtualizarEmail.UseVisualStyleBackColor = true;
            this.bAtualizarEmail.Click += new System.EventHandler(this.bAtualizarEmail_Click);
            // 
            // tEmail
            // 
            this.tEmail.Location = new System.Drawing.Point(18, 166);
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(201, 46);
            this.tEmail.TabIndex = 15;
            // 
            // tIdUsuario
            // 
            this.tIdUsuario.Location = new System.Drawing.Point(18, 53);
            this.tIdUsuario.Name = "tIdUsuario";
            this.tIdUsuario.Size = new System.Drawing.Size(201, 46);
            this.tIdUsuario.TabIndex = 14;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 122);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(96, 39);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email:";
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Location = new System.Drawing.Point(13, 11);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(198, 39);
            this.lblIdUsuario.TabIndex = 12;
            this.lblIdUsuario.Text = "Id do Usuário:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(13, 236);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(137, 39);
            this.lblTelefone.TabIndex = 10;
            this.lblTelefone.Text = "Telefone:";
            // 
            // tTelefone
            // 
            this.tTelefone.Location = new System.Drawing.Point(20, 278);
            this.tTelefone.Name = "tTelefone";
            this.tTelefone.Size = new System.Drawing.Size(201, 46);
            this.tTelefone.TabIndex = 20;
            // 
            // AtualizaUsuarios
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(417, 386);
            this.Controls.Add(this.tTelefone);
            this.Controls.Add(this.bAtualizarTelefone);
            this.Controls.Add(this.bAtualizarEmail);
            this.Controls.Add(this.tEmail);
            this.Controls.Add(this.tIdUsuario);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblIdUsuario);
            this.Controls.Add(this.lblTelefone);
            this.Font = new System.Drawing.Font("Perpetua", 20.17F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(8)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "AtualizaUsuarios";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualização de cadastro de usuários";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AtualizaUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAtualizarTelefone;
        private System.Windows.Forms.Button bAtualizarEmail;
        public System.Windows.Forms.TextBox tEmail;
        public System.Windows.Forms.TextBox tIdUsuario;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblIdUsuario;
        private System.Windows.Forms.Label lblTelefone;
        public System.Windows.Forms.TextBox tTelefone;
    }
}