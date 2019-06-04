namespace ADVBOX
{
    partial class frmBuscarPagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarPagar));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comandosoftDataSet2 = new ADVBOX.comandosoftDataSet2();
            this.tbclienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_clienteTableAdapter = new ADVBOX.comandosoftDataSet2TableAdapters.tb_clienteTableAdapter();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandosoftDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbclienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(501, 326);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // comandosoftDataSet2
            // 
            this.comandosoftDataSet2.DataSetName = "comandosoftDataSet2";
            this.comandosoftDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbclienteBindingSource
            // 
            this.tbclienteBindingSource.DataMember = "tb_cliente";
            this.tbclienteBindingSource.DataSource = this.comandosoftDataSet2;
            // 
            // tb_clienteTableAdapter
            // 
            this.tb_clienteTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 150;
            // 
            // rgDataGridViewTextBoxColumn
            // 
            this.rgDataGridViewTextBoxColumn.DataPropertyName = "Rg";
            this.rgDataGridViewTextBoxColumn.HeaderText = "Rg";
            this.rgDataGridViewTextBoxColumn.Name = "rgDataGridViewTextBoxColumn";
            this.rgDataGridViewTextBoxColumn.ReadOnly = true;
            this.rgDataGridViewTextBoxColumn.Visible = false;
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "cpf";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            this.cpfDataGridViewTextBoxColumn.ReadOnly = true;
            this.cpfDataGridViewTextBoxColumn.Visible = false;
            // 
            // nascimentoDataGridViewTextBoxColumn
            // 
            this.nascimentoDataGridViewTextBoxColumn.DataPropertyName = "nascimento";
            this.nascimentoDataGridViewTextBoxColumn.HeaderText = "nascimento";
            this.nascimentoDataGridViewTextBoxColumn.Name = "nascimentoDataGridViewTextBoxColumn";
            this.nascimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nascimentoDataGridViewTextBoxColumn.Visible = false;
            // 
            // paiDataGridViewTextBoxColumn
            // 
            this.paiDataGridViewTextBoxColumn.DataPropertyName = "pai";
            this.paiDataGridViewTextBoxColumn.HeaderText = "pai";
            this.paiDataGridViewTextBoxColumn.Name = "paiDataGridViewTextBoxColumn";
            this.paiDataGridViewTextBoxColumn.ReadOnly = true;
            this.paiDataGridViewTextBoxColumn.Visible = false;
            // 
            // maeDataGridViewTextBoxColumn
            // 
            this.maeDataGridViewTextBoxColumn.DataPropertyName = "mae";
            this.maeDataGridViewTextBoxColumn.HeaderText = "mae";
            this.maeDataGridViewTextBoxColumn.Name = "maeDataGridViewTextBoxColumn";
            this.maeDataGridViewTextBoxColumn.ReadOnly = true;
            this.maeDataGridViewTextBoxColumn.Visible = false;
            // 
            // qualificDataGridViewTextBoxColumn
            // 
            this.qualificDataGridViewTextBoxColumn.DataPropertyName = "qualific";
            this.qualificDataGridViewTextBoxColumn.HeaderText = "qualific";
            this.qualificDataGridViewTextBoxColumn.Name = "qualificDataGridViewTextBoxColumn";
            this.qualificDataGridViewTextBoxColumn.ReadOnly = true;
            this.qualificDataGridViewTextBoxColumn.Visible = false;
            // 
            // estadocivilDataGridViewTextBoxColumn
            // 
            this.estadocivilDataGridViewTextBoxColumn.DataPropertyName = "estado_civil";
            this.estadocivilDataGridViewTextBoxColumn.HeaderText = "estado_civil";
            this.estadocivilDataGridViewTextBoxColumn.Name = "estadocivilDataGridViewTextBoxColumn";
            this.estadocivilDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadocivilDataGridViewTextBoxColumn.Visible = false;
            // 
            // processosDataGridViewTextBoxColumn
            // 
            this.processosDataGridViewTextBoxColumn.DataPropertyName = "processos";
            this.processosDataGridViewTextBoxColumn.HeaderText = "processos";
            this.processosDataGridViewTextBoxColumn.Name = "processosDataGridViewTextBoxColumn";
            this.processosDataGridViewTextBoxColumn.ReadOnly = true;
            this.processosDataGridViewTextBoxColumn.Visible = false;
            // 
            // processoatualDataGridViewTextBoxColumn
            // 
            this.processoatualDataGridViewTextBoxColumn.DataPropertyName = "processo_atual";
            this.processoatualDataGridViewTextBoxColumn.HeaderText = "processo_atual";
            this.processoatualDataGridViewTextBoxColumn.Name = "processoatualDataGridViewTextBoxColumn";
            this.processoatualDataGridViewTextBoxColumn.ReadOnly = true;
            this.processoatualDataGridViewTextBoxColumn.Visible = false;
            // 
            // antecedentesDataGridViewTextBoxColumn
            // 
            this.antecedentesDataGridViewTextBoxColumn.DataPropertyName = "antecedentes";
            this.antecedentesDataGridViewTextBoxColumn.HeaderText = "antecedentes";
            this.antecedentesDataGridViewTextBoxColumn.Name = "antecedentesDataGridViewTextBoxColumn";
            this.antecedentesDataGridViewTextBoxColumn.ReadOnly = true;
            this.antecedentesDataGridViewTextBoxColumn.Visible = false;
            // 
            // sistemaDataGridViewTextBoxColumn
            // 
            this.sistemaDataGridViewTextBoxColumn.DataPropertyName = "sistema";
            this.sistemaDataGridViewTextBoxColumn.HeaderText = "sistema";
            this.sistemaDataGridViewTextBoxColumn.Name = "sistemaDataGridViewTextBoxColumn";
            this.sistemaDataGridViewTextBoxColumn.ReadOnly = true;
            this.sistemaDataGridViewTextBoxColumn.Visible = false;
            // 
            // situacaoDataGridViewTextBoxColumn
            // 
            this.situacaoDataGridViewTextBoxColumn.DataPropertyName = "situacao";
            this.situacaoDataGridViewTextBoxColumn.HeaderText = "situacao";
            this.situacaoDataGridViewTextBoxColumn.Name = "situacaoDataGridViewTextBoxColumn";
            this.situacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.situacaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // colaboradorDataGridViewTextBoxColumn
            // 
            this.colaboradorDataGridViewTextBoxColumn.DataPropertyName = "colaborador";
            this.colaboradorDataGridViewTextBoxColumn.HeaderText = "colaborador";
            this.colaboradorDataGridViewTextBoxColumn.Name = "colaboradorDataGridViewTextBoxColumn";
            this.colaboradorDataGridViewTextBoxColumn.ReadOnly = true;
            this.colaboradorDataGridViewTextBoxColumn.Visible = false;
            // 
            // secretarioDataGridViewTextBoxColumn
            // 
            this.secretarioDataGridViewTextBoxColumn.DataPropertyName = "secretario";
            this.secretarioDataGridViewTextBoxColumn.HeaderText = "secretario";
            this.secretarioDataGridViewTextBoxColumn.Name = "secretarioDataGridViewTextBoxColumn";
            this.secretarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.secretarioDataGridViewTextBoxColumn.Visible = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SELECIONE PARA RECEBER:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "RECEBER DE :";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(100, 388);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(324, 20);
            this.txtNome.TabIndex = 3;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(430, 386);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(83, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(445, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(68, 20);
            this.txtId.TabIndex = 5;
            // 
            // frmBuscarPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 417);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(541, 456);
            this.MinimumSize = new System.Drawing.Size(541, 456);
            this.Name = "frmBuscarPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUSCAR CLIENTE";
            this.Load += new System.EventHandler(this.frmBuscarPagar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandosoftDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbclienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private comandosoftDataSet2 comandosoftDataSet2;
        private System.Windows.Forms.BindingSource tbclienteBindingSource;
        private comandosoftDataSet2TableAdapters.tb_clienteTableAdapter tb_clienteTableAdapter;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtId;
    }
}