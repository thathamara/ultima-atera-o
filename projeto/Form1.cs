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


namespace testeprojetoInt
{
    public partial class btn_exibir : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;

        string strSQL;

        public btn_exibir()
        {
            InitializeComponent();
        }

        private void txt_Novo_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server = localhost; Database = prjteste; Uid = root; Pwd = uzumaki031;");

                strSQL = "INSERT INTO anjo (nome_anjo,cpf_anjo,endereço_anjo,email_anjo,senha_anjo,dataNascimento_anjo,telefone_anjo,nivelGraduaçao_anjo,genero_anjo,perguntaSegurança_anjo) VALUES (@nome_anjo,@cpf_anjo,@endereço_anjo,@email_anjo,@senha_anjo,@dataNascimento_anjo,@telefone_anjo,@nivelGraduaçao_anjo,@genero_anjo,@perguntaSegurança_anjo)";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@nome_anjo", txtNome.Text);
                comando.Parameters.AddWithValue("@cpf_anjo", txtCPF.Text);
                comando.Parameters.AddWithValue("@endereço_anjo", txtEndereco.Text);
                comando.Parameters.AddWithValue("@email_anjo", txtEmail.Text);
                comando.Parameters.AddWithValue("@senha_anjo", txtSenha.Text);
                comando.Parameters.AddWithValue("@dataNascimento_anjo", txtDTNac.Text);
                comando.Parameters.AddWithValue("@telefone_anjo", txtTelefone.Text);
                comando.Parameters.AddWithValue("@nivelGraduaçao_anjo", txtEscolaridade.Text);
                comando.Parameters.AddWithValue("@genero_anjo", txtGenero.Text);
                comando.Parameters.AddWithValue("@perguntaSegurança_anjo", txt_seguranca.Text);

                conexao.Open();

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;

            }

        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server = localhost; Database = prjteste; Uid = root; Pwd =uzumaki031;");

                strSQL = "update anjo set nome_anjo = @nome_anjo, cpf_anjo = @cpf_anjo, endereço_anjo = @endereço_anjo ,email_anjo = @email_anjo,senha_anjo = @senha_anjo, dataNascimento_anjo = @dataNascimento_anjo, telefone_anjo = @telefone_anjo, nivelGraduaçao_anjo = @nivelGraduaçao_anjo, genero_anjo = @genero_anjo, perguntaSegurança_anjo = @perguntaSegurança_anjo, where idAnjo = @idAnjo;";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@idAnjo", txt_ID.Text);
                comando.Parameters.AddWithValue("@nome_anjo", txtNome.Text);
                comando.Parameters.AddWithValue("@cpf_anjo", txtCPF.Text);
                comando.Parameters.AddWithValue("@endereço_anjo", txtEndereco.Text);
                comando.Parameters.AddWithValue("@email_anjo", txtEmail.Text);
                comando.Parameters.AddWithValue("@senha_anjo", txtSenha.Text);
                comando.Parameters.AddWithValue("@dataNascimento_anjo", txtDTNac.Text);
                comando.Parameters.AddWithValue("@telefone_anjo", txtTelefone.Text);
                comando.Parameters.AddWithValue("@nivelGraduaçao_anjo", txtEscolaridade.Text);
                comando.Parameters.AddWithValue("@genero_anjo", txtGenero.Text);
                comando.Parameters.AddWithValue("@perguntaSegurança_anjo", txt_seguranca.Text);

                conexao.Open();

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;

            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server = localhost; Database = prjteste; Uid = root; Pwd = uzumaki031;");

                strSQL = "DELETE FROM anjo WHERE idAnjo= @idAnjo";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@idAnjo", txt_ID.Text);

                conexao.Open();

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;

            }
        }

        private void btn_Alterar_Click_1(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server = localhost; Database = prjteste; Uid = root; Pwd = uzumaki031;");

                strSQL = "update anjo set nome_anjo=@nome_anjo, cpf_anjo=@cpf_anjo, endereço_anjo=@endereço_anjo ,email_anjo=@email_anjo,senha_anjo=@senha_anjo, dataNascimento_anjo=@dataNascimento_anjo, telefone_anjo=@telefone_anjo, nivelGraduaçao_anjo=@nivelGraduaçao_anjo, genero_anjo=@genero_anjo, perguntaSegurança_anjo=@perguntaSegurança_anjo where idAnjo=@idAnjo;";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@idAnjo", txt_ID.Text);
                comando.Parameters.AddWithValue("@nome_anjo", txtNome.Text);
                comando.Parameters.AddWithValue("@cpf_anjo", txtCPF.Text);
                comando.Parameters.AddWithValue("@endereço_anjo", txtEndereco.Text);
                comando.Parameters.AddWithValue("@email_anjo", txtEmail.Text);
                comando.Parameters.AddWithValue("@senha_anjo", txtSenha.Text);
                comando.Parameters.AddWithValue("@dataNascimento_anjo", txtDTNac.Text);
                comando.Parameters.AddWithValue("@telefone_anjo", txtTelefone.Text);
                comando.Parameters.AddWithValue("@nivelGraduaçao_anjo", txtEscolaridade.Text);
                comando.Parameters.AddWithValue("@genero_anjo", txtGenero.Text);
                comando.Parameters.AddWithValue("@perguntaSegurança_anjo", txt_seguranca.Text);

                conexao.Open();

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;

            }
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server = localhost; Database = prjteste; Uid = root; Pwd = uzumaki031;");

                strSQL = "select * from WHERE idAnjo= @idAnjo";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@idAnjo", txt_ID.Text);

                conexao.Open();

                dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    txtNome.Text = Convert.ToString(dr["nome_anjo"]);
                    txtCPF.Text = Convert.ToString(dr["cpf_anjo"]);
                    txtEndereco.Text = Convert.ToString(dr["endereço_anjo"]);
                    txtEmail.Text = Convert.ToString(dr["email_anjo"]);
                    txtSenha.Text = Convert.ToString(dr["senha_anjo"]);
                    txtDTNac.Text = Convert.ToString(dr["dataNascimento_anjo"]);
                    txtTelefone.Text = Convert.ToString(dr["telefone_anjo"]);
                    txtEscolaridade.Text = Convert.ToString(dr["nivelGraduaçao_anjo"]);
                    txtGenero.Text = Convert.ToString(dr["genero_anjo"]);
                    txt_seguranca.Text = Convert.ToString(dr["perguntaSegurança_anjo"]);
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;

            }
        }

        private void btn_exibir1_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server = localhost; Database = prjteste; Uid = root; Pwd = 1234;");

                strSQL = "SELECT * FROM anjo";

                da = new MySqlDataAdapter(strSQL, conexao);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dtv_exibir.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;

            }
        }

        private void dtv_exibir_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
        
    

