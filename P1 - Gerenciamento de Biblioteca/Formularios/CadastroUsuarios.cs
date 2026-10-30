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
    public partial class CadastroUsuarios : Form
    {
        // Referência da tela de Usuários
        private Usuarios usu;

        // Construtor padrão
        public CadastroUsuarios() { }

        // Construtor com parâmetro
        public CadastroUsuarios(Usuarios usu)
        {
            InitializeComponent();

            // Salva quem chamou essa tela pra poder atualizar o gridview depois
            this.usu = usu;
        }

        // Esse evento dispara quando o formulário carrega
        private void CadastroUsuarios_Load(object sender, EventArgs e)
        {
            // Já seleciona a primeira opção do ComboBox (Aluno)
            cbTipo.SelectedIndex = 0;
        }

        // Salva o cadastro
        private void bCadastrar_Click(object sender, EventArgs e)
        {
            // Validação — TODOS os campos são obrigatórios (NOT NULL no BD)
            if (string.IsNullOrWhiteSpace(tNome.Text))
            {
                MessageBox.Show("O campo 'Nome' é obrigatório!");
                tNome.Focus();
                return;
            }

            if (cbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o 'Tipo' (Aluno ou Professor)!");
                cbTipo.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tEmail.Text))
            {
                MessageBox.Show("O campo 'Email' é obrigatório!");
                tEmail.Focus();
                return;
            }

            if (!tEmail.Text.Contains("@"))
            {
                MessageBox.Show("Email inválido! Precisa conter '@'.");
                tEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tTelefone.Text))
            {
                MessageBox.Show("O campo 'Telefone' é obrigatório!");
                tTelefone.Focus();
                return;
            }

            if (tTelefone.Text.Length != 11)
            {
                MessageBox.Show("Telefone precisa ter 11 dígitos numéricos (DDD + número)!");
                tTelefone.Focus();
                return;
            }

            QueryUsuario qUsu = new QueryUsuario();
            qUsu.CadastrarUsuario(usu, this);
            this.Close();
        }

    }
}
