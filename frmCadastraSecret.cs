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
    public partial class frmCadastraSecret : Form
    {
        public frmCadastraSecret()
        {
            InitializeComponent();
        }

        private void frmCadastraSecret_Load(object sender, EventArgs e)
        {

        }

        private void btnPronto_Click(object sender, EventArgs e)
        {
            if (cboNivel.Text == "SECRETARIO(A)") {
                string strcon = @"Data Source=desktop-08c2voq\sqlexpress;Initial Catalog=comandosoft;Integrated Security=True";
                SqlConnection con = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand("INSERT INTO tb_secretario(usuario, senha) VALUES ('" + txtUser.Text + "', '" + txtSenha.Text + "')", con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Secretario cadastrado com sucesso!", "ADVBOX - Secretario");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro " + ex.Message);
                    throw;
                }
                finally
                {
                    con.Close();
                }
            }else if (cboNivel.Text == "ADMINISTRADOR")
            {
                string strcon = @"Data Source=desktop-08c2voq\sqlexpress;Initial Catalog=comandosoft;Integrated Security=True";
                SqlConnection con = new SqlConnection(strcon);
                SqlCommand cmd = new SqlCommand("INSERT INTO tb_admin(administrador, senha) VALUES ('" + txtUser.Text + "', '" + txtSenha.Text + "')", con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Administrador cadastrado com sucesso!", "ADVBOX - Secretario");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro " + ex.Message);
                    throw;
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
