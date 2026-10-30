using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace P1___Gerenciamento_de_Biblioteca.Classes
{
    internal class QueryEmprestimos
    {
        public QueryEmprestimos()
        {
        }

        // Registra um novo empréstimo
        public void RegistrarEmprestimo(
            string idUsuario,
            string idLivro,
            string dataEmprestimo,
            string dataDevolucao)
        {
            Conexao db = new Conexao();

            try
            {
                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();
                }

                // Verifica se o livro possui exemplares disponíveis
                string consulta = "SELECT qntDisponivel " +
                                  "FROM livro " +
                                  "WHERE idLivro = @idLivro";

                MySqlCommand cmdConsulta =
                    new MySqlCommand(consulta, db.conn);

                cmdConsulta.Parameters.AddWithValue("@idLivro", idLivro);

                object resultado = cmdConsulta.ExecuteScalar();

                if (resultado == null)
                {
                    MessageBox.Show("Livro não encontrado.");
                    return;
                }

                int quantidadeDisponivel = Convert.ToInt32(resultado);

                if (quantidadeDisponivel <= 0)
                {
                    MessageBox.Show(
                        "Este livro não está disponível para empréstimo.");
                    return;
                }

                // Registra o empréstimo
                string sql = "INSERT INTO emprestimo " +
                             "(dataEmprestimo, dataDevPrevista, " +
                             "idLivro, idUsuario) " +
                             "VALUES (@dataEmprestimo, @dataDevolucao, " +
                             "@idLivro, @idUsuario)";

                MySqlCommand cmd = new MySqlCommand(sql, db.conn);

                cmd.Parameters.AddWithValue(
                    "@dataEmprestimo",
                    dataEmprestimo);

                cmd.Parameters.AddWithValue(
                    "@dataDevolucao",
                    dataDevolucao);

                cmd.Parameters.AddWithValue(
                    "@idLivro",
                    idLivro);

                cmd.Parameters.AddWithValue(
                    "@idUsuario",
                    idUsuario);

                cmd.ExecuteNonQuery();

                // Diminui a quantidade disponível do livro
                string atualizaLivro =
                    "UPDATE livro " +
                    "SET qntDisponivel = qntDisponivel - 1, " +
                    "disponivel = IF(qntDisponivel - 1 > 0, 1, 0) " +
                    "WHERE idLivro = @idLivro";

                MySqlCommand cmdAtualiza =
                    new MySqlCommand(atualizaLivro, db.conn);

                cmdAtualiza.Parameters.AddWithValue(
                    "@idLivro",
                    idLivro);

                cmdAtualiza.ExecuteNonQuery();

                MessageBox.Show(
                    "Empréstimo registrado com sucesso!");
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

        // Registra a devolução de um livro
        public void RegistrarDevolucao(string idEmprestimo)
        {
            Conexao db = new Conexao();

            try
            {
                if (db.conn.State == ConnectionState.Closed)
                {
                    db.conn.Open();
                }

                // Procura o empréstimo que ainda não foi devolvido
                string consulta =
                    "SELECT idLivro " +
                    "FROM emprestimo " +
                    "WHERE idEmprestimo = @idEmprestimo " +
                    "AND dataDevReal IS NULL";

                MySqlCommand cmdConsulta =
                    new MySqlCommand(consulta, db.conn);

                cmdConsulta.Parameters.AddWithValue(
                    "@idEmprestimo",
                    idEmprestimo);

                object resultado = cmdConsulta.ExecuteScalar();

                if (resultado == null)
                {
                    MessageBox.Show(
                        "Empréstimo não encontrado ou já devolvido.");
                    return;
                }

                int idLivro = Convert.ToInt32(resultado);

                // Registra a data da devolução
                string atualizaEmprestimo =
                    "UPDATE emprestimo " +
                    "SET dataDevReal = CURDATE() " +
                    "WHERE idEmprestimo = @idEmprestimo";

                MySqlCommand cmdEmprestimo =
                    new MySqlCommand(atualizaEmprestimo, db.conn);

                cmdEmprestimo.Parameters.AddWithValue(
                    "@idEmprestimo",
                    idEmprestimo);

                cmdEmprestimo.ExecuteNonQuery();

                // Aumenta a quantidade disponível do livro
                string atualizaLivro =
                    "UPDATE livro " +
                    "SET qntDisponivel = qntDisponivel + 1, " +
                    "disponivel = 1 " +
                    "WHERE idLivro = @idLivro";

                MySqlCommand cmdLivro =
                    new MySqlCommand(atualizaLivro, db.conn);

                cmdLivro.Parameters.AddWithValue(
                    "@idLivro",
                    idLivro);

                cmdLivro.ExecuteNonQuery();

                MessageBox.Show(
                    "Livro devolvido com sucesso!");
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