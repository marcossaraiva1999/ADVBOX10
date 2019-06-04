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
    public partial class frmCustodia : Form
    {
        public frmCustodia()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strcon = @"Data Source=desktop-08c2voq\sqlexpress;Initial Catalog=comandosoft;Integrated Security=True";
            SqlConnection con = new SqlConnection(strcon);
            SqlCommand cmd = new SqlCommand("INSERT INTO tb_custodia(Nome, Rg, cpf, nascimento, pai, mae, qualificacoes, estcivil, telefone1, telefone2, endereco, numero, bairro, complemento, referencia, historico, valor, entrada) VALUES ('" + txtNome.Text + "', '" + txtRg.Text + "', '" + txtCPF.Text + "', '" + txtNascimento.Text + "', '" + txtPai.Text + "' , '" + txtMae.Text + "', '" + cbQualificacao.Text + "', '" + cbEstadoCivil.Text + "', '" + mskTel1.Text + "', '" + mskTel2.Text + "', '" + txtEndereco.Text + "', '" + txtNumero.Text + "', '" + txtBairro.Text + "', '" + txtComplemento.Text + "', '" + txtReferencia.Text + "', '" + richHistorico.Text + "','" + txtValor.Text + "', '" + txtEntrada.Text + "')", con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Salvo com sucesso!", "ADVBOX - CUSTÓDIA");
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

        private void txtRg_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
