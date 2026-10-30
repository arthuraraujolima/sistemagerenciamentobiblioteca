using P1___Gerenciamento_de_Biblioteca.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1___Gerenciamento_de_Biblioteca.Formularios
{
    public partial class AtualizaLivros : Form
    {
        //Construtor
        public AtualizaLivros()
        {
            InitializeComponent();
        }

        private void bAtualizarTitulo_Click(object sender, EventArgs e)
        {
            // Salva o novo título no banco e fecha
            QueryLivros qLivro = new QueryLivros();
            qLivro.AtualizarTitulo(this);
            this.Close();
        }

        private void AtualizaLivros_Load(object sender, EventArgs e)
        {

        }

        private void bAtualizarEditora_Click(object sender, EventArgs e)
        {
            // Salva a nova editora no banco e fecha
            QueryLivros qLivro = new QueryLivros();
            qLivro.AtualizartEditora(this);
            this.Close();
        }

        private void bAtualizarAutor_Click(object sender, EventArgs e)
        {
            // Salva o novo autor no banco e fecha
            QueryLivros qLivro = new QueryLivros();
            qLivro.AtualizarAutor(this);
            this.Close();
        }

        private void bAtualizarQntTotal_Click(object sender, EventArgs e)
        {
            // Salva a nova quantidade total no banco e fecha
            QueryLivros qLivro = new QueryLivros();
            qLivro.AtualizarQntTotal(this);
            this.Close();
        }

        private void bAtualizarQntDisponivel_Click(object sender, EventArgs e)
        {
            // Salva a nova quantidade disponível no banco e fecha
            QueryLivros qLivro = new QueryLivros();
            qLivro.AtualizarQntDisponivel(this);
            this.Close();
        }
    }
}
