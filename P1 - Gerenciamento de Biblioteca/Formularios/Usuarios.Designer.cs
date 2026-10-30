namespace P1___Gerenciamento_de_Biblioteca.Formularios
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.gvUsuarios = new System.Windows.Forms.DataGridView();
            this.bAtualizarUsuarios = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bConsultarUsuarios = new System.Windows.Forms.Button();
            this.bCadastrarUsuarios = new System.Windows.Forms.Button();
            this.bVoltarTelaInicial = new System.Windows.Forms.Button();
            this.lblGestaoUsuarios = new System.Windows.Forms.Label();
            this.pbSimbolo = new System.Windows.Forms.PictureBox();
            this.lblTituloBiblioteca = new System.Windows.Forms.Label();
            this.lblTituloMattos = new System.Windows.Forms.Label();
            this.pbBookshelf = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSimbolo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookshelf)).BeginInit();
            this.SuspendLayout();
            // 
            // gvUsuarios
            // 
            this.gvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUsuarios.Location = new System.Drawing.Point(10, 173);
            this.gvUsuarios.Name = "gvUsuarios";
            this.gvUsuarios.ReadOnly = true;
            this.gvUsuarios.RowHeadersWidth = 51;
            this.gvUsuarios.RowTemplate.Height = 24;
            this.gvUsuarios.Size = new System.Drawing.Size(907, 378);
            this.gvUsuarios.TabIndex = 24;
            // 
            // bAtualizarUsuarios
            // 
            this.bAtualizarUsuarios.AutoSize = true;
            this.bAtualizarUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(128)))));
            this.bAtualizarUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(74)))));
            this.bAtualizarUsuarios.FlatAppearance.BorderSize = 3;
            this.bAtualizarUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(74)))));
            this.bAtualizarUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(74)))));
            this.bAtualizarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAtualizarUsuarios.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold);
            this.bAtualizarUsuarios.ForeColor = System.Drawing.Color.White;
            this.bAtualizarUsuarios.Location = new System.Drawing.Point(247, 572);
            this.bAtualizarUsuarios.Name = "bAtualizarUsuarios";
            this.bAtualizarUsuarios.Size = new System.Drawing.Size(205, 57);
            this.bAtualizarUsuarios.TabIndex = 31;
            this.bAtualizarUsuarios.Text = "Atualizar";
            this.bAtualizarUsuarios.UseVisualStyleBackColor = false;
            this.bAtualizarUsuarios.Click += new System.EventHandler(this.bAtualizarUsuarios_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(917, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 39);
            this.label3.TabIndex = 30;
            // 
            // bConsultarUsuarios
            // 
            this.bConsultarUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(128)))));
            this.bConsultarUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(74)))));
            this.bConsultarUsuarios.FlatAppearance.BorderSize = 3;
            this.bConsultarUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(74)))));
            this.bConsultarUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(74)))));
            this.bConsultarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bConsultarUsuarios.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold);
            this.bConsultarUsuarios.ForeColor = System.Drawing.Color.White;
            this.bConsultarUsuarios.Location = new System.Drawing.Point(10, 572);
            this.bConsultarUsuarios.Name = "bConsultarUsuarios";
            this.bConsultarUsuarios.Size = new System.Drawing.Size(205, 57);
            this.bConsultarUsuarios.TabIndex = 28;
            this.bConsultarUsuarios.Text = "Consultar";
            this.bConsultarUsuarios.UseVisualStyleBackColor = false;
            this.bConsultarUsuarios.Click += new System.EventHandler(this.bConsultarUsuarios_Click);
            // 
            // bCadastrarUsuarios
            // 
            this.bCadastrarUsuarios.AutoSize = true;
            this.bCadastrarUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(128)))));
            this.bCadastrarUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(74)))));
            this.bCadastrarUsuarios.FlatAppearance.BorderSize = 3;
            this.bCadastrarUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(74)))));
            this.bCadastrarUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(74)))));
            this.bCadastrarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCadastrarUsuarios.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold);
            this.bCadastrarUsuarios.ForeColor = System.Drawing.Color.White;
            this.bCadastrarUsuarios.Location = new System.Drawing.Point(479, 572);
            this.bCadastrarUsuarios.Name = "bCadastrarUsuarios";
            this.bCadastrarUsuarios.Size = new System.Drawing.Size(205, 57);
            this.bCadastrarUsuarios.TabIndex = 27;
            this.bCadastrarUsuarios.Text = "Cadastrar";
            this.bCadastrarUsuarios.UseVisualStyleBackColor = false;
            this.bCadastrarUsuarios.Click += new System.EventHandler(this.bCadastrarUsuarios_Click);
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
            this.bVoltarTelaInicial.Location = new System.Drawing.Point(1121, 8);
            this.bVoltarTelaInicial.Name = "bVoltarTelaInicial";
            this.bVoltarTelaInicial.Size = new System.Drawing.Size(162, 52);
            this.bVoltarTelaInicial.TabIndex = 26;
            this.bVoltarTelaInicial.Text = "Tela Inicial";
            this.bVoltarTelaInicial.UseVisualStyleBackColor = false;
            this.bVoltarTelaInicial.Click += new System.EventHandler(this.bVoltarTelaInicial_Click);
            // 
            // lblGestaoUsuarios
            // 
            this.lblGestaoUsuarios.AutoSize = true;
            this.lblGestaoUsuarios.Font = new System.Drawing.Font("Perpetua", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestaoUsuarios.Location = new System.Drawing.Point(6, 131);
            this.lblGestaoUsuarios.Name = "lblGestaoUsuarios";
            this.lblGestaoUsuarios.Size = new System.Drawing.Size(281, 38);
            this.lblGestaoUsuarios.TabIndex = 25;
            this.lblGestaoUsuarios.Text = "Gestão de Usuários";
            // 
            // pbSimbolo
            // 
            this.pbSimbolo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbSimbolo.BackgroundImage")));
            this.pbSimbolo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSimbolo.Enabled = false;
            this.pbSimbolo.Location = new System.Drawing.Point(10, 9);
            this.pbSimbolo.Margin = new System.Windows.Forms.Padding(4);
            this.pbSimbolo.Name = "pbSimbolo";
            this.pbSimbolo.Size = new System.Drawing.Size(72, 65);
            this.pbSimbolo.TabIndex = 23;
            this.pbSimbolo.TabStop = false;
            // 
            // lblTituloBiblioteca
            // 
            this.lblTituloBiblioteca.AutoSize = true;
            this.lblTituloBiblioteca.Enabled = false;
            this.lblTituloBiblioteca.Font = new System.Drawing.Font("Perpetua", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloBiblioteca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(8)))), ((int)(((byte)(56)))));
            this.lblTituloBiblioteca.Location = new System.Drawing.Point(91, 9);
            this.lblTituloBiblioteca.Margin = new System.Windows.Forms.Padding(0);
            this.lblTituloBiblioteca.Name = "lblTituloBiblioteca";
            this.lblTituloBiblioteca.Size = new System.Drawing.Size(186, 42);
            this.lblTituloBiblioteca.TabIndex = 21;
            this.lblTituloBiblioteca.Text = "Biblioteca ";
            this.lblTituloBiblioteca.UseWaitCursor = true;
            // 
            // lblTituloMattos
            // 
            this.lblTituloMattos.AutoSize = true;
            this.lblTituloMattos.Font = new System.Drawing.Font("Perpetua", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMattos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(8)))), ((int)(((byte)(56)))));
            this.lblTituloMattos.Location = new System.Drawing.Point(90, 39);
            this.lblTituloMattos.Margin = new System.Windows.Forms.Padding(0);
            this.lblTituloMattos.Name = "lblTituloMattos";
            this.lblTituloMattos.Size = new System.Drawing.Size(132, 50);
            this.lblTituloMattos.TabIndex = 22;
            this.lblTituloMattos.Text = "Mattos";
            // 
            // pbBookshelf
            // 
            this.pbBookshelf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbBookshelf.BackgroundImage")));
            this.pbBookshelf.Location = new System.Drawing.Point(960, 67);
            this.pbBookshelf.Name = "pbBookshelf";
            this.pbBookshelf.Size = new System.Drawing.Size(511, 721);
            this.pbBookshelf.TabIndex = 32;
            this.pbBookshelf.TabStop = false;
            // 
            // Usuarios
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1301, 734);
            this.Controls.Add(this.gvUsuarios);
            this.Controls.Add(this.bAtualizarUsuarios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bConsultarUsuarios);
            this.Controls.Add(this.bCadastrarUsuarios);
            this.Controls.Add(this.bVoltarTelaInicial);
            this.Controls.Add(this.lblGestaoUsuarios);
            this.Controls.Add(this.pbSimbolo);
            this.Controls.Add(this.lblTituloBiblioteca);
            this.Controls.Add(this.lblTituloMattos);
            this.Controls.Add(this.pbBookshelf);
            this.Font = new System.Drawing.Font("Perpetua", 20.17F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(8)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Usuários";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSimbolo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookshelf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView gvUsuarios;
        private System.Windows.Forms.Button bAtualizarUsuarios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bConsultarUsuarios;
        private System.Windows.Forms.Button bCadastrarUsuarios;
        private System.Windows.Forms.Button bVoltarTelaInicial;
        private System.Windows.Forms.Label lblGestaoUsuarios;
        private System.Windows.Forms.PictureBox pbSimbolo;
        private System.Windows.Forms.Label lblTituloBiblioteca;
        private System.Windows.Forms.Label lblTituloMattos;
        private System.Windows.Forms.PictureBox pbBookshelf;
    }
}