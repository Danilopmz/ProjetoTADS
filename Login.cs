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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cadastro(object sender, EventArgs e)
        {
            {
                Cadastro c1 = new Cadastro();
                c1.Show();
            }
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {

            MySqlConnection conexao = new MySqlConnection("server=localhost;uid=root;pwd='';database=projeto;sslmode=none");

            string sql = $"select * from cadastro where login='{textBoxLogin.Text}' and senha='{textBoxSenha.Text}'";

            string sql2 = $"select id from cadastro where login='{textBoxLogin.Text}'";

            MySqlCommand comando = new MySqlCommand(sql, conexao);


            try
        {

                conexao.Open();
                MySqlDataReader dr = comando.ExecuteReader(); //cria objeto dr da classe MySqlDataReader


                if (dr.Read()) //se for lido > avançar
            {
                    Form1 f1 = new Form1(); //Classe form1 f1
                    f1.setTelaLogin(this); //setTelaLogin será this
                    f1.Show(); //f1 aparecerá o form1
                    this.Hide(); //esconder a tela login


                    string nh = textBoxLogin.Text;
                    VariavelGlobalHome.nome = nh;


                    MessageBox.Show(" Seja Bem vindo ! ");



                }
            else
            {
                MessageBox.Show("Usuario ou senha inválida.");
                
            }

        }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar o login: " + ex);
            }
            finally
            {
                conexao.Close();
                conexao.Dispose(); //fechar recursos desnecessários
            }


        }
    }
}
