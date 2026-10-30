namespace P1___Gerenciamento_de_Biblioteca.Formularios
{
    partial class AtualizaLivros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtualizaLivros));
            this.tAutor = new System.Windows.Forms.TextBox();
            this.bLivroDisponivel = new System.Windows.Forms.Button();
            this.bAtualizarTitulo = new System.Windows.Forms.Button();
            this.tTituloLivro = new System.Windows.Forms.TextBox();
            this.tIdLivro = new System.Windows.Forms.TextBox();
            this.lblTituloLivro = new System.Windows.Forms.Label();
            this.lblIdLivro = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.tEditora = new System.Windows.Forms.TextBox();
            this.bAtualizarEditora = new System.Windows.Forms.Button();
            this.lblEditora = new System.Windows.Forms.Label();
            this.tQntTotal = new System.Windows.Forms.TextBox();
            this.bAtualizarQntTotal = new System.Windows.Forms.Button();
            this.lblQntTotal = new System.Windows.Forms.Label();
            this.tQntDisponivel = new System.Windows.Forms.TextBox();
            this.bAtualizarQntDisponivel = new System.Windows.Forms.Button();
            this.lblQntDisponivel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tAutor
            // 
            this.tAutor.Location = new System.Drawing.Point(19, 276);
            this.tAutor.Name = "tAutor";
            this.tAutor.Size = new System.Drawing.Size(201, 46);
            this.tAutor.TabIndex = 28;
            // 
            // bLivroDisponivel
            // 
            this.bLivroDisponivel.AutoSize = true;
            this.bLivroDisponivel.Location = new System.Drawing.Point(238, 273);
            this.bLivroDisponivel.Name = "bLivroDisponivel";
            this.bLivroDisponivel.Size = new System.Drawing.Size(149, 49);
            this.bLivroDisponivel.TabIndex = 27;
            this.bLivroDisponivel.Text = "Atualizar";
            this.bLivroDisponivel.UseVisualStyleBackColor = true;
            this.bLivroDisponivel.Click += new System.EventHandler(this.bAtualizarAutor_Click);
            // 
            // bAtualizarTitulo
            // 
            this.bAtualizarTitulo.AutoSize = true;
            this.bAtualizarTitulo.Location = new System.Drawing.Point(238, 161);
            this.bAtualizarTitulo.Name = "bAtualizarTitulo";
            this.bAtualizarTitulo.Size = new System.Drawing.Size(149, 49);
            this.bAtualizarTitulo.TabIndex = 26;
            this.bAtualizarTitulo.Text = "Atualizar";
            this.bAtualizarTitulo.UseVisualStyleBackColor = true;
            this.bAtualizarTitulo.Click += new System.EventHandler(this.bAtualizarTitulo_Click);
            // 
            // tTituloLivro
            // 
            this.tTituloLivro.Location = new System.Drawing.Point(17, 164);
            this.tTituloLivro.Name = "tTituloLivro";
            this.tTituloLivro.Size = new System.Drawing.Size(201, 46);
            this.tTituloLivro.TabIndex = 25;
            // 
            // tIdLivro
            // 
            this.tIdLivro.Location = new System.Drawing.Point(17, 51);
            this.tIdLivro.Name = "tIdLivro";
            this.tIdLivro.Size = new System.Drawing.Size(201, 46);
            this.tIdLivro.TabIndex = 24;
            // 
            // lblTituloLivro
            // 
            this.lblTituloLivro.AutoSize = true;
            this.lblTituloLivro.Location = new System.Drawing.Point(11, 120);
            this.lblTituloLivro.Name = "lblTituloLivro";
            this.lblTituloLivro.Size = new System.Drawing.Size(104, 39);
            this.lblTituloLivro.TabIndex = 23;
            this.lblTituloLivro.Text = "Título:";
            // 
            // lblIdLivro
            // 
            this.lblIdLivro.AutoSize = true;
            this.lblIdLivro.Location = new System.Drawing.Point(12, 9);
            this.lblIdLivro.Name = "lblIdLivro";
            this.lblIdLivro.Size = new System.Drawing.Size(167, 39);
            this.lblIdLivro.TabIndex = 22;
            this.lblIdLivro.Text = "Id do Livro:";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(12, 234);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(101, 39);
            this.lblAutor.TabIndex = 21;
            this.lblAutor.Text = "Autor:";
            // 
            // tEditora
            // 
            this.tEditora.Location = new System.Drawing.Point(19, 391);
            this.tEditora.Name = "tEditora";
            this.tEditora.Size = new System.Drawing.Size(201, 46);
            this.tEditora.TabIndex = 31;
            // 
            // bAtualizarEditora
            // 
            this.bAtualizarEditora.AutoSize = true;
            this.bAtualizarEditora.Location = new System.Drawing.Point(238, 388);
            this.bAtualizarEditora.Name = "bAtualizarEditora";
            this.bAtualizarEditora.Size = new System.Drawing.Size(149, 49);
            this.bAtualizarEditora.TabIndex = 30;
            this.bAtualizarEditora.Text = "Atualizar";
            this.bAtualizarEditora.UseVisualStyleBackColor = true;
            this.bAtualizarEditora.Click += new System.EventHandler(this.bAtualizarEditora_Click);
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEditora.Location = new System.Drawing.Point(12, 349);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(118, 39);
            this.lblEditora.TabIndex = 29;
            this.lblEditora.Text = "Editora:";
            // 
            // tQntTotal
            // 
            this.tQntTotal.Location = new System.Drawing.Point(19, 501);
            this.tQntTotal.Name = "tQntTotal";
            this.tQntTotal.Size = new System.Drawing.Size(201, 46);
            this.tQntTotal.TabIndex = 33;
            // 
            // bAtualizarQntTotal
            // 
            this.bAtualizarQntTotal.AutoSize = true;
            this.bAtualizarQntTotal.Location = new System.Drawing.Point(238, 498);
            this.bAtualizarQntTotal.Name = "bAtualizarQntTotal";
            this.bAtualizarQntTotal.Size = new System.Drawing.Size(149, 49);
            this.bAtualizarQntTotal.TabIndex = 34;
            this.bAtualizarQntTotal.Text = "Atualizar";
            this.bAtualizarQntTotal.UseVisualStyleBackColor = true;
            this.bAtualizarQntTotal.Click += new System.EventHandler(this.bAtualizarQntTotal_Click);
            // 
            // lblQntTotal
            // 
            this.lblQntTotal.AutoSize = true;
            this.lblQntTotal.Location = new System.Drawing.Point(12, 459);
            this.lblQntTotal.Name = "lblQntTotal";
            this.lblQntTotal.Size = new System.Drawing.Size(160, 39);
            this.lblQntTotal.TabIndex = 32;
            this.lblQntTotal.Text = "Qnt. Total:";
            // 
            // tQntDisponivel
            // 
            this.tQntDisponivel.Location = new System.Drawing.Point(19, 611);
            this.tQntDisponivel.Name = "tQntDisponivel";
            this.tQntDisponivel.Size = new System.Drawing.Size(201, 46);
            this.tQntDisponivel.TabIndex = 36;
            // 
            // bAtualizarQntDisponivel
            // 
            this.bAtualizarQntDisponivel.AutoSize = true;
            this.bAtualizarQntDisponivel.Location = new System.Drawing.Point(238, 608);
            this.bAtualizarQntDisponivel.Name = "bAtualizarQntDisponivel";
            this.bAtualizarQntDisponivel.Size = new System.Drawing.Size(149, 49);
            this.bAtualizarQntDisponivel.TabIndex = 37;
            this.bAtualizarQntDisponivel.Text = "Atualizar";
            this.bAtualizarQntDisponivel.UseVisualStyleBackColor = true;
            this.bAtualizarQntDisponivel.Click += new System.EventHandler(this.bAtualizarQntDisponivel_Click);
            // 
            // lblQntDisponivel
            // 
            this.lblQntDisponivel.AutoSize = true;
            this.lblQntDisponivel.Location = new System.Drawing.Point(12, 569);
            this.lblQntDisponivel.Name = "lblQntDisponivel";
            this.lblQntDisponivel.Size = new System.Drawing.Size(229, 39);
            this.lblQntDisponivel.TabIndex = 35;
            this.lblQntDisponivel.Text = "Qnt. Disponível:";
            // 
            // AtualizaLivros
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(417, 683);
            this.Controls.Add(this.bAtualizarQntDisponivel);
            this.Controls.Add(this.tQntDisponivel);
            this.Controls.Add(this.lblQntDisponivel);
            this.Controls.Add(this.bAtualizarQntTotal);
            this.Controls.Add(this.tQntTotal);
            this.Controls.Add(this.lblQntTotal);
            this.Controls.Add(this.tEditora);
            this.Controls.Add(this.bAtualizarEditora);
            this.Controls.Add(this.lblEditora);
            this.Controls.Add(this.tAutor);
            this.Controls.Add(this.bLivroDisponivel);
            this.Controls.Add(this.bAtualizarTitulo);
            this.Controls.Add(this.tTituloLivro);
            this.Controls.Add(this.tIdLivro);
            this.Controls.Add(this.lblTituloLivro);
            this.Controls.Add(this.lblIdLivro);
            this.Controls.Add(this.lblAutor);
            this.Font = new System.Drawing.Font("Perpetua", 20.17F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(8)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "AtualizaLivros";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Atualização de cadastro de livros";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AtualizaLivros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tAutor;
        private System.Windows.Forms.Button bLivroDisponivel;
        private System.Windows.Forms.Button bAtualizarTitulo;
        public System.Windows.Forms.TextBox tTituloLivro;
        public System.Windows.Forms.TextBox tIdLivro;
        private System.Windows.Forms.Label lblTituloLivro;
        private System.Windows.Forms.Label lblIdLivro;
        private System.Windows.Forms.Label lblAutor;
        public System.Windows.Forms.TextBox tEditora;
        private System.Windows.Forms.Button bAtualizarEditora;
        private System.Windows.Forms.Label lblEditora;
        private System.Windows.Forms.Label lblQntTotal;
        public System.Windows.Forms.TextBox tQntTotal;
        private System.Windows.Forms.Button bAtualizarQntTotal;
        private System.Windows.Forms.Label lblQntDisponivel;
        public System.Windows.Forms.TextBox tQntDisponivel;
        private System.Windows.Forms.Button bAtualizarQntDisponivel;
    }
}