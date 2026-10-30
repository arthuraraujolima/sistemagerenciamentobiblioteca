using MySql.Data.MySqlClient;
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

namespace P1___Gerenciamento_de_Biblioteca.Classes
{
    // Faz a comunicação dos Livros com o banco de dados
    public class QueryLivros
    {

        //Construtor
        public QueryLivros() { }


        // ---------------- SELECT/CONSULTA ----------------
        public void MostraTodosLivros(Biblioteca bibli)
        {
            // Busca todos os livros e joga no grid
            Conexao db = new Conexao();

            try
            {
                // SELECT sem filtro — traz tudo
                string sql = "SELECT * FROM livro;";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, db.conn);
                DataTable tabela = new DataTable();

                adapter.Fill(tabela);
                bibli.gvLivros.DataSource = tabela;

                if (tabela.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum livro cadastrado no sistema.");
                }
                db.conn.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Consulta todos os disponiveis 
        public void MostraDisponiveis(Biblioteca bibli)
        {
            // Filtra só os livros com disponivel = 1 (true)
            Conexao db = new Conexao();

            try
            {
                string sql = "SELECT * FROM livro WHERE disponivel = 1;";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, db.conn);
                DataTable tabela = new DataTable();

                adapter.Fill(tabela);
                bibli.gvLivros.DataSource = tabela;

                if (tabela.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum livro disponível.");
                }
                db.conn.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //Consulta por título
        public void ConsultaTitulo(Biblioteca bibli, ConsultaLivros consLivro)
        {
            // LIKE com '%texto%' pra busca parcial — não precisa digitar o nome exato
            Conexao db = new Conexao();

            try
            {
                string sql = "SELECT * FROM livro WHERE titulo LIKE '%" + consLivro.tTituloLivro.Text + "%';";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, db.conn);
                DataTable tabela = new DataTable();

                adapter.Fill(tabela);
                bibli.gvLivros.DataSource = tabela;

                if (tabela.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum título encontrado.");
                }

                if (consLivro.tTituloLivro.Text == "")
                {
                    MessageBox.Show("Campo precisa ser preenchido!");
                }
                db.conn.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Consulta por autor
        public void ConsultaAutor(Biblioteca bibli, ConsultaLivros consLivro)
        {
            // LIKE com '%texto%' pra busca parcial — não precisa digitar o nome exato
            Conexao db = new Conexao();

            try
            {
                string sql = "SELECT * FROM livro WHERE autor LIKE '%" + consLivro.tAutorLivro.Text + "%';";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, db.conn);
                DataTable tabela = new DataTable();

                adapter.Fill(tabela);
                bibli.gvLivros.DataSource = tabela;

                if (tabela.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum título encontrado.");
                }

                if (consLivro.tAutorLivro.Text == "")
                {
                    MessageBox.Show("Campo precisa ser preenchido!");
                }
                db.conn.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //---------------- UPDATE/ATUALIZAR ----------------

        // Atualiza título pelo ID
        public void AtualizarTitulo(AtualizaLivros upLivros)
        {
            Conexao db = new Conexao();

            if (upLivros.tTituloLivro.Text == "" || upLivros.tIdLivro.Text == "")
            {
                MessageBox.Show("Campos ID e TITULO precisam ser preenchidos para realizar a alteração.");
                return;
            }

            try
            {
                string sql = "UPDATE livro SET titulo = '" + upLivros.tTituloLivro.Text + "' WHERE idLivro = " + upLivros.tIdLivro.Text + ";";
                MySqlCommand cmd = new MySqlCommand(sql, db.conn);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Título atualizado! Consulte novamente 'Consultar - Todos' para visualizar as alterações.");
                }
                else
                {
                    MessageBox.Show("Nenhum livro com o ID informado encontrado.");
                }
                db.conn.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Atualiza autor pelo ID
        public void AtualizarAutor(AtualizaLivros upLivros)
        {
            Conexao db = new Conexao();

            if (upLivros.tAutor.Text == "" || upLivros.tIdLivro.Text == "")
            {
                MessageBox.Show("Campos ID e AUTOR precisam ser preenchidos para realizar a alteração.");
                return;
            }

            try
            {
                string sql = "UPDATE livro SET autor = '" + upLivros.tAutor.Text + "' WHERE idLivro = " + upLivros.tIdLivro.Text + ";";
                MySqlCommand cmd = new MySqlCommand(sql, db.conn);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Autor atualizado! Consulte novamente 'Consultar - Todos' para visualizar as alterações.");
                }
                else
                {
                    MessageBox.Show("Nenhum autor com o ID informado encontrado.");
                }
                db.conn.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Atualiza editora pelo ID
        public void AtualizartEditora(AtualizaLivros upLivros)
        {
            Conexao db = new Conexao();

            if (upLivros.tEditora.Text == "" || upLivros.tIdLivro.Text == "")
            {
                MessageBox.Show("Campos ID e EDITORA precisam ser preenchidos para realizar a alteração.");
                return;
            }

            try
            {
                string sql = "UPDATE livro SET editora = '" + upLivros.tEditora.Text + "' WHERE idLivro = " + upLivros.tIdLivro.Text + ";";
                MySqlCommand cmd = new MySqlCommand(sql, db.conn);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Editora atualizada! Consulte novamente 'Consultar - Todos' para visualizar as alterações.");
                }
                else
                {
                    MessageBox.Show("Nenhum livro com o ID informado encontrado.");
                }
                db.conn.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ---------------- INSERT/CADASTRAR ----------------

        //Cadastra um novo livro
        public void CadastrarLivro(Biblioteca bibli, CadastroLivros cadLivro)
        {
            // Verifica se o título foi preenchido (obrigatório)
            if (cadLivro.tTitulo.Text == "")
            {
                MessageBox.Show("O campo Título é obrigatório!");
                return;
            }

            // Verifica se tem campo vazio
            if (cadLivro.tAutor.Text == "" ||
                cadLivro.tEditora.Text == "" ||
                cadLivro.tAnoPublicacao.Text == "" ||
                cadLivro.tQuantidade.Text == "" ||
                cadLivro.tQntDisponivel.Text == "") 
            {
                MessageBox.Show("Todos os campos precisam ser preenchidos!");
                return;
            }

            // Pega o ano
            int anoPublicacao = Convert.ToInt32(cadLivro.tAnoPublicacao.Text);

            // Pega a quantidade total
            int qntTotal = Convert.ToInt32(cadLivro.tQuantidade.Text);

            if (qntTotal <= 0)
            {
                MessageBox.Show("A quantidade total precisa ser maior que zero!");
                return;
            }

            // Pega a quantidade disponível
            int qntDisponivel = Convert.ToInt32(cadLivro.tQntDisponivel.Text);

            if (qntDisponivel < 0)
            {
                MessageBox.Show("A quantidade disponível não pode ser negativa!");
                return;
            }

            // Disponível não pode ser maior que o total
            if (qntDisponivel > qntTotal)
            {
                MessageBox.Show("A quantidade disponível não pode ser maior que a quantidade total!");
                return;
            }

            Conexao db = new Conexao();

            try
            {
                // Insert no banco com os novos campos
                string sql = "INSERT INTO livro (titulo, autor, editora, anoPublicacao, qntTotal, qntDisponivel, disponivel) " +
                "VALUES ('" + cadLivro.tTitulo.Text + "', '" +
                cadLivro.tAutor.Text + "', '" +
                cadLivro.tEditora.Text + "', " +
                anoPublicacao + ", " +
                qntTotal + ", " +
                qntDisponivel + ", " +
                (qntDisponivel > 0 ? "1" : "0") + ");";

                MySqlCommand cmd = new MySqlCommand(sql, db.conn);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Livro cadastrado com sucesso!");
                    MostraTodosLivros(bibli);
                }
                db.conn.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Atualiza quantidade total pelo ID
        public void AtualizarQntTotal(AtualizaLivros upLivros)
        {
            Conexao db = new Conexao();

            if (upLivros.tQntTotal.Text == "" || upLivros.tIdLivro.Text == "")
            {
                MessageBox.Show("Campos ID e QUANTIDADE TOTAL precisam ser preenchidos para realizar a alteração.");
                return;
            }

            try
            {
                string sql = "UPDATE livro SET qntTotal = " + upLivros.tQntTotal.Text + " WHERE idLivro = " + upLivros.tIdLivro.Text + ";";
                MySqlCommand cmd = new MySqlCommand(sql, db.conn);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Quantidade total atualizada! Consulte novamente 'Consultar - Todos' para visualizar as alterações.");
                }
                else
                {
                    MessageBox.Show("Nenhum livro com o ID informado encontrado.");
                }
                db.conn.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Atualiza quantidade disponível pelo ID
        public void AtualizarQntDisponivel(AtualizaLivros upLivros)
        {
            Conexao db = new Conexao();

            if (upLivros.tQntDisponivel.Text == "" || upLivros.tIdLivro.Text == "")
            {
                MessageBox.Show("Campos ID e QUANTIDADE DISPONÍVEL precisam ser preenchidos para realizar a alteração.");
                return;
            }

            try
            {
                string sql = "UPDATE livro SET qntDisponivel = " + upLivros.tQntDisponivel.Text + " WHERE idLivro = " + upLivros.tIdLivro.Text + ";";
                MySqlCommand cmd = new MySqlCommand(sql, db.conn);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Quantidade disponível atualizada! Consulte novamente 'Consultar - Todos' para visualizar as alterações.");
                }
                else
                {
                    MessageBox.Show("Nenhum livro com o ID informado encontrado.");
                }
                db.conn.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}


        


