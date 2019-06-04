using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADVBOX
{
    public partial class frmEditarCustodia : Form
    {
        public frmEditarCustodia()
        {
            InitializeComponent();
        }
        public frmEditarCustodia(string valor)
        {
            InitializeComponent();
            txtId.Text = valor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ATUALIZAÇÃO DE CADASTRO NO BANCO DE DADOS
            SqlConnection con = new SqlConnection(@"Data Source=desktop-08c2voq\sqlexpress;Initial Catalog=comandosoft;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("UPDATE tb_custodia SET Nome=@nome, Rg=@rg, cpf=@cpf, nascimento=@nascimento, pai=@pai, mae=@mae, qualificacoes=@qualific, estcivil=@estcivil, telefone1=@tel1, telefone2=@tel2, endereco=@endereco, numero=@numero, bairro=@bairro, complemento=@complemento, referencia=@referencia, historico=@historico, valor=@valor, entrada=@entrada WHERE Id= @ID", con);
            cmd.CommandType = CommandType.Text;

            //PARAMETROS PARA ALTERAÇÃO 
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@rg", txtRg.Text);
            cmd.Parameters.AddWithValue("@cpf", txtCPF.Text);
            cmd.Parameters.AddWithValue("@nascimento", txtNascimento.Text);
            cmd.Parameters.AddWithValue("@pai", txtPai.Text);
            cmd.Parameters.AddWithValue("@mae", txtMae.Text);
            cmd.Parameters.AddWithValue("@qualific", cbQualificacao.Text);
            cmd.Parameters.AddWithValue("@estcivil", cbEstadoCivil.Text);
            cmd.Parameters.AddWithValue("@tel1", mskTel1.Text);
            cmd.Parameters.AddWithValue("@tel2", mskTel2.Text);
            cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
            cmd.Parameters.AddWithValue("@numero", txtNumero.Text);
            cmd.Parameters.AddWithValue("@bairro", txtBairro.Text);
            cmd.Parameters.AddWithValue("@complemento", txtComplemento.Text);
            cmd.Parameters.AddWithValue("@referencia", txtReferencia.Text);
            cmd.Parameters.AddWithValue("@historico", richHistorico.Text);
            cmd.Parameters.AddWithValue("@valor", txtValor.Text);
            cmd.Parameters.AddWithValue("@entrada", txtEntrada.Text);
            cmd.Parameters.AddWithValue("@ID", txtIDE.Text);

            //ABRIR CONEXÃO
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Custódia atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void frmEditarCustodia_Load(object sender, EventArgs e)
        {
            //SELEÇÃO DO CLIENTE VIA ID DO BANCO DE DADOS
            string sql = "SELECT * FROM tb_custodia WHERE Id=" + txtId.Text;

            SqlConnection con = new SqlConnection(@"Data Source=desktop-08c2voq\sqlexpress;Initial Catalog=comandosoft;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            con.Open();

            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    //CARREGAMENTO DE INFORMAÇÃO NOS COMPONENTES
                    txtNome.Focus();
                    txtIDE.Text = reader[0].ToString();
                    txtNome.Text = reader[1].ToString();
                    txtRg.Text = reader[2].ToString();
                    txtCPF.Text = reader[3].ToString();
                    txtNascimento.Text = reader[4].ToString();
                    txtPai.Text = reader[5].ToString();
                    txtMae.Text = reader[6].ToString();
                    cbQualificacao.Text = reader[7].ToString();
                    cbEstadoCivil.Text = reader[8].ToString();
                    mskTel1.Text = reader[9].ToString();
                    mskTel2.Text = reader[10].ToString();
                    txtEndereco.Text = reader[11].ToString();
                    txtNumero.Text = reader[12].ToString();
                    txtBairro.Text = reader[13].ToString();
                    txtComplemento.Text = reader[14].ToString();
                    txtReferencia.Text = reader[15].ToString();
                    richHistorico.Text = reader[16].ToString();
                    txtValor.Text = reader[17].ToString();
                    txtEntrada.Text = reader[18].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }

            txtId.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MENSAGEM DE CONFIRMAÇÃO PARA EXCLUIR CLIENTE DO BANCO DE DADOS
            DialogResult confirm = MessageBox.Show("Deseja Deletar esta Custódia?", "Deletar Custódia", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

            if (confirm.ToString().ToUpper() == "YES")
            {

                string sql = "DELETE FROM tb_custodia WHERE Id=" + txtIDE.Text;
                SqlConnection con = new SqlConnection(@"Data Source=desktop-08c2voq\sqlexpress;Initial Catalog=comandosoft;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro excluído com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }

            }
        }
    }
    }

