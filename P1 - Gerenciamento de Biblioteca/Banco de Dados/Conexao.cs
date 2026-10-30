
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace P1___Gerenciamento_de_Biblioteca.Classes //Pasta lógica
{
    public class Conexao
    {
        public MySqlConnection conn = null;
        private MySqlTransaction transaction = null; // pra evitar salvar pela metade em caso de erro
        private MySqlCommand cmd = null;
        private MySqlDataReader reader = null;

        // Construtor: abre a conexão com o banco assim que a classe é instanciada
        public Conexao()
        {
            try
            {
                // String de conexão local do XAMPP
                string dataSource = "datasource=localhost;username=root;password='';database='biblioteca';AllowZeroDateTime=true;";
                
                this.conn = new MySqlConnection(dataSource);
                this.cmd = this.conn.CreateCommand();
                
                // Abre a conexão
                this.conn.Open();

                if (this.conn.State.Equals("Open"))
                {
                    // Inicia a transação pra garantir a integridade dos dados
                    this.transaction = this.conn.BeginTransaction();
                    this.cmd.Connection = this.conn;
                    this.cmd.CommandTimeout = 99999;
                    this.cmd.Transaction = this.transaction;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.conn.Close();
                this.conn = null;
                return;
            }
        }

        // Confirma as alterações no banco
        public void CommitBancoDados()
        {
            try
            {
                this.transaction.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar os dados no BD!\n" + ex.Message);
                this.conn.Close(); this.conn = null;
                return;
            }
        }

        // Transação para insert e update
        public bool TransInsertUpdate(string sql)
        {
            try
            {
                this.cmd = new MySqlCommand(sql, this.conn);
                if (this.cmd.ExecuteNonQuery() != 0)
                    return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                try
                {
                    // Deu erro, desfaz tudo
                    this.transaction.Rollback();
                }
                catch (Exception ex2)
                {
                    Console.WriteLine("Erro no Rollback: " + ex2.Message);
                }
            }
            return false;
        }

        // Transação para delete
        public bool TransDelete(string sql)
        {
            try
            {
                this.cmd = new MySqlCommand(sql, this.conn);
                this.cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                try
                {
                    // Deu erro, desfaz tudo
                    this.transaction.Rollback();
                }
                catch (Exception ex2)
                {
                    Console.WriteLine("Erro no Rollback: " + ex2.Message);
                }
            }
            return false;
        }

        // Transação de busca de registros
        public MySqlDataReader TransBuscaRegistro(string sql)
        {
            try
            {
                this.cmd = new MySqlCommand(sql, this.conn);
                this.reader = this.cmd.ExecuteReader();
                return this.reader;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
