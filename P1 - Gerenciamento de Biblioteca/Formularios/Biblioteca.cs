using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P1___Gerenciamento_de_Biblioteca.Classes;

namespace P1___Gerenciamento_de_Biblioteca.Formularios
{
    public partial class Biblioteca : Form
    {
        // Instancia a classe de conexão com o banco de dados para ser usada nesta tela
        private Conexao db = new Conexao();
        
        // Construtor: método chamado quando a tela é criada
        public Biblioteca()
        {
            InitializeComponent();
        }

        // Evento do botão Consultar Livro: Abre a tela de pesquisa de livros
        private void bConsultarLivro_Click(object sender, EventArgs e)
        {
            // Cria a tela de consulta passando 'this' (esta tela principal) como referência
            ConsultaLivros consultar = new ConsultaLivros(this);
            consultar.ShowDialog();

        }
      
        // Evento do botão Voltar: Fecha a tela atual e volta para o Menu Principal
        private void bVoltarTelaInicial_Click(object sender, EventArgs e)
        {
            FormTelaInicial telaInicial = new FormTelaInicial();
            telaInicial.Show();
            this.Close();
        }

        // Evento do botão Atualizar: Abre a tela para alterar dados de um livro existente
        private void bAtualizarLivro_Click(object sender, EventArgs e) { 
            AtualizaLivros upLivros = new AtualizaLivros();
            upLivros.ShowDialog();
        }
        
        // Evento do botão Cadastrar: Abre a tela para adicionar novos livros
        private void bCadastrarLivro_Click(object sender, EventArgs e) {
            CadastroLivros cadLivro = new CadastroLivros(this);
            cadLivro.ShowDialog();
        }

        // Evento Load: Carrega e lista todos os livros no GridView assim que a tela abre
        private void Biblioteca_Load(object sender, EventArgs e)
        {
            // Instancia a classe de regras de negócio de Livros
            QueryLivros qLivros = new QueryLivros();
            // Executa a função que faz o SELECT no banco e mostra na tela
            qLivros.MostraTodosLivros(this);
        }

        private void bAbreEmpréstimo_Click(object sender, EventArgs e)
        {
            Emprestimo emprestimo = new Emprestimo();
            emprestimo.ShowDialog();
        }
    }
}