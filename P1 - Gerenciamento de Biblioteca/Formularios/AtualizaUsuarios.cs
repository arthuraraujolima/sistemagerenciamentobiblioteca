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
    public partial class AtualizaUsuarios : Form
    {
        //Construtor
        public AtualizaUsuarios()
        {
            InitializeComponent();
        }

        // Nada pra fazer quando a tela abrir
        private void AtualizaUsuarios_Load(object sender, EventArgs e)
        {
            QueryUsuario qUsu = new QueryUsuario();

        }

        private void bAtualizarEmail_Click(object sender, EventArgs e)
        {
            // Salva o novo e-mail no banco e fecha
            QueryUsuario qUsu = new QueryUsuario();
            qUsu.AtualizarEmail(this);
            this.Close();
        }

        private void bAtualizarTelefone_Click(object sender, EventArgs e)
        {
            // Salva o novo telefone no banco e fecha
            QueryUsuario qUsu = new QueryUsuario();
            qUsu.AtualizarTelefone(this);
            this.Close();
        }
    }
}
