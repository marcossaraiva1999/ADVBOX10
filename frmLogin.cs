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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "ADMINISTRADOR")
            {
                //SELEÇÃO DO CLIENTE VIA ID DO BANCO DE DADOS
                string sql = "SELECT * FROM tb_admin WHERE Id=" + txtId.Text;

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
                        if (txtUser.Text == reader[1].ToString())
                        {
                            if (txtPass.Text == reader[2].ToString())
                            {
                                MessageBox.Show("LOGIN ACEITO","SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Form1 iniciar = new Form1(comboBox1.Text, txtUser.Text);
                                iniciar.Show();
                                this.Hide();
                            }else if (txtPass.Text != reader[2].ToString())
                            {
                                MessageBox.Show("SENHA INCORRETA");
                            }
                        } else {
                            MessageBox.Show("USUARIO OU SENHA INCORRETO");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro" + ex.ToString());

                }
                finally
                {
                    con.Close();
                }
            }else if (comboBox1.Text == "SECRETARIO(A)")
            {
                //SELEÇÃO DO CLIENTE VIA ID DO BANCO DE DADOS
                string sql = "SELECT * FROM tb_secretario WHERE Id=" + txtId.Text;

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
                        if (txtUser.Text == reader[1].ToString())
                        {
                            if (txtPass.Text == reader[2].ToString())
                            {
                                MessageBox.Show("LOGIN ACEITO", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Form1 iniciar = new Form1(comboBox1.Text, txtUser.Text);
                                iniciar.Show();
                                this.Hide();
                            }
                            else if (txtPass.Text != reader[2].ToString())
                            {
                                MessageBox.Show("SENHA INCORRETA");
                            }
                        }
                        else
                        {
                            MessageBox.Show("USUARIO OU SENHA INCORRETO");
                        }

                    }

                    /**Form1 chamar = new Form1();
                    chamar.Show();
                    this.Hide();**/
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro" + ex.ToString());

                }
                finally
                {
                    con.Close();
                }
            }
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
