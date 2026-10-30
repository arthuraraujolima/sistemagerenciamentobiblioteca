namespace P1___Gerenciamento_de_Biblioteca.Formularios
{
    partial class CadastroUsuarios
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.tNome = new System.Windows.Forms.TextBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.tEmail = new System.Windows.Forms.TextBox();
            this.tTelefone = new System.Windows.Forms.TextBox();
            this.bCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(104, 39);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(12, 109);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(86, 39);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 209);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(96, 39);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(12, 309);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(290, 39);
            this.lblTelefone.TabIndex = 3;
            this.lblTelefone.Text = "Telefone (11 dígitos):";
            // 
            // tNome
            // 
            this.tNome.Location = new System.Drawing.Point(18, 51);
            this.tNome.Name = "tNome";
            this.tNome.Size = new System.Drawing.Size(370, 46);
            this.tNome.TabIndex = 4;
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Aluno",
            "Professor"});
            this.cbTipo.Location = new System.Drawing.Point(18, 151);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(370, 47);
            this.cbTipo.TabIndex = 5;
            // 
            // tEmail
            // 
            this.tEmail.Location = new System.Drawing.Point(18, 251);
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(370, 46);
            this.tEmail.TabIndex = 6;
            // 
            // tTelefone
            // 
            this.tTelefone.Location = new System.Drawing.Point(18, 351);
            this.tTelefone.Name = "tTelefone";
            this.tTelefone.Size = new System.Drawing.Size(201, 46);
            this.tTelefone.TabIndex = 7;
            // 
            // bCadastrar
            // 
            this.bCadastrar.AutoSize = true;
            this.bCadastrar.Location = new System.Drawing.Point(121, 420);
            this.bCadastrar.Name = "bCadastrar";
            this.bCadastrar.Size = new System.Drawing.Size(170, 49);
            this.bCadastrar.TabIndex = 8;
            this.bCadastrar.Text = "Cadastrar";
            this.bCadastrar.UseVisualStyleBackColor = true;
            this.bCadastrar.Click += new System.EventHandler(this.bCadastrar_Click);
            // 
            // CadastroUsuarios
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(417, 490);
            this.Controls.Add(this.bCadastrar);
            this.Controls.Add(this.tTelefone);
            this.Controls.Add(this.tEmail);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.tNome);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblNome);
            this.Font = new System.Drawing.Font("Perpetua", 20.17F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(8)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "CadastroUsuarios";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuários";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CadastroUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone;
        public System.Windows.Forms.TextBox tNome;
        public System.Windows.Forms.ComboBox cbTipo;
        public System.Windows.Forms.TextBox tEmail;
        public System.Windows.Forms.TextBox tTelefone;
        private System.Windows.Forms.Button bCadastrar;
    }
}
