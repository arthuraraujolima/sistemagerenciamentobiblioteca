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
    public partial class ConsultaEmprestimos : Form
    {
        public ConsultaEmprestimos()
        {
            InitializeComponent();
        }

        // Carrega todos os empréstimos ao abrir a tela
        private void ConsultaEmprestimos_Load(object sender, EventArgs e)
        {

            QueryListaEmprestimos query = new QueryListaEmprestimos();

            query.MostraTodosEmprestimos(dgvEmprestimos);
        }

        // Fecha a tela
      
        private void bVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

    
