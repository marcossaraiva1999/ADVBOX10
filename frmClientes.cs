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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ABRIR FORMULÁRIO DE CADASTRO DE NOVO CLIENTE
            frmInserirCliente InserirCliente = new frmInserirCliente();
            InserirCliente.Show();
            //FECHAR FORM ANTERIOR
            this.Hide();
        }
    }
}
