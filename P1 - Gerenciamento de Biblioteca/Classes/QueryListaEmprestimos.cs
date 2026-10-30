using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace P1___Gerenciamento_de_Biblioteca.Classes
{
    internal class QueryListaEmprestimos
    {
        public QueryListaEmprestimos()
        {
        }

        // Mostra todos os empréstimos cadastrados
        public void MostraTodosEmprestimos(DataGridView tabela)
        {
            Conexao db = new Conexao();

            try
            {
                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();
                }

                string sql =
                    "SELECT e.idEmprestimo, " +
                    "u.nome AS usuario, " +
                    "l.titulo AS livro, " +
                    "e.dataEmprestimo, " +
                    "e.dataDevPrevista, " +
                    "e.dataDevReal, " +
                    "CASE " +
                    "WHEN e.dataDevReal IS NULL THEN 'Ativo' " +
                    "ELSE 'Devolvido' " +
                    "END AS status " +
                    "FROM emprestimo e " +
                    "INNER JOIN usuario u ON e.idUsuario = u.idUsuario " +
                    "INNER JOIN livro l ON e.idLivro = l.idLivro";

                MySqlCommand cmd =
                    new MySqlCommand(sql, db.conn);

                MySqlDataAdapter da =
                    new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                tabela.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (db.conn != null &&
                    db.conn.State == ConnectionState.Open)
                {
                    db.conn.Close();
                }
            }
        }
    }
}