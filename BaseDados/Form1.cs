using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BaseDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            #region MySQL
            string strConnection = "server=127.0.0.1;User Id=root;password=";
            //string strConnection = "server=127.0.0.1;Id=root;database=cadastro;password=";

            MySqlConnection conexao = new MySqlConnection(strConnection);
            //conexao.ConnectionString = strConnection;
            try
            {
                conexao.Open();
                labelResultado.Text = "Conectado Mysql";

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "CREATE DATABASE IF NOT EXISTS curso_db";
                comando.ExecuteNonQuery();
                labelResultado.Text = "Base de dados criada com sucesso";
                comando.Dispose();
            }
            catch (Exception ex)
            {
                labelResultado.Text = "Error \n" + ex.Message;
            }
            finally
            {
                
                conexao.Close();
            }

            
            #endregion
        }

        private void btnCriarTabela_Click(object sender, EventArgs e)
        {
            string strConnection = "server=127.0.0.1;User Id=root;database=cadastro;password=";
            MySqlConnection conexao = new MySqlConnection(strConnection);

            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;

                comando.CommandText = "CREATE TABLE pessoas(id INT NOT NULL AUTO_INCREMENT , nome VARCHAR(50), email VARCHAR(50), PRIMARY KEY(id))";
                comando.ExecuteNonQuery();

                labelResultado.Text = "Tabela Criada MySQL";
                comando.Dispose();
            }
            catch(Exception ex) 
            {
                labelResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
            }

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string strConnection = "server=127.0.0.1;User Id=root;database=cadastro;password=";
            MySqlConnection conexao = new MySqlConnection(strConnection);
            try
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;

                int id = new Random(DateTime.Now.Millisecond).Next(0,1000);
                string nome = txtNome.Text;
                string email = txtEmail.Text;

                comando.CommandText = $"INSERT INTO pessoas Values ('''{id}''', '''{nome}''', '''{email}''')";

                comando.ExecuteNonQuery();
                labelResultado.Text = $"Resgistro de {nome} com email {email} inserido MySQL";
                comando.Dispose();

            }
            catch (Exception ex)
            {
                labelResultado.Text=ex.Message;
            }
            finally
            {
                conexao.Close();
                txtNome.Text = "";
                txtEmail.Text = "";
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            labelResultado.Text = "";
            lista.Rows.Clear();

            string strConnection = "server=127.0.0.1;User Id=root;database=cadastro;password=";
            MySqlConnection conexao = new MySqlConnection(strConnection);
            try
            {
                string query = "SELECT * FROM pessoas ";
                if (txtNome.Text != "")
                {
                    query = $"Select * FROM pessoas WHERE nome LIKE '''{txtNome.Text}";
                }
                DataTable dados = new DataTable();

                MySqlDataAdapter adaptador = new MySqlDataAdapter(query, strConnection);
                conexao.Open();

                adaptador.Fill(dados);

                foreach (DataRow linha in dados.Rows)
                {
                    lista.Rows.Add(linha.ItemArray);
                }
            }
            catch (Exception ex)
            {
                labelResultado.Text = ex.Message;
            }finally { conexao.Close(); }


        }

        private void btnExluir_Click(object sender, EventArgs e)
        {

            string strConnection = "server=127.0.0.1;User Id=root;database=cadastro;password=";
            MySqlConnection conexao = new MySqlConnection(strConnection);
            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;

                
                int id = (int)lista.SelectedRows[0].Cells[0].Value;

                comando.CommandText = $"DELETE FROM pessoas WHERE id = {id};";
                comando.ExecuteNonQuery();

                labelResultado.Text = $"Registro excluido do Banco de dados \n {id}";
                
                comando.Dispose();
                
            }
            catch (Exception ex )
            {
                labelResultado.Text = ex.Message;
            }
            finally { conexao.Close(); }
        }
    }
}
