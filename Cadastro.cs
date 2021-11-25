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
    public partial class Cadastro : Form
    {
        
        public Cadastro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); //fechar guia ao cadastrar
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            //acesso ao banco
            MySqlConnection conexao = new MySqlConnection("server=localhost;uid=root;pwd='';database=projeto;sslmode=none");
            string sql = "insert into cadastro (nome,email,login,senha) values ('"+textBoxNome.Text+"','"+textBoxEmail.Text+"','"+textBoxLogin.Text+"','"+textBoxSenha.Text+"');";
            MySqlCommand comando = new MySqlCommand(sql, conexao); //criar objeto(comando) da classe mysqlcommand (sql, conexao)


            if (string.IsNullOrEmpty(textBoxNome.Text) || string.IsNullOrEmpty(textBoxEmail.Text) || string.IsNullOrEmpty(textBoxLogin.Text) || string.IsNullOrEmpty(textBoxSenha.Text))
            {
                MessageBox.Show("Campos vazios!"); //se tiver vazios recusar a entrada de dados
            }
            else { 

            try
              {
                
                conexao.Open();
                MySqlDataReader dr = comando.ExecuteReader(); //cria objeto dr da classe MySqlDataReader
                MessageBox.Show("Cadastro realizado");

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
    }
}
