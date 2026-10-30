namespace P1___Gerenciamento_de_Biblioteca.Formularios
{
    partial class ConsultaLivros
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
            this.lblTodosLivros = new System.Windows.Forms.Label();
            this.lblLivrosDisponiveis = new System.Windows.Forms.Label();
            this.lblLivroTítulo = new System.Windows.Forms.Label();
            this.lblLivroAutor = new System.Windows.Forms.Label();
            this.tTituloLivro = new System.Windows.Forms.TextBox();
            this.tAutorLivro = new System.Windows.Forms.TextBox();
            this.bConsultarTitulo = new System.Windows.Forms.Button();
            this.bConsultarAutor = new System.Windows.Forms.Button();
            this.bConsultarLivrosDisponiveis = new System.Windows.Forms.Button();
            this.bConsultarTodosLivros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTodosLivros
            // 
            this.lblTodosLivros.AutoSize = true;
            this.lblTodosLivros.Location = new System.Drawing.Point(12, 284);
            this.lblTodosLivros.Name = "lblTodosLivros";
            this.lblTodosLivros.Size = new System.Drawing.Size(105, 39);
            this.lblTodosLivros.TabIndex = 0;
            this.lblTodosLivros.Text = "Todos:";
            // 
            // lblLivrosDisponiveis
            // 
            this.lblLivrosDisponiveis.AutoSize = true;
            this.lblLivrosDisponiveis.Location = new System.Drawing.Point(233, 284);
            this.lblLivrosDisponiveis.Name = "lblLivrosDisponiveis";
            this.lblLivrosDisponiveis.Size = new System.Drawing.Size(172, 39);
            this.lblLivrosDisponiveis.TabIndex = 1;
            this.lblLivrosDisponiveis.Text = "Disponíveis:";
            // 
            // lblLivroTítulo
            // 
            this.lblLivroTítulo.AutoSize = true;
            this.lblLivroTítulo.Location = new System.Drawing.Point(12, 32);
            this.lblLivroTítulo.Name = "lblLivroTítulo";
            this.lblLivroTítulo.Size = new System.Drawing.Size(104, 39);
            this.lblLivroTítulo.TabIndex = 2;
            this.lblLivroTítulo.Text = "Título:";
            // 
            // lblLivroAutor
            // 
            this.lblLivroAutor.AutoSize = true;
            this.lblLivroAutor.Location = new System.Drawing.Point(12, 145);
            this.lblLivroAutor.Name = "lblLivroAutor";
            this.lblLivroAutor.Size = new System.Drawing.Size(101, 39);
            this.lblLivroAutor.TabIndex = 3;
            this.lblLivroAutor.Text = "Autor:";
            // 
            // tTituloLivro
            // 
            this.tTituloLivro.Location = new System.Drawing.Point(18, 76);
            this.tTituloLivro.Name = "tTituloLivro";
            this.tTituloLivro.Size = new System.Drawing.Size(201, 46);
            this.tTituloLivro.TabIndex = 4;
            // 
            // tAutorLivro
            // 
            this.tAutorLivro.Location = new System.Drawing.Point(18, 189);
            this.tAutorLivro.Name = "tAutorLivro";
            this.tAutorLivro.Size = new System.Drawing.Size(201, 46);
            this.tAutorLivro.TabIndex = 5;
            // 
            // bConsultarTitulo
            // 
            this.bConsultarTitulo.AutoSize = true;
            this.bConsultarTitulo.Location = new System.Drawing.Point(239, 76);
            this.bConsultarTitulo.Name = "bConsultarTitulo";
            this.bConsultarTitulo.Size = new System.Drawing.Size(149, 49);
            this.bConsultarTitulo.TabIndex = 6;
            this.bConsultarTitulo.Text = "Consultar";
            this.bConsultarTitulo.UseVisualStyleBackColor = true;
            this.bConsultarTitulo.Click += new System.EventHandler(this.bConsultarTitulo_Click);
            // 
            // bConsultarAutor
            // 
            this.bConsultarAutor.AutoSize = true;
            this.bConsultarAutor.Location = new System.Drawing.Point(239, 189);
            this.bConsultarAutor.Name = "bConsultarAutor";
            this.bConsultarAutor.Size = new System.Drawing.Size(149, 49);
            this.bConsultarAutor.TabIndex = 7;
            this.bConsultarAutor.Text = "Consultar";
            this.bConsultarAutor.UseVisualStyleBackColor = true;
            this.bConsultarAutor.Click += new System.EventHandler(this.bConsultarAutor_Click);
            // 
            // bConsultarLivrosDisponiveis
            // 
            this.bConsultarLivrosDisponiveis.AutoSize = true;
            this.bConsultarLivrosDisponiveis.Location = new System.Drawing.Point(239, 318);
            this.bConsultarLivrosDisponiveis.Name = "bConsultarLivrosDisponiveis";
            this.bConsultarLivrosDisponiveis.Size = new System.Drawing.Size(149, 49);
            this.bConsultarLivrosDisponiveis.TabIndex = 8;
            this.bConsultarLivrosDisponiveis.Text = "Consultar";
            this.bConsultarLivrosDisponiveis.UseVisualStyleBackColor = true;
            this.bConsultarLivrosDisponiveis.Click += new System.EventHandler(this.bConsultarLivrosDisponiveis_Click);
            // 
            // bConsultarTodosLivros
            // 
            this.bConsultarTodosLivros.AutoSize = true;
            this.bConsultarTodosLivros.Location = new System.Drawing.Point(18, 318);
            this.bConsultarTodosLivros.Name = "bConsultarTodosLivros";
            this.bConsultarTodosLivros.Size = new System.Drawing.Size(149, 49);
            this.bConsultarTodosLivros.TabIndex = 9;
            this.bConsultarTodosLivros.Text = "Consultar";
            this.bConsultarTodosLivros.UseVisualStyleBackColor = true;
            this.bConsultarTodosLivros.Click += new System.EventHandler(this.bConsultarTodosLivros_Click);
            // 
            // ConsultaLivros
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(402, 371);
            this.Controls.Add(this.bConsultarTodosLivros);
            this.Controls.Add(this.bConsultarLivrosDisponiveis);
            this.Controls.Add(this.bConsultarAutor);
            this.Controls.Add(this.bConsultarTitulo);
            this.Controls.Add(this.tAutorLivro);
            this.Controls.Add(this.tTituloLivro);
            this.Controls.Add(this.lblLivroAutor);
            this.Controls.Add(this.lblLivroTítulo);
            this.Controls.Add(this.lblLivrosDisponiveis);
            this.Controls.Add(this.lblTodosLivros);
            this.Font = new System.Drawing.Font("Perpetua", 20.17F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(8)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "ConsultaLivros";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Consulta de Livros";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ConsultaLivros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTodosLivros;
        private System.Windows.Forms.Label lblLivrosDisponiveis;
        private System.Windows.Forms.Label lblLivroTítulo;
        private System.Windows.Forms.Label lblLivroAutor;
        private System.Windows.Forms.Button bConsultarTitulo;
        private System.Windows.Forms.Button bConsultarAutor;
        private System.Windows.Forms.Button bConsultarLivrosDisponiveis;
        private System.Windows.Forms.Button bConsultarTodosLivros;
        public System.Windows.Forms.TextBox tTituloLivro;
        public System.Windows.Forms.TextBox tAutorLivro;
    }
}