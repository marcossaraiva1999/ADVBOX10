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
    public partial class frmBuscarPagar : Form
    {
        public frmBuscarPagar()
        {
            InitializeComponent();
        }

        private void frmBuscarPagar_Load(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(@"Data Source=desktop-08c2voq\sqlexpress;Initial Catalog=comandosoft;Integrated Security=True");

            conexao.Open();

            //criando o select e o objeto de consulta
            string sql = "select * from tb_cliente";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Connection = conexao;
            cmd.CommandText = sql;

            // cria o dataadapter...
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            // preenche o dataset...
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            dataGridView1.DataSource = dataSet;
            dataGridView1.DataMember = dataSet.Tables[0].TableName;
            conexao.Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //SELECIONAR NA GRADE
            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //FORM EDITOR SÓ SERÁ EXECUTADO SE TIVER ALGO SELECIONADO NA GRADE
            if (txtId.Text != "")
            {
                frmReceber receber = new frmReceber(txtId.Text);
                receber.Show();
            }
            else
            {
                MessageBox.Show("ERRO: NENHUM CLIENTE SELECIONADO!", "TENTE NOVAMENTE");
            }
        }
    }
}
