using P1___Gerenciamento_de_Biblioteca.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1___Gerenciamento_de_Biblioteca.Formularios
{
    public partial class Emprestimo : Form
    {
        public Emprestimo()
        {
            InitializeComponent();
        }

        //Abre consulta de empréstimos
        private void bConsultarEmprestimos_Click(object sender, EventArgs e)
        {
            ConsultaEmprestimos consulta = new ConsultaEmprestimos();
            consulta.ShowDialog();
        }

        private void bRegistrarEmprestimo_Click(object sender, EventArgs e)
        {
            // Verifica se todos os campos foram preenchidos
            if (string.IsNullOrWhiteSpace(tIdUsuario.Text) ||
                string.IsNullOrWhiteSpace(tIdLivro.Text) ||
                string.IsNullOrWhiteSpace(tDataEmprestimo.Text) ||
                string.IsNullOrWhiteSpace(tDataDevolucao.Text))
            {
                MessageBox.Show(
                    "Preencha todos os campos do empréstimo.");

                return;
            }

            // Verifica se os IDs são números
            int idUsuario;
            int idLivro;

            if (!int.TryParse(tIdUsuario.Text, out idUsuario) ||
                !int.TryParse(tIdLivro.Text, out idLivro))
            {
                MessageBox.Show(
                    "O ID do usuário e o ID do livro devem ser números.");

                return;
            }

            // Verifica se as datas estão no formato correto
            DateTime dataEmprestimo;
            DateTime dataDevolucao;

            if (!DateTime.TryParseExact(
                    tDataEmprestimo.Text,
                    "dd/MM/yyyy",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out dataEmprestimo))
            {
                MessageBox.Show(
                    "A data do empréstimo deve estar no formato dd/MM/yyyy.");

                return;
            }

            if (!DateTime.TryParseExact(
                    tDataDevolucao.Text,
                    "dd/MM/yyyy",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out dataDevolucao))
            {
                MessageBox.Show(
                    "A data de devolução deve estar no formato dd/MM/yyyy.");

                return;
            }

            // Converte as datas para o formato aceito pelo MySQL
            string dataEmprestimoMySql =
                dataEmprestimo.ToString("yyyy-MM-dd");

            string dataDevolucaoMySql =
                dataDevolucao.ToString("yyyy-MM-dd");

            QueryEmprestimos qEmprestimo =
                new QueryEmprestimos();

            qEmprestimo.RegistrarEmprestimo(
                tIdUsuario.Text,
                tIdLivro.Text,
                dataEmprestimoMySql,
                dataDevolucaoMySql
                );
        }

        //Registra devolução
        private void bRegistrarDevolucao_Click(object sender, EventArgs e)
        {
            // Verifica se o ID do empréstimo foi preenchido
            if (string.IsNullOrWhiteSpace(tIdEmprestimo.Text))
            {
                MessageBox.Show(
                    "Informe o ID do empréstimo.");

                return;
            }

            // Verifica se o ID é número
            int idEmprestimo;

            if (!int.TryParse(
                    tIdEmprestimo.Text,
                    out idEmprestimo))
            {
                MessageBox.Show(
                    "O ID do empréstimo deve ser um número.");

                return;
            }

            QueryEmprestimos qEmprestimo =
                new QueryEmprestimos();

            qEmprestimo.RegistrarDevolucao(
                tIdEmprestimo.Text
            );
        }
        

        // Volta para a tela anterior
 
        private void bConsultarEmprestimos_Click_1(object sender, EventArgs e)
        {
            ConsultaEmprestimos consulta = new ConsultaEmprestimos();
            consulta.ShowDialog();

        }

        private void bVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
        
