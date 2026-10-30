using P1___Gerenciamento_de_Biblioteca.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1___Gerenciamento_de_Biblioteca
{
    public partial class FormTelaInicial : Form
    {
        //Construtor
        public FormTelaInicial()
        {
            InitializeComponent();
        }

        // Abre gestão da biblioteca
        private void bVerBiblioteca_Click(object sender, EventArgs e)
        {
            // Abre a tela Biblioteca e esconde o menu
            Biblioteca biblioteca = new Biblioteca();
            biblioteca.Show();
            this.Hide();
        }

        // Abre gestão de usuários
        private void bCadastroUsuario_Click(object sender, EventArgs e)
        {
            // Abre a tela Usuarios e esconde o menu
            Usuarios usuarios = new Usuarios();
            usuarios.Show();
            this.Hide();
        }
    }
}
