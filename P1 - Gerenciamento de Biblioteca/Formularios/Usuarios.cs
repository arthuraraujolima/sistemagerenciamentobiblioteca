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
    public partial class Usuarios : Form
    {
        //Construtor
        public Usuarios()
        {
            InitializeComponent();
        }

        // Abre tela de consulta
        private void bConsultarUsuarios_Click(object sender, EventArgs e)
        {
            ConsultaUsuarios consulta = new ConsultaUsuarios(this);
            consulta.ShowDialog();
        }

        // Carrega usuários ao abrir a tela
        private void Usuarios_Load(object sender, EventArgs e)
        {
            QueryUsuario qUsu = new QueryUsuario();
            qUsu.MostraTodosUsu(this);

        }

        // Volta pra tela inicial
        private void bVoltarTelaInicial_Click(object sender, EventArgs e)
        {
            FormTelaInicial telaInicial = new FormTelaInicial();
            telaInicial.Show();
            this.Close();
        }

        // Abre tela de atualização
        private void bAtualizarUsuarios_Click(object sender, EventArgs e)
        {
            AtualizaUsuarios upUsu = new AtualizaUsuarios();
            upUsu.ShowDialog();
        }

        // Abre tela de cadastro
        private void bCadastrarUsuarios_Click(object sender, EventArgs e)
        {
            CadastroUsuarios cadUsu = new CadastroUsuarios(this);
            cadUsu.ShowDialog();
        }

 
    }
}
