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
    public partial class frmEditarCliente : Form
    {
        public frmEditarCliente()
        {
            InitializeComponent();
        }
        public frmEditarCliente(string Valor)
        {
            InitializeComponent();
            txtId.Text = Valor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MENSAGEM DE CONFIRMAÇÃO PARA EXCLUIR CLIENTE DO BANCO DE DADOS
            DialogResult confirm = MessageBox.Show("Deseja Deletar este Cliente?", "Deletar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

            if (confirm.ToString().ToUpper() == "YES") {

                string sql = "DELETE FROM tb_cliente WHERE Id=" + txtIDENT.Text;
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

        private void frmEditarCliente_Load(object sender, EventArgs e)
        {
            //SELEÇÃO DO CLIENTE VIA ID DO BANCO DE DADOS
            string sql = "SELECT * FROM tb_cliente WHERE Id=" + txtId.Text;

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
                    txtIDENT.Text = reader[0].ToString();
                    txtNome.Text = reader[1].ToString();
                    txtRg.Text = reader[2].ToString();
                    txtCPF.Text = reader[3].ToString();
                    txtNascimento.Text = reader[4].ToString();
                    txtPai.Text = reader[5].ToString();
                    txtMae.Text = reader[6].ToString();
                    cbQualificacao.Text = reader[7].ToString();
                    cbEstadoCivil.Text = reader[8].ToString();
                    txtProcessos.Text = reader[9].ToString();
                    txtProcessAtual.Text = reader[10].ToString();
                    cbAntecedentes.Text = reader[11].ToString();
                    cbSistema.Text = reader[12].ToString();
                    cbSituacao.Text = reader[13].ToString();
                    cbColaborador.Text = reader[14].ToString();
                    lblSecretario.Text = reader[15].ToString();
                    txtValor.Text = reader[16].ToString();
                    txtComissao.Text = reader[17].ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            //ATUALIZAÇÃO DE CADASTRO NO BANCO DE DADOS
            SqlConnection con = new SqlConnection(@"Data Source=desktop-08c2voq\sqlexpress;Initial Catalog=comandosoft;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("UPDATE tb_Cliente SET Nome=@nome, Rg=@rg, cpf=@cpf, nascimento=@nascimento, pai=@pai, mae=@mae, qualific=@qualific, estado_civil=@estcivil, processos=@processos, processo_atual=@atual, antecedentes=@antecedentes, sistema=@sistema, situacao=@situacao, colaborador=@colaborador, secretario=@secretario, valor=@valor, comissao=@comissao, entrada=@entrada WHERE Id= @ID", con);
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
            cmd.Parameters.AddWithValue("@processos", txtProcessos.Text);
            cmd.Parameters.AddWithValue("@atual", txtProcessAtual.Text);
            cmd.Parameters.AddWithValue("@antecedentes", cbAntecedentes.Text);
            cmd.Parameters.AddWithValue("@sistema", cbSistema.Text);
            cmd.Parameters.AddWithValue("@situacao", cbSituacao.Text);
            cmd.Parameters.AddWithValue("@colaborador", cbColaborador.Text);
            cmd.Parameters.AddWithValue("@secretario", lblSecretario.Text);
            cmd.Parameters.AddWithValue("@valor", txtValor.Text);
            cmd.Parameters.AddWithValue("@comissao", txtComissao.Text);
            cmd.Parameters.AddWithValue("@entrada", txtEntrada.Text);
            cmd.Parameters.AddWithValue("@Id", txtIDENT.Text);

            //ABRIR CONEXÃO
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Cadastro atualizado com sucesso!");
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
//FINALIZAÇÃO DO CÓDIGO