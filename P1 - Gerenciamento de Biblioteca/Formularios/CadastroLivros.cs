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
    public partial class CadastroLivros : Form
    {
        // Referência da tela da Biblioteca
        private Biblioteca bibli;

        // Construtor padrão
        public CadastroLivros() { }

        // Construtor com parâmetro
        public CadastroLivros(Biblioteca bibli)
        {
            InitializeComponent();

            // Salva a referência da tela principal pra usar depois
            this.bibli = bibli;
        }

        // Esse evento dispara quando o formulário carrega
        private void CadastroLivros_Load(object sender, EventArgs e)
        {
            // Nada pra fazer quando a tela abrir, por enquanto
        }

        // Salva o cadastro
        private void bCadastrar_Click(object sender, EventArgs e)
        {
            QueryLivros qLivro = new QueryLivros();
            qLivro.CadastrarLivro(bibli, this);
            this.Close();
        }
    }
}
