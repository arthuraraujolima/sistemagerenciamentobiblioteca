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
    public partial class ConsultaUsuarios : Form
    {
        // Referência da tela de Usuários
        private Usuarios usu;

        //Construtor
        public ConsultaUsuarios() {
            InitializeComponent();
        }
        
        //Sobrecarga com parâmetro
        public ConsultaUsuarios(Usuarios usu)
        {
            InitializeComponent();
            // Salva a referência pra atualizar o grid depois da consulta
            this.usu = usu;
        }

        //Realiza consulta pelo nome
        private void bConsultarNome_Click(object sender, EventArgs e)
        {
           QueryUsuario qUsuario = new QueryUsuario();
            qUsuario.ConsultaNomeUsuario(usu, this);
            this.Close();

        }

        //Realiza consulta de todos os usuários
        private void bConsultarTodosUsuários_Click(object sender, EventArgs e)
        {
            QueryUsuario qUsu = new QueryUsuario();
            qUsu.MostraTodosUsu(usu);
            this.Close();
            
        }

        //Realiza a consulta pelo email
        private void bConsultarEmail_Click(object sender, EventArgs e)
        {
            QueryUsuario qUsu = new QueryUsuario();
            qUsu.ConsultaEmailUsu(usu, this);
            this.Close();
        }

        private void ConsultaUsuarios_Load(object sender, EventArgs e)
        {
            // Nada pra fazer quando a tela abrir
        }
    }
}
