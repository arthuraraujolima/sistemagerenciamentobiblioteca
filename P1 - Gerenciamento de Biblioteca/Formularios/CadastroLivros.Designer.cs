namespace P1___Gerenciamento_de_Biblioteca.Formularios
{
    partial class CadastroLivros
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblEditora = new System.Windows.Forms.Label();
            this.lblAnoPublicacao = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblQntDisponivel = new System.Windows.Forms.Label();
            this.tTitulo = new System.Windows.Forms.TextBox();
            this.tAutor = new System.Windows.Forms.TextBox();
            this.tEditora = new System.Windows.Forms.TextBox();
            this.tAnoPublicacao = new System.Windows.Forms.TextBox();
            this.tQuantidade = new System.Windows.Forms.TextBox();
            this.tQntDisponivel = new System.Windows.Forms.TextBox();
            this.bCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(104, 39);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título:";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(12, 109);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(101, 39);
            this.lblAutor.TabIndex = 1;
            this.lblAutor.Text = "Autor:";
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.Location = new System.Drawing.Point(12, 209);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(118, 39);
            this.lblEditora.TabIndex = 2;
            this.lblEditora.Text = "Editora:";
            // 
            // lblAnoPublicacao
            // 
            this.lblAnoPublicacao.AutoSize = true;
            this.lblAnoPublicacao.Location = new System.Drawing.Point(12, 309);
            this.lblAnoPublicacao.Name = "lblAnoPublicacao";
            this.lblAnoPublicacao.Size = new System.Drawing.Size(217, 39);
            this.lblAnoPublicacao.TabIndex = 3;
            this.lblAnoPublicacao.Text = "Ano Publicação:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(12, 409);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(244, 39);
            this.lblQuantidade.TabIndex = 4;
            this.lblQuantidade.Text = "Quantidade Total:";
            // 
            // lblQntDisponivel
            // 
            this.lblQntDisponivel.AutoSize = true;
            this.lblQntDisponivel.Location = new System.Drawing.Point(12, 509);
            this.lblQntDisponivel.Name = "lblQntDisponivel";
            this.lblQntDisponivel.Size = new System.Drawing.Size(313, 39);
            this.lblQntDisponivel.TabIndex = 11;
            this.lblQntDisponivel.Text = "Quantidade Disponível:";
            // 
            // tTitulo
            // 
            this.tTitulo.Location = new System.Drawing.Point(18, 51);
            this.tTitulo.Name = "tTitulo";
            this.tTitulo.Size = new System.Drawing.Size(370, 46);
            this.tTitulo.TabIndex = 5;
            // 
            // tAutor
            // 
            this.tAutor.Location = new System.Drawing.Point(18, 151);
            this.tAutor.Name = "tAutor";
            this.tAutor.Size = new System.Drawing.Size(370, 46);
            this.tAutor.TabIndex = 6;
            // 
            // tEditora
            // 
            this.tEditora.Location = new System.Drawing.Point(18, 251);
            this.tEditora.Name = "tEditora";
            this.tEditora.Size = new System.Drawing.Size(370, 46);
            this.tEditora.TabIndex = 7;
            // 
            // tAnoPublicacao
            // 
            this.tAnoPublicacao.Location = new System.Drawing.Point(18, 351);
            this.tAnoPublicacao.Name = "tAnoPublicacao";
            this.tAnoPublicacao.Size = new System.Drawing.Size(201, 46);
            this.tAnoPublicacao.TabIndex = 8;
            // 
            // tQuantidade
            // 
            this.tQuantidade.Location = new System.Drawing.Point(18, 451);
            this.tQuantidade.Name = "tQuantidade";
            this.tQuantidade.Size = new System.Drawing.Size(201, 46);
            this.tQuantidade.TabIndex = 9;
            // 
            // tQntDisponivel
            // 
            this.tQntDisponivel.Location = new System.Drawing.Point(18, 551);
            this.tQntDisponivel.Name = "tQntDisponivel";
            this.tQntDisponivel.Size = new System.Drawing.Size(201, 46);
            this.tQntDisponivel.TabIndex = 12;
            // 
            // bCadastrar
            // 
            this.bCadastrar.AutoSize = true;
            this.bCadastrar.Location = new System.Drawing.Point(19, 616);
            this.bCadastrar.Name = "bCadastrar";
            this.bCadastrar.Size = new System.Drawing.Size(170, 49);
            this.bCadastrar.TabIndex = 15;
            this.bCadastrar.Text = "Cadastrar";
            this.bCadastrar.UseVisualStyleBackColor = true;
            this.bCadastrar.Click += new System.EventHandler(this.bCadastrar_Click);
            // 
            // CadastroLivros
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(417, 686);
            this.Controls.Add(this.bCadastrar);
            this.Controls.Add(this.tQntDisponivel);
            this.Controls.Add(this.lblQntDisponivel);
            this.Controls.Add(this.tQuantidade);
            this.Controls.Add(this.tAnoPublicacao);
            this.Controls.Add(this.tEditora);
            this.Controls.Add(this.tAutor);
            this.Controls.Add(this.tTitulo);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblAnoPublicacao);
            this.Controls.Add(this.lblEditora);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Perpetua", 20.17F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(8)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "CadastroLivros";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Livros";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CadastroLivros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblEditora;
        private System.Windows.Forms.Label lblAnoPublicacao;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblQntDisponivel;
        public System.Windows.Forms.TextBox tTitulo;
        public System.Windows.Forms.TextBox tAutor;
        public System.Windows.Forms.TextBox tEditora;
        public System.Windows.Forms.TextBox tAnoPublicacao;
        public System.Windows.Forms.TextBox tQuantidade;
        public System.Windows.Forms.TextBox tQntDisponivel;
        private System.Windows.Forms.Button bCadastrar;
    }
}
