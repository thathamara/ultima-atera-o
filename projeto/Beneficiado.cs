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
    public partial class Beneficiado : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;

        string strSQL;
        public Beneficiado()
        {
            InitializeComponent();
        }

        private void txt_Novo_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server = localhost; Database = prjteste; Uid = root; Pwd = uzumaki031;");

                strSQL = "INSERT INTO beneficiado (nome_beneficiado,cpf_beneficiado,endereço_beneficiado,email_beneficiado,senha_beneficiado,dataNascimento_beneficiado,telefone_beneficiado,nivelGraduaçao_beneficiado,genero_beneficiado,perguntaSegurança_beneficiado,emquepossoteajuda_beneficiado) VALUES (@nome_beneficiado,@cpf_beneficiado,@endereço_beneficiado,@email_beneficiado,@senha_beneficiado,@dataNascimento_beneficiado,@telefone_beneficiado,@nivelGraduaçao_beneficiado,@genero_beneficiado,@perguntaSegurança_beneficiado,emquepossoteajuda_beneficiado)";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@nome_beneficiado", txtNome.Text);
                comando.Parameters.AddWithValue("@cpf_beneficiado", txtCPF.Text);
                comando.Parameters.AddWithValue("@endereço_beneficiado", txtEndereco.Text);
                comando.Parameters.AddWithValue("@email_beneficiado", txtEmail.Text);
                comando.Parameters.AddWithValue("@senha_beneficiado", txtSenha.Text);
                comando.Parameters.AddWithValue("@dataNascimento_beneficiado", txtDTNac.Text);
                comando.Parameters.AddWithValue("@telefone_beneficiado", txtTelefone.Text);
                comando.Parameters.AddWithValue("@nivelGraduaçao_beneficiado", txtEscolaridade.Text);
                comando.Parameters.AddWithValue("@genero_beneficiado", txtGenero.Text);
                comando.Parameters.AddWithValue("@perguntaSegurança_beneficiado", txt_seguranca.Text);
                comando.Parameters.AddWithValue("emquepossoteajuda_beneficiado", txt_seguranca.Text);
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

        private void btn_Alterar2_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server = localhost; Database = prjteste; Uid = root; Pwd = uzumaki031;");


                strSQL = "update beneficiado set nome_beneficiado=@nome_beneficiado, cpf_beneficiado=@cpf_beneficiado, endereço_beneficiado=@endereço_beneficiado, email_beneficiado=@email_beneficiado, senha_beneficiado=@senha_beneficiado, dataNascimento_beneficiado=@dataNascimento_beneficiado, telefone_beneficiado=@telefone_beneficiado, nivelGraduaçao_beneficiado=@nivelGraduaçao_beneficiado, genero_beneficiado=@genero_beneficiado, perguntaSegurança_beneficiado=@perguntaSegurança_beneficiado, emquepossoteajuda_beneficiado=@emquepossoteajuda_beneficiado where idbeneficiado=@idbeneficiado;";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@idbeneficiado", txt_ID.Text);
                comando.Parameters.AddWithValue("@nome_beneficiado", txtNome.Text);
                comando.Parameters.AddWithValue("@cpf_beneficiado", txtCPF.Text);
                comando.Parameters.AddWithValue("@endereço_beneficiado", txtEndereco.Text);
                comando.Parameters.AddWithValue("@email_beneficiado", txtEmail.Text);
                comando.Parameters.AddWithValue("@senha_beneficiado", txtSenha.Text);
                comando.Parameters.AddWithValue("@dataNascimento_beneficiado", txtDTNac.Text);
                comando.Parameters.AddWithValue("@telefone_beneficiado", txtTelefone.Text);
                comando.Parameters.AddWithValue("@nivelGraduaçao_beneficiado", txtEscolaridade.Text);
                comando.Parameters.AddWithValue("@genero_beneficiado", txtGenero.Text);
                comando.Parameters.AddWithValue("@perguntaSegurança_beneficiado", txt_seguranca.Text);
                comando.Parameters.AddWithValue("emquepossoteajuda_beneficiado", txt_ajuda.Text);
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

        private void btn_Excluir2_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server = localhost; Database = prjteste; Uid = root; Pwd = uzumaki031;");

                strSQL = "DELETE FROM beneficiado WHERE idbeneficiado= @idbeneficiado";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@idbeneficiado", txt_ID.Text);

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

        private void btn_Consultar2_Click(object sender, EventArgs e)
        {

            try
            {
                conexao = new MySqlConnection("Server = localhost; Database = prjteste; Uid = root; Pwd = uzumaki031;");

                strSQL = "select * from beneficiado WHERE idbeneficiado= @idbeneficiado";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@idbeneficiado", txt_ID.Text);

                conexao.Open();

                dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    txtNome.Text = Convert.ToString(dr["nome_beneficiado"]);
                    txtCPF.Text = Convert.ToString(dr["cpf_beneficiado"]);
                    txtEndereco.Text = Convert.ToString(dr["endereço_beneficiado"]);
                    txtEmail.Text = Convert.ToString(dr["email_beneficiado"]);
                    txtSenha.Text = Convert.ToString(dr["senha_beneficiado"]);
                    txtDTNac.Text = Convert.ToString(dr["dataNascimento_beneficiado"]);
                    txtTelefone.Text = Convert.ToString(dr["telefone_beneficiado"]);
                    txtEscolaridade.Text = Convert.ToString(dr["nivelGraduaçao_beneficiado"]);
                    txtGenero.Text = Convert.ToString(dr["genero_beneficiado"]);
                    txt_seguranca.Text = Convert.ToString(dr["perguntaSegurança_beneficiado"]);
                    txt_ajuda.Text = Convert.ToString(dr["emquepossoteajuda_beneficiado"]);
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

        private void btn_exibir2_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server = localhost; Database = prjteste; Uid = root; Pwd = uzumaki031;");

                strSQL = "SELECT * FROM beneficiado";

                da = new MySqlDataAdapter(strSQL, conexao);

                DataTable dt = new DataTable();

                da.Fill(dt);

                data1.DataSource = dt;
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

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
    }
    
    

        
    
    

