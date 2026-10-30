namespace P1___Gerenciamento_de_Biblioteca.Formularios
{
    partial class ConsultaEmprestimos
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
            this.bVoltar = new System.Windows.Forms.Button();
            this.dgvEmprestimos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimos)).BeginInit();
            this.SuspendLayout();
            // 
            // bVoltar
            // 
            this.bVoltar.BackColor = System.Drawing.Color.Navy;
            this.bVoltar.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.bVoltar.FlatAppearance.BorderSize = 3;
            this.bVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.bVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.bVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVoltar.Font = new System.Drawing.Font("Perpetua", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVoltar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bVoltar.Location = new System.Drawing.Point(393, 378);
            this.bVoltar.Margin = new System.Windows.Forms.Padding(4);
            this.bVoltar.Name = "bVoltar";
            this.bVoltar.Size = new System.Drawing.Size(295, 55);
            this.bVoltar.TabIndex = 3;
            this.bVoltar.Text = "Voltar";
            this.bVoltar.UseVisualStyleBackColor = false;
            this.bVoltar.Click += new System.EventHandler(this.bVoltar_Click);
            // 
            // dgvEmprestimos
            // 
            this.dgvEmprestimos.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dgvEmprestimos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmprestimos.Location = new System.Drawing.Point(76, 122);
            this.dgvEmprestimos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEmprestimos.Name = "dgvEmprestimos";
            this.dgvEmprestimos.RowHeadersWidth = 51;
            this.dgvEmprestimos.Size = new System.Drawing.Size(915, 185);
            this.dgvEmprestimos.TabIndex = 2;
            // 
            // ConsultaEmprestimos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.bVoltar);
            this.Controls.Add(this.dgvEmprestimos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ConsultaEmprestimos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emprestimos Ativos";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ConsultaEmprestimos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bVoltar;
        private System.Windows.Forms.DataGridView dgvEmprestimos;
    }
}