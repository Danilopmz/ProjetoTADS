using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projetohw
{
    public partial class Form1 : Form
    {
        private Login telaLogin = null; //conexao tela 1

        public void setTelaLogin(Login telaLogin)
        {
            this.telaLogin = telaLogin;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            telaLogin.Show(); //Mostrar tela login
            this.Dispose(); //fechar
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;uid=root;pwd='';database=projeto;sslmode=none");
            string sql = "insert into produtos (categoria,nomeproduto,valor,descricao) values ('" + listBoxCategoria.Text + "','" + textBoxNome.Text + "','" + textBoxValor.Text + "','" + textBoxDescricao.Text + "');";
            MySqlCommand comando = new MySqlCommand(sql, conexao); //criar objeto(comando) da classe mysqlcommand (sql, conexao)

            if (string.IsNullOrEmpty(listBoxCategoria.Text) || string.IsNullOrEmpty(textBoxNome.Text) || string.IsNullOrEmpty(textBoxValor.Text) || string.IsNullOrEmpty(textBoxDescricao.Text))
            {
                MessageBox.Show("Campos vazios!"); //se tiver vazios recusar a entrada de dados
            }

            else
            {
                try
                {
                    conexao.Open();
                    MySqlDataReader dr = comando.ExecuteReader(); //cria objeto dr da classe MySqlDataReader
                    MessageBox.Show("Produto cadastrado com Sucesso !");
                    textBoxNome.Clear();
                    textBoxValor.Clear();
                    textBoxDescricao.Clear();
                    

                    while (dr.Read())
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao realizar o cadastro: " + ex);

                }
                finally
                {
                    conexao.Close();
                    conexao.Dispose(); //fechar recursos desnecessários
                }
            } // fim do else
        }



        private void button1_Click_1(object sender, EventArgs e)
        {

            //criacao de tabelas
            DataTable tabela = new DataTable();

            tabela.Columns.Add("ID");
            tabela.Columns.Add("Categoria");
            tabela.Columns.Add("Nome");
            tabela.Columns.Add("Valor"); //colunas do banco
            tabela.Columns.Add("Descrição"); //colunas do banco

            //acesso ao banco
            MySqlConnection conexao = new MySqlConnection("server=localhost;uid=root;pwd='';database=projeto;sslmode=none");
            string sql = $"select * from produtos ";
            MySqlCommand comando = new MySqlCommand(sql, conexao);


            //try
            try
            {
                conexao.Open();
                MySqlDataReader dr = comando.ExecuteReader(); //cria objeto dr da classe MySqlDataReader

                while (dr.Read()) ; //leitura continua e/ou laço
                {
                    DataRow linha = tabela.NewRow(); //criação automática das linhas

                    linha[0] = dr["idproduto"].ToString();
                    linha[1] = dr["categoria"].ToString(); //array[0] captura da coluna "matricula"
                    linha[2] = dr["nomeproduto"].ToString();
                    linha[3] = dr["valor"].ToString();
                    linha[4] = dr["descricao"].ToString();

                    tabela.Rows.Add(linha);     //rows = linha
                }

                dataGridViewProduto.DataSource = tabela; //puxar os dados
                string delete = dr["idproduto"].ToString();
                VariavelGlobal.Dados = delete;

            }
            catch (Exception ex)
            {
            MessageBox.Show("Não existem produtos disponíveis!!! ", MessageBoxButtons.OK.ToString());
            }
            finally
            {
                conexao.Close();
                conexao.Dispose(); //fechar recursos desnecessários
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            listBoxCategoria.ClearSelected();
            textBoxNome.Clear();
            textBoxValor.Clear();
            textBoxDescricao.Clear();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;uid=root;pwd='';database=projeto;sslmode=none");
            string sql = "delete from produtos where idproduto=' " + VariavelGlobal.Dados + "';";
            MySqlCommand comando = new MySqlCommand(sql, conexao); //criar objeto(comando) da classe mysqlcommand (sql, conexao)

            if(string.IsNullOrEmpty(VariavelGlobal.Dados))
            {
                MessageBox.Show("Selecione um produto para deletar !!");
            }
            else
            {

                try
                {
                    conexao.Open();
                    MySqlDataReader dr = comando.ExecuteReader(); //cria objeto dr da classe MySqlDataReader
                    MessageBox.Show("Produto excluído com Sucesso !");

                    while (dr.Read())
                    {

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao deletar o produto: " + ex);

                }
                finally
                {
                    conexao.Close();
                    conexao.Dispose(); //fechar recursos desnecessários
                }

            } //fim do else
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxUser1.Text = VariavelGlobalHome.nome; //atualizar dados ao clicar
        }

        private void button7_Click(object sender, EventArgs e) // tela de localização
        {

        }
    }
}
