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
    public partial class frmReceber : Form
    {
        public frmReceber()
        {
            InitializeComponent();
        }
        public frmReceber(string Valor)
        {
            InitializeComponent();
            txtIDE.Text = Valor;

        }

        private void frmReceber_Load(object sender, EventArgs e)
        {
                      
            
            //SELEÇÃO DO CLIENTE VIA ID DO BANCO DE DADOS
            string sql = "SELECT * FROM tb_cliente WHERE Id=" + txtIDE.Text;

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
                    txtProcessos.Text = reader[9].ToString();
                    txtPatual.Text = reader[10].ToString();
                    txtValue.Text = reader[16].ToString();
                    txtEntrada.Text = reader[17].ToString();
                    txtComissao.Text = reader[18].ToString();                   
                }
                //OPERAÇÃO
                decimal valor = Convert.ToDecimal(txtValue.Text) - Convert.ToDecimal(txtEntrada.Text) - Convert.ToDecimal(txtComissao.Text);
                txtReceber.Text = valor.ToString();
                decimal resto = Convert.ToDecimal(txtValue.Text) - Convert.ToDecimal(txtEntrada.Text) - Convert.ToDecimal(txtComissao.Text) - Convert.ToDecimal(txtReceber.Text);
                txtRestante.Text = resto.ToString();
                if ( txtRestante.Text == "0" )
                {
                    txtRestante.Text = "NADA CONSTA";
                                    }else if (txtRestante.Text == "0,00")
                {
                    txtRestante.Text = "NADA CONSTA";
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

            txtIDE.Text = "";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnReceber_Click(object sender, EventArgs e)
        {
            if ( comboBox1.Text == "")
            {
                MessageBox.Show("SELECIONE UMA FORMA DE PAGAMENTO!","ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //ATUALIZAÇÃO DE CADASTRO NO BANCO DE DADOS
                SqlConnection con = new SqlConnection(@"Data Source=desktop-08c2voq\sqlexpress;Initial Catalog=comandosoft;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("UPDATE tb_cliente SET valor=@valor WHERE Id= @ID", con);
                cmd.CommandType = CommandType.Text;

                //PARAMETROS PARA ALTERAÇÃO 
                cmd.Parameters.AddWithValue("@valor", txtRestante.Text);
                cmd.Parameters.AddWithValue("@ID", txtIDE.Text);
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
}
