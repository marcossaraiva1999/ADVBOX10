namespace ADVBOX
{
    partial class frmBuscarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarCliente));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualificDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadocivilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processoatualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.antecedentesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sistemaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colaboradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secretarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbclienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetClientes = new ADVBOX.DataSetClientes();
            this.tb_clienteTableAdapter = new ADVBOX.DataSetClientesTableAdapters.tb_clienteTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbclienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.rgDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.nascimentoDataGridViewTextBoxColumn,
            this.paiDataGridViewTextBoxColumn,
            this.maeDataGridViewTextBoxColumn,
            this.qualificDataGridViewTextBoxColumn,
            this.estadocivilDataGridViewTextBoxColumn,
            this.processosDataGridViewTextBoxColumn,
            this.processoatualDataGridViewTextBoxColumn,
            this.antecedentesDataGridViewTextBoxColumn,
            this.sistemaDataGridViewTextBoxColumn,
            this.situacaoDataGridViewTextBoxColumn,
            this.colaboradorDataGridViewTextBoxColumn,
            this.secretarioDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.comissaoDataGridViewTextBoxColumn,
            this.entradaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbclienteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 391);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rgDataGridViewTextBoxColumn
            // 
            this.rgDataGridViewTextBoxColumn.DataPropertyName = "Rg";
            this.rgDataGridViewTextBoxColumn.HeaderText = "RG";
            this.rgDataGridViewTextBoxColumn.Name = "rgDataGridViewTextBoxColumn";
            this.rgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            this.cpfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nascimentoDataGridViewTextBoxColumn
            // 
            this.nascimentoDataGridViewTextBoxColumn.DataPropertyName = "nascimento";
            this.nascimentoDataGridViewTextBoxColumn.HeaderText = "Data de Nascimento";
            this.nascimentoDataGridViewTextBoxColumn.Name = "nascimentoDataGridViewTextBoxColumn";
            this.nascimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paiDataGridViewTextBoxColumn
            // 
            this.paiDataGridViewTextBoxColumn.DataPropertyName = "pai";
            this.paiDataGridViewTextBoxColumn.HeaderText = "Pai";
            this.paiDataGridViewTextBoxColumn.Name = "paiDataGridViewTextBoxColumn";
            this.paiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maeDataGridViewTextBoxColumn
            // 
            this.maeDataGridViewTextBoxColumn.DataPropertyName = "mae";
            this.maeDataGridViewTextBoxColumn.HeaderText = "Mãe";
            this.maeDataGridViewTextBoxColumn.Name = "maeDataGridViewTextBoxColumn";
            this.maeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qualificDataGridViewTextBoxColumn
            // 
            this.qualificDataGridViewTextBoxColumn.DataPropertyName = "qualific";
            this.qualificDataGridViewTextBoxColumn.HeaderText = "Qualificação";
            this.qualificDataGridViewTextBoxColumn.Name = "qualificDataGridViewTextBoxColumn";
            this.qualificDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadocivilDataGridViewTextBoxColumn
            // 
            this.estadocivilDataGridViewTextBoxColumn.DataPropertyName = "estado_civil";
            this.estadocivilDataGridViewTextBoxColumn.HeaderText = "Estado Civil";
            this.estadocivilDataGridViewTextBoxColumn.Name = "estadocivilDataGridViewTextBoxColumn";
            this.estadocivilDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // processosDataGridViewTextBoxColumn
            // 
            this.processosDataGridViewTextBoxColumn.DataPropertyName = "processos";
            this.processosDataGridViewTextBoxColumn.HeaderText = "Processos";
            this.processosDataGridViewTextBoxColumn.Name = "processosDataGridViewTextBoxColumn";
            this.processosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // processoatualDataGridViewTextBoxColumn
            // 
            this.processoatualDataGridViewTextBoxColumn.DataPropertyName = "processo_atual";
            this.processoatualDataGridViewTextBoxColumn.HeaderText = "Processo Atual";
            this.processoatualDataGridViewTextBoxColumn.Name = "processoatualDataGridViewTextBoxColumn";
            this.processoatualDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // antecedentesDataGridViewTextBoxColumn
            // 
            this.antecedentesDataGridViewTextBoxColumn.DataPropertyName = "antecedentes";
            this.antecedentesDataGridViewTextBoxColumn.HeaderText = "Antecedentes";
            this.antecedentesDataGridViewTextBoxColumn.Name = "antecedentesDataGridViewTextBoxColumn";
            this.antecedentesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sistemaDataGridViewTextBoxColumn
            // 
            this.sistemaDataGridViewTextBoxColumn.DataPropertyName = "sistema";
            this.sistemaDataGridViewTextBoxColumn.HeaderText = "Sistema";
            this.sistemaDataGridViewTextBoxColumn.Name = "sistemaDataGridViewTextBoxColumn";
            this.sistemaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // situacaoDataGridViewTextBoxColumn
            // 
            this.situacaoDataGridViewTextBoxColumn.DataPropertyName = "situacao";
            this.situacaoDataGridViewTextBoxColumn.HeaderText = "Situação";
            this.situacaoDataGridViewTextBoxColumn.Name = "situacaoDataGridViewTextBoxColumn";
            this.situacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colaboradorDataGridViewTextBoxColumn
            // 
            this.colaboradorDataGridViewTextBoxColumn.DataPropertyName = "colaborador";
            this.colaboradorDataGridViewTextBoxColumn.HeaderText = "Colaborador";
            this.colaboradorDataGridViewTextBoxColumn.Name = "colaboradorDataGridViewTextBoxColumn";
            this.colaboradorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // secretarioDataGridViewTextBoxColumn
            // 
            this.secretarioDataGridViewTextBoxColumn.DataPropertyName = "secretario";
            this.secretarioDataGridViewTextBoxColumn.HeaderText = "Secretário(a)";
            this.secretarioDataGridViewTextBoxColumn.Name = "secretarioDataGridViewTextBoxColumn";
            this.secretarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // comissaoDataGridViewTextBoxColumn
            // 
            this.comissaoDataGridViewTextBoxColumn.DataPropertyName = "comissao";
            this.comissaoDataGridViewTextBoxColumn.HeaderText = "Comissão";
            this.comissaoDataGridViewTextBoxColumn.Name = "comissaoDataGridViewTextBoxColumn";
            this.comissaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // entradaDataGridViewTextBoxColumn
            // 
            this.entradaDataGridViewTextBoxColumn.DataPropertyName = "entrada";
            this.entradaDataGridViewTextBoxColumn.HeaderText = "Entrada";
            this.entradaDataGridViewTextBoxColumn.Name = "entradaDataGridViewTextBoxColumn";
            this.entradaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tbclienteBindingSource
            // 
            this.tbclienteBindingSource.DataMember = "tb_cliente";
            this.tbclienteBindingSource.DataSource = this.dataSetClientes;
            // 
            // dataSetClientes
            // 
            this.dataSetClientes.DataSetName = "DataSetClientes";
            this.dataSetClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_clienteTableAdapter
            // 
            this.tb_clienteTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(549, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "ABRIR CADASTRO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(168, 414);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(375, 20);
            this.txtNome.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "BUSCAR CLIENTE:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(117, 414);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(45, 20);
            this.txtID.TabIndex = 4;
            // 
            // frmBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "frmBuscarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADVBOX - BUSCAR CLIENTE";
            this.Load += new System.EventHandler(this.frmBuscarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbclienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetClientes dataSetClientes;
        private System.Windows.Forms.BindingSource tbclienteBindingSource;
        private DataSetClientesTableAdapters.tb_clienteTableAdapter tb_clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualificDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadocivilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn processosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn processoatualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn antecedentesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sistemaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colaboradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secretarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comissaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
    }
}