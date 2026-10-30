namespace P1___Gerenciamento_de_Biblioteca.Formularios
{
    partial class Emprestimo
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
            this.bConsultarEmprestimos = new System.Windows.Forms.Button();
            this.bVoltar = new System.Windows.Forms.Button();
            this.bRegistrarDevolucao = new System.Windows.Forms.Button();
            this.bRegistrarEmprestimo = new System.Windows.Forms.Button();
            this.tIdEmprestimo = new System.Windows.Forms.TextBox();
            this.tDataDevolucao = new System.Windows.Forms.TextBox();
            this.tDataEmprestimo = new System.Windows.Forms.TextBox();
            this.tIdLivro = new System.Windows.Forms.TextBox();
            this.tIdUsuario = new System.Windows.Forms.TextBox();
            this.lblIdEmprestimo = new System.Windows.Forms.Label();
            this.lblDataDevolucao = new System.Windows.Forms.Label();
            this.lblDataEmprestimo = new System.Windows.Forms.Label();
            this.lblIdLivro = new System.Windows.Forms.Label();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.lblTituloEmprestimo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bConsultarEmprestimos
            // 
            this.bConsultarEmprestimos.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bConsultarEmprestimos.Location = new System.Drawing.Point(35, 389);
            this.bConsultarEmprestimos.Name = "bConsultarEmprestimos";
            this.bConsultarEmprestimos.Size = new System.Drawing.Size(311, 44);
            this.bConsultarEmprestimos.TabIndex = 29;
            this.bConsultarEmprestimos.Text = "Consultar Empréstimos";
            this.bConsultarEmprestimos.UseVisualStyleBackColor = true;
            this.bConsultarEmprestimos.Click += new System.EventHandler(this.bConsultarEmprestimos_Click_1);
            // 
            // bVoltar
            // 
            this.bVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(174)))), ((int)(((byte)(115)))));
            this.bVoltar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(152)))), ((int)(((byte)(101)))));
            this.bVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVoltar.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold);
            this.bVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(8)))), ((int)(((byte)(56)))));
            this.bVoltar.Location = new System.Drawing.Point(35, 33);
            this.bVoltar.Name = "bVoltar";
            this.bVoltar.Size = new System.Drawing.Size(116, 57);
            this.bVoltar.TabIndex = 28;
            this.bVoltar.Text = "Voltar";
            this.bVoltar.UseVisualStyleBackColor = false;
            this.bVoltar.Click += new System.EventHandler(this.bVoltar_Click);
            // 
            // bRegistrarDevolucao
            // 
            this.bRegistrarDevolucao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(128)))));
            this.bRegistrarDevolucao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(74)))));
            this.bRegistrarDevolucao.FlatAppearance.BorderSize = 3;
            this.bRegistrarDevolucao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(74)))));
            this.bRegistrarDevolucao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(74)))));
            this.bRegistrarDevolucao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRegistrarDevolucao.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold);
            this.bRegistrarDevolucao.ForeColor = System.Drawing.Color.White;
            this.bRegistrarDevolucao.Location = new System.Drawing.Point(650, 376);
            this.bRegistrarDevolucao.Name = "bRegistrarDevolucao";
            this.bRegistrarDevolucao.Size = new System.Drawing.Size(200, 57);
            this.bRegistrarDevolucao.TabIndex = 27;
            this.bRegistrarDevolucao.Text = "Registrar Devolução";
            this.bRegistrarDevolucao.UseVisualStyleBackColor = false;
            this.bRegistrarDevolucao.Click += new System.EventHandler(this.bRegistrarDevolucao_Click);
            // 
            // bRegistrarEmprestimo
            // 
            this.bRegistrarEmprestimo.AutoSize = true;
            this.bRegistrarEmprestimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(128)))));
            this.bRegistrarEmprestimo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(74)))));
            this.bRegistrarEmprestimo.FlatAppearance.BorderSize = 3;
            this.bRegistrarEmprestimo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(74)))));
            this.bRegistrarEmprestimo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(74)))));
            this.bRegistrarEmprestimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRegistrarEmprestimo.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold);
            this.bRegistrarEmprestimo.ForeColor = System.Drawing.Color.White;
            this.bRegistrarEmprestimo.Location = new System.Drawing.Point(383, 376);
            this.bRegistrarEmprestimo.Name = "bRegistrarEmprestimo";
            this.bRegistrarEmprestimo.Size = new System.Drawing.Size(209, 57);
            this.bRegistrarEmprestimo.TabIndex = 26;
            this.bRegistrarEmprestimo.Text = "Registrar Empréstimo";
            this.bRegistrarEmprestimo.UseVisualStyleBackColor = false;
            this.bRegistrarEmprestimo.Click += new System.EventHandler(this.bRegistrarEmprestimo_Click);
            // 
            // tIdEmprestimo
            // 
            this.tIdEmprestimo.Font = new System.Drawing.Font("Perpetua", 14F);
            this.tIdEmprestimo.Location = new System.Drawing.Point(383, 311);
            this.tIdEmprestimo.Name = "tIdEmprestimo";
            this.tIdEmprestimo.Size = new System.Drawing.Size(467, 34);
            this.tIdEmprestimo.TabIndex = 25;
            // 
            // tDataDevolucao
            // 
            this.tDataDevolucao.Font = new System.Drawing.Font("Perpetua", 14F);
            this.tDataDevolucao.Location = new System.Drawing.Point(383, 264);
            this.tDataDevolucao.Name = "tDataDevolucao";
            this.tDataDevolucao.Size = new System.Drawing.Size(467, 34);
            this.tDataDevolucao.TabIndex = 24;
            // 
            // tDataEmprestimo
            // 
            this.tDataEmprestimo.Font = new System.Drawing.Font("Perpetua", 14F);
            this.tDataEmprestimo.Location = new System.Drawing.Point(383, 217);
            this.tDataEmprestimo.Name = "tDataEmprestimo";
            this.tDataEmprestimo.Size = new System.Drawing.Size(467, 34);
            this.tDataEmprestimo.TabIndex = 23;
            // 
            // tIdLivro
            // 
            this.tIdLivro.Font = new System.Drawing.Font("Perpetua", 14F);
            this.tIdLivro.Location = new System.Drawing.Point(383, 170);
            this.tIdLivro.Name = "tIdLivro";
            this.tIdLivro.Size = new System.Drawing.Size(467, 34);
            this.tIdLivro.TabIndex = 22;
            // 
            // tIdUsuario
            // 
            this.tIdUsuario.Font = new System.Drawing.Font("Perpetua", 14F);
            this.tIdUsuario.Location = new System.Drawing.Point(383, 123);
            this.tIdUsuario.Name = "tIdUsuario";
            this.tIdUsuario.Size = new System.Drawing.Size(467, 34);
            this.tIdUsuario.TabIndex = 21;
            // 
            // lblIdEmprestimo
            // 
            this.lblIdEmprestimo.AutoSize = true;
            this.lblIdEmprestimo.Font = new System.Drawing.Font("Perpetua", 14F, System.Drawing.FontStyle.Bold);
            this.lblIdEmprestimo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(8)))), ((int)(((byte)(56)))));
            this.lblIdEmprestimo.Location = new System.Drawing.Point(70, 319);
            this.lblIdEmprestimo.Name = "lblIdEmprestimo";
            this.lblIdEmprestimo.Size = new System.Drawing.Size(203, 28);
            this.lblIdEmprestimo.TabIndex = 20;
            this.lblIdEmprestimo.Text = "ID do Empréstimo:";
            // 
            // lblDataDevolucao
            // 
            this.lblDataDevolucao.AutoSize = true;
            this.lblDataDevolucao.Font = new System.Drawing.Font("Perpetua", 14F, System.Drawing.FontStyle.Bold);
            this.lblDataDevolucao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(8)))), ((int)(((byte)(56)))));
            this.lblDataDevolucao.Location = new System.Drawing.Point(70, 272);
            this.lblDataDevolucao.Name = "lblDataDevolucao";
            this.lblDataDevolucao.Size = new System.Drawing.Size(209, 28);
            this.lblDataDevolucao.TabIndex = 19;
            this.lblDataDevolucao.Text = "Data de Devolução:";
            // 
            // lblDataEmprestimo
            // 
            this.lblDataEmprestimo.AutoSize = true;
            this.lblDataEmprestimo.Font = new System.Drawing.Font("Perpetua", 14F, System.Drawing.FontStyle.Bold);
            this.lblDataEmprestimo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(8)))), ((int)(((byte)(56)))));
            this.lblDataEmprestimo.Location = new System.Drawing.Point(70, 225);
            this.lblDataEmprestimo.Name = "lblDataEmprestimo";
            this.lblDataEmprestimo.Size = new System.Drawing.Size(224, 28);
            this.lblDataEmprestimo.TabIndex = 18;
            this.lblDataEmprestimo.Text = "Data do Empréstimo:";
            // 
            // lblIdLivro
            // 
            this.lblIdLivro.AutoSize = true;
            this.lblIdLivro.Font = new System.Drawing.Font("Perpetua", 14F, System.Drawing.FontStyle.Bold);
            this.lblIdLivro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(8)))), ((int)(((byte)(56)))));
            this.lblIdLivro.Location = new System.Drawing.Point(70, 178);
            this.lblIdLivro.Name = "lblIdLivro";
            this.lblIdLivro.Size = new System.Drawing.Size(135, 28);
            this.lblIdLivro.TabIndex = 17;
            this.lblIdLivro.Text = "ID do Livro:";
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Font = new System.Drawing.Font("Perpetua", 14F, System.Drawing.FontStyle.Bold);
            this.lblIdUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(8)))), ((int)(((byte)(56)))));
            this.lblIdUsuario.Location = new System.Drawing.Point(70, 131);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(162, 28);
            this.lblIdUsuario.TabIndex = 16;
            this.lblIdUsuario.Text = "ID do Usuário:";
            // 
            // lblTituloEmprestimo
            // 
            this.lblTituloEmprestimo.AutoSize = true;
            this.lblTituloEmprestimo.Font = new System.Drawing.Font("Perpetua", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblTituloEmprestimo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(8)))), ((int)(((byte)(56)))));
            this.lblTituloEmprestimo.Location = new System.Drawing.Point(294, 56);
            this.lblTituloEmprestimo.Name = "lblTituloEmprestimo";
            this.lblTituloEmprestimo.Size = new System.Drawing.Size(382, 42);
            this.lblTituloEmprestimo.TabIndex = 15;
            this.lblTituloEmprestimo.Text = "Gestão de Empréstimos";
            // 
            // Emprestimo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 466);
            this.Controls.Add(this.bConsultarEmprestimos);
            this.Controls.Add(this.bVoltar);
            this.Controls.Add(this.bRegistrarDevolucao);
            this.Controls.Add(this.bRegistrarEmprestimo);
            this.Controls.Add(this.tIdEmprestimo);
            this.Controls.Add(this.tDataDevolucao);
            this.Controls.Add(this.tDataEmprestimo);
            this.Controls.Add(this.tIdLivro);
            this.Controls.Add(this.tIdUsuario);
            this.Controls.Add(this.lblIdEmprestimo);
            this.Controls.Add(this.lblDataDevolucao);
            this.Controls.Add(this.lblDataEmprestimo);
            this.Controls.Add(this.lblIdLivro);
            this.Controls.Add(this.lblIdUsuario);
            this.Controls.Add(this.lblTituloEmprestimo);
            this.Font = new System.Drawing.Font("Perpetua", 21.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(8)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Emprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Empréstimos";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bConsultarEmprestimos;
        private System.Windows.Forms.Button bVoltar;
        private System.Windows.Forms.Button bRegistrarDevolucao;
        private System.Windows.Forms.Button bRegistrarEmprestimo;
        private System.Windows.Forms.TextBox tIdEmprestimo;
        private System.Windows.Forms.TextBox tDataDevolucao;
        private System.Windows.Forms.TextBox tDataEmprestimo;
        private System.Windows.Forms.TextBox tIdLivro;
        private System.Windows.Forms.TextBox tIdUsuario;
        private System.Windows.Forms.Label lblIdEmprestimo;
        private System.Windows.Forms.Label lblDataDevolucao;
        private System.Windows.Forms.Label lblDataEmprestimo;
        private System.Windows.Forms.Label lblIdLivro;
        private System.Windows.Forms.Label lblIdUsuario;
        private System.Windows.Forms.Label lblTituloEmprestimo;
    }
}