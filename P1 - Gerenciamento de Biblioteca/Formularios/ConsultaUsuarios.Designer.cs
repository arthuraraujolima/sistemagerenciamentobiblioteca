namespace P1___Gerenciamento_de_Biblioteca.Formularios
{
    partial class ConsultaUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaUsuarios));
            this.bConsultarTodosUsuários = new System.Windows.Forms.Button();
            this.bConsultarEmail = new System.Windows.Forms.Button();
            this.bConsultarNome = new System.Windows.Forms.Button();
            this.tEmailUsuario = new System.Windows.Forms.TextBox();
            this.tNomeUsuario = new System.Windows.Forms.TextBox();
            this.lblEmailUsuario = new System.Windows.Forms.Label();
            this.lblUsuarioNome = new System.Windows.Forms.Label();
            this.lblTodosUsuarios = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bConsultarTodosUsuários
            // 
            this.bConsultarTodosUsuários.AutoSize = true;
            this.bConsultarTodosUsuários.Location = new System.Drawing.Point(232, 260);
            this.bConsultarTodosUsuários.Name = "bConsultarTodosUsuários";
            this.bConsultarTodosUsuários.Size = new System.Drawing.Size(149, 49);
            this.bConsultarTodosUsuários.TabIndex = 19;
            this.bConsultarTodosUsuários.Text = "Consultar";
            this.bConsultarTodosUsuários.UseVisualStyleBackColor = true;
            this.bConsultarTodosUsuários.Click += new System.EventHandler(this.bConsultarTodosUsuários_Click);
            // 
            // bConsultarEmail
            // 
            this.bConsultarEmail.AutoSize = true;
            this.bConsultarEmail.Location = new System.Drawing.Point(232, 175);
            this.bConsultarEmail.Name = "bConsultarEmail";
            this.bConsultarEmail.Size = new System.Drawing.Size(149, 49);
            this.bConsultarEmail.TabIndex = 17;
            this.bConsultarEmail.Text = "Consultar";
            this.bConsultarEmail.UseVisualStyleBackColor = true;
            this.bConsultarEmail.Click += new System.EventHandler(this.bConsultarEmail_Click);
            // 
            // bConsultarNome
            // 
            this.bConsultarNome.AutoSize = true;
            this.bConsultarNome.Location = new System.Drawing.Point(232, 62);
            this.bConsultarNome.Name = "bConsultarNome";
            this.bConsultarNome.Size = new System.Drawing.Size(149, 49);
            this.bConsultarNome.TabIndex = 16;
            this.bConsultarNome.Text = "Consultar";
            this.bConsultarNome.UseVisualStyleBackColor = true;
            this.bConsultarNome.Click += new System.EventHandler(this.bConsultarNome_Click);
            // 
            // tEmailUsuario
            // 
            this.tEmailUsuario.Location = new System.Drawing.Point(11, 175);
            this.tEmailUsuario.Name = "tEmailUsuario";
            this.tEmailUsuario.Size = new System.Drawing.Size(201, 46);
            this.tEmailUsuario.TabIndex = 15;
            // 
            // tNomeUsuario
            // 
            this.tNomeUsuario.Location = new System.Drawing.Point(11, 62);
            this.tNomeUsuario.Name = "tNomeUsuario";
            this.tNomeUsuario.Size = new System.Drawing.Size(201, 46);
            this.tNomeUsuario.TabIndex = 14;
            // 
            // lblEmailUsuario
            // 
            this.lblEmailUsuario.AutoSize = true;
            this.lblEmailUsuario.Location = new System.Drawing.Point(5, 131);
            this.lblEmailUsuario.Name = "lblEmailUsuario";
            this.lblEmailUsuario.Size = new System.Drawing.Size(96, 39);
            this.lblEmailUsuario.TabIndex = 13;
            this.lblEmailUsuario.Text = "Email:";
            // 
            // lblUsuarioNome
            // 
            this.lblUsuarioNome.AutoSize = true;
            this.lblUsuarioNome.Location = new System.Drawing.Point(5, 18);
            this.lblUsuarioNome.Name = "lblUsuarioNome";
            this.lblUsuarioNome.Size = new System.Drawing.Size(104, 39);
            this.lblUsuarioNome.TabIndex = 12;
            this.lblUsuarioNome.Text = "Nome:";
            // 
            // lblTodosUsuarios
            // 
            this.lblTodosUsuarios.AutoSize = true;
            this.lblTodosUsuarios.Location = new System.Drawing.Point(5, 270);
            this.lblTodosUsuarios.Name = "lblTodosUsuarios";
            this.lblTodosUsuarios.Size = new System.Drawing.Size(215, 39);
            this.lblTodosUsuarios.TabIndex = 10;
            this.lblTodosUsuarios.Text = "Todos usuários:";
            // 
            // ConsultaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(402, 371);
            this.Controls.Add(this.bConsultarTodosUsuários);
            this.Controls.Add(this.bConsultarEmail);
            this.Controls.Add(this.bConsultarNome);
            this.Controls.Add(this.tEmailUsuario);
            this.Controls.Add(this.tNomeUsuario);
            this.Controls.Add(this.lblEmailUsuario);
            this.Controls.Add(this.lblUsuarioNome);
            this.Controls.Add(this.lblTodosUsuarios);
            this.Font = new System.Drawing.Font("Perpetua", 20.17F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(8)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConsultaUsuarios";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Usuários";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ConsultaUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bConsultarTodosUsuários;
        private System.Windows.Forms.Button bConsultarEmail;
        private System.Windows.Forms.Button bConsultarNome;
        public System.Windows.Forms.TextBox tEmailUsuario;
        public System.Windows.Forms.TextBox tNomeUsuario;
        private System.Windows.Forms.Label lblEmailUsuario;
        private System.Windows.Forms.Label lblUsuarioNome;
        private System.Windows.Forms.Label lblTodosUsuarios;
    }
}