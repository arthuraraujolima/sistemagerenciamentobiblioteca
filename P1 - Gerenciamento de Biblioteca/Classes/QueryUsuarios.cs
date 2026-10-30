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
    // Faz a comunicação dos Usuários com o banco de dados
    public class QueryUsuario
    {

        //Construtor
        public QueryUsuario() { }

        //---------------- SELECT/CONSULTA //----------------
        public void MostraTodosUsu(Usuarios usu)
        {
            // Busca todos os usuários e joga no grid
            Conexao db = new Conexao();

            try
            {
                // SELECT sem filtro — traz todos os usuários
                string sql = "SELECT * FROM usuario;";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, db.conn);
                DataTable tabela = new DataTable();
                
                adapter.Fill(tabela);
                usu.gvUsuarios.DataSource = tabela;

                if (tabela.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum usuário cadastrado no sistema.");
                }
                db.conn.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Consulta usuário pelo email
        public void ConsultaEmailUsu(Usuarios usu, ConsultaUsuarios consUsu)
        {
            if (consUsu.tEmailUsuario.Text == "")
            {
                MessageBox.Show("Campo precisa ser preenchido!");
                return;
            }

            Conexao db = new Conexao();

            try
            {
                // Busca exata por email — email é único no banco
                string sql = "SELECT * FROM usuario WHERE email ='" + consUsu.tEmailUsuario.Text + "';";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, db.conn);
                DataTable tabela = new DataTable();
                
                adapter.Fill(tabela);
                usu.gvUsuarios.DataSource = tabela;

                if (tabela.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum usuário com este email cadastrado no sistema.");
                }
                db.conn.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Consulta usuário pelo nome
        public void ConsultaNomeUsuario(Usuarios usu, ConsultaUsuarios consUsu)
        {
            if (consUsu.tNomeUsuario.Text == "")
            {
                MessageBox.Show("Campo precisa ser preenchido!");
                return;
            }

            Conexao db = new Conexao();

            try
            {
                // LIKE com '%texto%' pra busca parcial — não precisa digitar o nome exato
                string sql = "SELECT * FROM usuario WHERE nome LIKE '%" + consUsu.tNomeUsuario.Text + "%';";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, db.conn);
                DataTable tabela = new DataTable();
                
                adapter.Fill(tabela);
                usu.gvUsuarios.DataSource = tabela;

                if (tabela.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum usuário com este nome cadastrado no sistema.");
                }
                db.conn.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ---------------- UPDATE/ATUALIZAR ----------------

        // Atualiza email pelo id
        public void AtualizarEmail(AtualizaUsuarios upUsu)
        {
            Conexao db = new Conexao();

            if (upUsu.tEmail.Text == "" || upUsu.tIdUsuario.Text == "")
            {
                MessageBox.Show("Campos ID e EMAIL precisam ser preenchidos para realizar a alteração.");
                return;
            }

            if (!upUsu.tEmail.Text.Contains("@"))
            {
                MessageBox.Show("Email inválido!");
                return;
            }

            try
            {
                // UPDATE filtrando pelo ID do usuário
                string sql = "UPDATE usuario SET email = '" + upUsu.tEmail.Text + "' WHERE idUsuario = " + upUsu.tIdUsuario.Text + ";";
                MySqlCommand cmd = new MySqlCommand(sql, db.conn);
                
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("E-mail atualizado! Consulte novamente 'Consultar - Todos' para visualizar as alterações.");
                }
                else
                {
                    MessageBox.Show("Nenhum usuário com o ID informado encontrado.");
                }
                db.conn.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Atualiza telefone pelo ID
        public void AtualizarTelefone(AtualizaUsuarios upUsu)
        {
            Conexao db = new Conexao();

            if (upUsu.tTelefone.Text == "" || upUsu.tIdUsuario.Text == "")
            {
                MessageBox.Show("Campos ID e TELEFONE precisam ser preenchidos para realizar a alteração.");
                return;
            }

            if (upUsu.tTelefone.Text.Length != 11)
            {
                MessageBox.Show("Campo 'Telefone' precisa ter 11 dígitos numéricos!");
                return;
            }

            try
            {
                // UPDATE filtrando pelo ID do usuário
                string sql = "UPDATE usuario SET telefone = '" + upUsu.tTelefone.Text + "' WHERE idUsuario = " + upUsu.tIdUsuario.Text + ";";
                MySqlCommand cmd = new MySqlCommand(sql, db.conn);
                
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Telefone atualizado! Consulte novamente 'Consultar - Todos' para visualizar as alterações.");
                }
                else
                {
                    MessageBox.Show("Nenhum usuário com o ID informado encontrado.");
                }
                db.conn.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ---------------- INSERT/CADASTRAR ----------------

        //Cadastra um novo usuário
        public void CadastrarUsuario(Usuarios usu, CadastroUsuarios cadUsu)
        {
            // Verifica se TODOS os campos estão preenchidos (tudo NOT NULL no BD)
            if (cadUsu.tNome.Text == "" || cadUsu.cbTipo.SelectedIndex == -1 ||
                cadUsu.tEmail.Text == "" || cadUsu.tTelefone.Text == "")
            {
                MessageBox.Show("Todos os campos são obrigatórios! Preencha Nome, Tipo, Email e Telefone.");
                return;
            }

            // Verifica email
            if (!cadUsu.tEmail.Text.Contains("@"))
            {
                MessageBox.Show("Email inválido! Precisa conter '@'.");
                return;
            }

            // Verifica telefone
            if (cadUsu.tTelefone.Text.Length != 11)
            {
                MessageBox.Show("Telefone precisa ter 11 dígitos numéricos (DDD + número)!");
                return;
            }

            Conexao db = new Conexao();

            try
            {
                // Pega a data de hoje formatada pro mysql
                string dataAtual = DateTime.Now.ToString("yyyy-MM-dd");

                // Pega o tipo selecionado no ComboBox
                string tipoSelecionado = cadUsu.cbTipo.SelectedItem.ToString();

                // Insere no banco — disponivel já entra como 1 (ativo)
                string sql = "INSERT INTO usuario (nome, email, telefone, dataCadastro, tipo) " +
                "VALUES ('" + cadUsu.tNome.Text + "', '" +
                cadUsu.tEmail.Text + "', '" +
                cadUsu.tTelefone.Text + "', '" +
                dataAtual + "', '" +
                tipoSelecionado + "');";

                MySqlCommand cmd = new MySqlCommand(sql, db.conn);
                
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!");
                    MostraTodosUsu(usu);
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