using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTattoo.Model.DAO {
    public class ControleBD {
        private string connectionString;
        public ControleBD(string conexao) {
            this.connectionString = conexao;
        }
        public void cadastrarSQL(Cliente dados) {
            string sql = "INSERT INTO CLIENTE (NOME,ENDERECO,CEP,BAIRRO,CIDADE,TELEFONE,HORARIO,TATUAGEM) " + "VALUES ('" + dados.Nome + "', '" + dados.Endereco + "', '" + dados.Cep + "', '" + dados.Bairro + "', '" + dados.Cidade + "', '" + dados.Telefone + "', '" + dados.Horario + "', '" + dados.Tatuagem + "')";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            try {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Cadastro realizado!");
            } catch (Exception ex) {
                MessageBox.Show("Erro: " + ex.ToString());
            } finally {
                con.Close();
            }
        }
        public void atualizarSQL(Cliente dados) {
            string sql = "UPDATE CLIENTE SET NOME='" + dados.Nome + "', ENDERECO='" + dados.Endereco + "', CEP='" + dados.Cep + "', BAIRRO='" + dados.Bairro + "', CIDADE='" + dados.Cidade + "', TELEFONE='" + dados.Telefone + "', HORARIO='" + dados.Horario + "', TATUAGEM='" + dados.Tatuagem + "' WHERE ID =" + dados.Id;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            try {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Cadastro atualizado!");
            }
            catch (Exception ex) {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally {
                con.Close();
            }
        }
        public Cliente buscarSQL(string id, ref bool noId) {
            Cliente dados = new Cliente();
            string sql = "SELECT * FROM CLIENTE WHERE ID= " + id;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            con.Open();
            try {
                reader = cmd.ExecuteReader();
                if (reader.Read()) {
                    noId = false;
                    dados.Id = Convert.ToInt32(reader[0].ToString());
                    dados.Nome = reader[1].ToString();
                    dados.Endereco = reader[2].ToString();
                    dados.Cep = reader[3].ToString();
                    dados.Bairro = reader[4].ToString();
                    dados.Cidade = reader[5].ToString();
                    dados.Telefone = reader[6].ToString();
                    dados.Horario = reader[7].ToString();
                    dados.Tatuagem = reader[8].ToString();
                } 
                else
                    noId = true;
            } 
            catch (Exception ex) {
                MessageBox.Show("Erro: " + ex.ToString());
            } 
            finally {
                con.Close();
            }
            return dados;
        }
        public void dataGridSQL(ref DataGridView dataGridView) {
            string sql = "SELECT * FROM DB_TATTOOCADASTRO.DBO.CLIENTE ;";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            try {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex) {
                MessageBox.Show("Erro: " + ex.Message.ToString());
            }
        }
        public void excluirSQL(string id) {
            string sql = "DELETE FROM CLIENTE WHERE ID=" + id;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            try {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Registro excluído com sucesso!");
            }
            catch (Exception ex) {
                MessageBox.Show("Erro: " + ex.Message.ToString());
            } 
            finally {
                con.Close();
            }
        }
    }
}
