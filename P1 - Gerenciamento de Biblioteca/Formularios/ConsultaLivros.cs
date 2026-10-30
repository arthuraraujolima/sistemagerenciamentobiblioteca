using MySql.Data.MySqlClient;
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
    public partial class ConsultaLivros : Form
    {
        // Referência da tela da Biblioteca
        private Biblioteca bibli;

        //Construtor
        public ConsultaLivros() { }

        //Sobrecarga com parâmetro
        public ConsultaLivros(Biblioteca bibli)
        {
            InitializeComponent();

            // Salva a referência pra atualizar o grid depois da consulta
            this.bibli = bibli;
        }

        // Consulta todos os livros
        private void bConsultarTodosLivros_Click(object sender, EventArgs e)
        {
            QueryLivros qLivro = new QueryLivros();
            qLivro.MostraTodosLivros(bibli);
            this.Close();
        }

        //Consulta todos os livros disponiveis 
        private void bConsultarLivrosDisponiveis_Click(object sender, EventArgs e)
        {
            QueryLivros qLivro = new QueryLivros();
            qLivro.MostraDisponiveis(bibli);
            this.Close();
        }

        //Consulta pelo título do livro
        private void bConsultarTitulo_Click(object sender, EventArgs e)
        {
            QueryLivros qLivro = new QueryLivros();
            qLivro.ConsultaTitulo(bibli, this);
            this.Close();
        }

        //Consulta os livros pelo autor
        private void bConsultarAutor_Click(object sender, EventArgs e)
        {
            QueryLivros qLivro = new QueryLivros();
            qLivro.ConsultaAutor(bibli, this);
            this.Close();
        }

        private void ConsultaLivros_Load(object sender, EventArgs e)
        {
            // Nada pra fazer quando a tela abrir
        }
    }
}