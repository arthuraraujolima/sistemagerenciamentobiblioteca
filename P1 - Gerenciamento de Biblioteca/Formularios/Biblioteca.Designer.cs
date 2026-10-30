namespace P1___Gerenciamento_de_Biblioteca.Formularios
{
    partial class Biblioteca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Biblioteca));
            this.lblTituloBiblioteca = new System.Windows.Forms.Label();
            this.lblTituloMattos = new System.Windows.Forms.Label();
            this.gvLivros = new System.Windows.Forms.DataGridView();
            this.lblAcervoLivros = new System.Windows.Forms.Label();
            this.bVoltarTelaInicial = new System.Windows.Forms.Button();
            this.bCadastrarLivro = new System.Windows.Forms.Button();
            this.bConsultarLivro = new System.Windows.Forms.Button();
            this.bAbreEmpréstimo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bAtualizarLivro = new System.Windows.Forms.Button();
            this.pbSimbolo = new System.Windows.Forms.PictureBox();
            this.pbBookshelf = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvLivros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSimbolo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookshelf)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloBiblioteca
            // 
            this.lblTituloBiblioteca.AutoSize = true;
            this.lblTituloBiblioteca.Enabled = false;
            this.lblTituloBiblioteca.Font = new System.Drawing.Font("Perpetua", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloBiblioteca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(8)))), ((int)(((byte)(56)))));
            this.lblTituloBiblioteca.Location = new System.Drawing.Point(97, 18);
            this.lblTituloBiblioteca.Margin = new System.Windows.Forms.Padding(0);
            this.lblTituloBiblioteca.Name = "lblTituloBiblioteca";
            this.lblTituloBiblioteca.Size = new System.Drawing.Size(186, 42);
            this.lblTituloBiblioteca.TabIndex = 4;
            this.lblTituloBiblioteca.Text = "Biblioteca ";
            this.lblTituloBiblioteca.UseWaitCursor = true;
            // 
            // lblTituloMattos
            // 
            this.lblTituloMattos.AutoSize = true;
            this.lblTituloMattos.Font = new System.Drawing.Font("Perpetua", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMattos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(8)))), ((int)(((byte)(56)))));
            this.lblTituloMattos.Location = new System.Drawing.Point(96, 48);
            this.lblTituloMattos.Margin = new System.Windows.Forms.Padding(0);
            this.lblTituloMattos.Name = "lblTituloMattos";
            this.lblTituloMattos.Size = new System.Drawing.Size(132, 50);
            this.lblTituloMattos.TabIndex = 5;
            this.lblTituloMattos.Text = "Mattos";
            // 
            // gvLivros
            // 
            this.gvLivros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvLivros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvLivros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLivros.Location = new System.Drawing.Point(16, 182);
            this.gvLivros.Name = "gvLivros";
            this.gvLivros.ReadOnly = true;
            this.gvLivros.RowHeadersWidth = 51;
            this.gvLivros.RowTemplate.Height = 24;
            this.gvLivros.Size = new System.Drawing.Size(907, 378);
            this.gvLivros.TabIndex = 7;
            // 
            // lblAcervoLivros
            // 
            this.lblAcervoLivros.AutoSize = true;
            this.lblAcervoLivros.Font = new System.Drawing.Font("Perpetua", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcervoLivros.Location = new System.Drawing.Point(12, 140);
            this.lblAcervoLivros.Name = "lblAcervoLivros";
            this.lblAcervoLivros.Size = new System.Drawing.Size(252, 38);
            this.lblAcervoLivros.TabIndex = 8;
            this.lblAcervoLivros.Text = "Acervo de Livros";
            // 
            // bVoltarTelaInicial
            // 
            this.bVoltarTelaInicial.AutoSize = true;
            this.bVoltarTelaInicial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(174)))), ((int)(((byte)(115)))));
            this.bVoltarTelaInicial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(152)))), ((int)(((byte)(101)))));
            this.bVoltarTelaInicial.FlatAppearance.BorderSize = 3;
            this.bVoltarTelaInicial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(152)))), ((int)(((byte)(101)))));
            this.bVoltarTelaInicial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(152)))), ((int)(((byte)(101)))));
            this.bVoltarTelaInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVoltarTelaInicial.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold);
            this.bVoltarTelaInicial.Location = new System.Drawing.Point(1127, 17);
            this.bVoltarTelaInicial.Name = "bVoltarTelaInicial";
            this.bVoltarTelaInicial.Size = new System.Drawing.Size(162, 52);
            this.bVoltarTelaInicial.TabIndex = 10;
            this.bVoltarTelaInicial.Text = "Tela Inicial";
            this.bVoltarTelaInicial.UseVisualStyleBackColor = false;
            this.bVoltarTelaInicial.Click += new System.EventHandler(this.bVoltarTelaInicial_Click);
            // 
            // bCadastrarLivro
            // 
            this.bCadastrarLivro.AutoSize = true;
            this.bCadastrarLivro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(128)))));
            this.bCadastrarLivro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(74)))));
            this.bCadastrarLivro.FlatAppearance.BorderSize = 3;
            this.bCadastrarLivro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(74)))));
            this.bCadastrarLivro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(74)))));
            this.bCadastrarLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCadastrarLivro.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold);
            this.bCadastrarLivro.ForeColor = System.Drawing.Color.White;
            this.bCadastrarLivro.Location = new System.Drawing.Point(485, 581);
            this.bCadastrarLivro.Name = "bCadastrarLivro";
            this.bCadastrarLivro.Size = new System.Drawing.Size(205, 57);
            this.bCadastrarLivro.TabIndex = 12;
            this.bCadastrarLivro.Text = "Cadastrar";
            this.bCadastrarLivro.UseVisualStyleBackColor = false;
            this.bCadastrarLivro.Click += new System.EventHandler(this.bCadastrarLivro_Click);
            // 
            // bConsultarLivro
            // 
            this.bConsultarLivro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(128)))));
            this.bConsultarLivro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(74)))));
            this.bConsultarLivro.FlatAppearance.BorderSize = 3;
            this.bConsultarLivro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(74)))));
            this.bConsultarLivro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(74)))));
            this.bConsultarLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bConsultarLivro.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold);
            this.bConsultarLivro.ForeColor = System.Drawing.Color.White;
            this.bConsultarLivro.Location = new System.Drawing.Point(16, 581);
            this.bConsultarLivro.Name = "bConsultarLivro";
            this.bConsultarLivro.Size = new System.Drawing.Size(205, 57);
            this.bConsultarLivro.TabIndex = 13;
            this.bConsultarLivro.Text = "Consultar";
            this.bConsultarLivro.UseVisualStyleBackColor = false;
            this.bConsultarLivro.Click += new System.EventHandler(this.bConsultarLivro_Click);
            // 
            // bAbreEmpréstimo
            // 
            this.bAbreEmpréstimo.AutoSize = true;
            this.bAbreEmpréstimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(128)))));
            this.bAbreEmpréstimo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(74)))));
            this.bAbreEmpréstimo.FlatAppearance.BorderSize = 3;
            this.bAbreEmpréstimo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(74)))));
            this.bAbreEmpréstimo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(74)))));
            this.bAbreEmpréstimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAbreEmpréstimo.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold);
            this.bAbreEmpréstimo.ForeColor = System.Drawing.Color.White;
            this.bAbreEmpréstimo.Location = new System.Drawing.Point(718, 581);
            this.bAbreEmpréstimo.Name = "bAbreEmpréstimo";
            this.bAbreEmpréstimo.Size = new System.Drawing.Size(205, 57);
            this.bAbreEmpréstimo.TabIndex = 14;
            this.bAbreEmpréstimo.Text = "Empréstimo";
            this.bAbreEmpréstimo.UseVisualStyleBackColor = false;
            this.bAbreEmpréstimo.Click += new System.EventHandler(this.bAbreEmpréstimo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(923, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 39);
            this.label3.TabIndex = 16;
            // 
            // bAtualizarLivro
            // 
            this.bAtualizarLivro.AutoSize = true;
            this.bAtualizarLivro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(128)))));
            this.bAtualizarLivro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(74)))));
            this.bAtualizarLivro.FlatAppearance.BorderSize = 3;
            this.bAtualizarLivro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(74)))));
            this.bAtualizarLivro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(74)))));
            this.bAtualizarLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAtualizarLivro.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold);
            this.bAtualizarLivro.ForeColor = System.Drawing.Color.White;
            this.bAtualizarLivro.Location = new System.Drawing.Point(253, 581);
            this.bAtualizarLivro.Name = "bAtualizarLivro";
            this.bAtualizarLivro.Size = new System.Drawing.Size(205, 57);
            this.bAtualizarLivro.TabIndex = 19;
            this.bAtualizarLivro.Text = "Atualizar";
            this.bAtualizarLivro.UseVisualStyleBackColor = false;
            this.bAtualizarLivro.Click += new System.EventHandler(this.bAtualizarLivro_Click);
            // 
            // pbSimbolo
            // 
            this.pbSimbolo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbSimbolo.BackgroundImage")));
            this.pbSimbolo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSimbolo.Enabled = false;
            this.pbSimbolo.Location = new System.Drawing.Point(16, 18);
            this.pbSimbolo.Margin = new System.Windows.Forms.Padding(4);
            this.pbSimbolo.Name = "pbSimbolo";
            this.pbSimbolo.Size = new System.Drawing.Size(72, 65);
            this.pbSimbolo.TabIndex = 6;
            this.pbSimbolo.TabStop = false;
            // 
            // pbBookshelf
            // 
            this.pbBookshelf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbBookshelf.BackgroundImage")));
            this.pbBookshelf.Location = new System.Drawing.Point(966, 76);
            this.pbBookshelf.Name = "pbBookshelf";
            this.pbBookshelf.Size = new System.Drawing.Size(511, 721);
            this.pbBookshelf.TabIndex = 20;
            this.pbBookshelf.TabStop = false;
            // 
            // Biblioteca
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1301, 734);
            this.Controls.Add(this.gvLivros);
            this.Controls.Add(this.bAtualizarLivro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bAbreEmpréstimo);
            this.Controls.Add(this.bConsultarLivro);
            this.Controls.Add(this.bCadastrarLivro);
            this.Controls.Add(this.bVoltarTelaInicial);
            this.Controls.Add(this.lblAcervoLivros);
            this.Controls.Add(this.pbSimbolo);
            this.Controls.Add(this.lblTituloBiblioteca);
            this.Controls.Add(this.lblTituloMattos);
            this.Controls.Add(this.pbBookshelf);
            this.Font = new System.Drawing.Font("Perpetua", 20.17F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(8)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Biblioteca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Biblioteca";
            this.Load += new System.EventHandler(this.Biblioteca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvLivros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSimbolo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookshelf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSimbolo;
        private System.Windows.Forms.Label lblTituloBiblioteca;
        private System.Windows.Forms.Label lblTituloMattos;
        private System.Windows.Forms.Label lblAcervoLivros;
        private System.Windows.Forms.Button bVoltarTelaInicial;
        private System.Windows.Forms.Button bCadastrarLivro;
        private System.Windows.Forms.Button bConsultarLivro;
        private System.Windows.Forms.Button bAbreEmpréstimo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bAtualizarLivro;
        private System.Windows.Forms.PictureBox pbBookshelf;
        public System.Windows.Forms.DataGridView gvLivros;
    }
}