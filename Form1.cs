using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADVBOX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(string Valor,  string Login)
        {
            InitializeComponent();
            lblTipo.Text = Valor;
            lblLogin.Text = Login;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //ABRIR FORM PARA CADASTRAR CLIENTES
            frmInserirCliente iClientes = new frmInserirCliente(lblLogin.Text);
            iClientes.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (lblTipo.Text != "ADMINISTRADOR")
            {
                btnUser.Visible = false;
            }
            else
            {
                btnUser.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            frmCustodia nCusodia = new frmCustodia();
            nCusodia.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmBuscarCliente buscarCliente = new frmBuscarCliente();
            buscarCliente.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmBuscarCustodia buscarCustodia = new frmBuscarCustodia();
            buscarCustodia.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmBuscarPagar receber = new frmBuscarPagar();
            receber.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmCadastraSecret login = new frmCadastraSecret();
            login.Show();
        }
    }
}
