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
using clientes.DAL;

namespace ADVBOX
{
    public partial class frmInserirCliente : Form
    {

        public frmInserirCliente()
        {
            InitializeComponent();
        }
        public frmInserirCliente(string Nome)
        {
            InitializeComponent();
            lblSecretario.Text = Nome;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strcon = @"Data Source=desktop-08c2voq\sqlexpress;Initial Catalog=comandosoft;Integrated Security=True";
            SqlConnection con = new SqlConnection(strcon); 
            SqlCommand cmd = new SqlCommand("INSERT INTO tb_cliente(Nome, Rg, cpf, nascimento, pai, mae, qualific, estado_civil, processos, processo_atual, antecedentes, sistema, situacao, colaborador, secretario, valor, comissao, entrada) VALUES ('" + txtNome.Text + "', '"+ txtRg.Text +"', '"+ txtCPF.Text + "', '" + txtNascimento.Text + "', '" + txtPai.Text + "' , '" + txtMae.Text + "', '" + cbQualificacao.Text + "', '" + cbEstadoCivil.Text + "', '" + txtProcessos.Text + "', '" + txtProcessAtual.Text + "', '" + cbAntecedentes.Text + "', '" + cbSistema.Text + "', '" + cbSituacao.Text + "', '" + cbColaborador.Text + "', '" + lblSecretario.Text + "', '" + txtValor.Text + "','" + txtComissao.Text + "', '" + txtEntrada.Text +"')", con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente Cadastrador com sucesso!", "ADVBOX - CLIENTE");
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frmInserirCliente_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
