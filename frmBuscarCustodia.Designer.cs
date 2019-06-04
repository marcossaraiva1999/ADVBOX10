namespace ADVBOX
{
    partial class frmBuscarCustodia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarCustodia));
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualificacoesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estcivilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complementoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcustodiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comandosoftDataSet1 = new ADVBOX.comandosoftDataSet1();
            this.tb_custodiaTableAdapter = new ADVBOX.comandosoftDataSet1TableAdapters.tb_custodiaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcustodiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandosoftDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(129, 414);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(35, 20);
            this.txtID.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "BUSCAR CUSTÓDIA:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(170, 414);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(375, 20);
            this.txtNome.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(551, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "ABRIR CUSTÓDIA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.qualificacoesDataGridViewTextBoxColumn,
            this.estcivilDataGridViewTextBoxColumn,
            this.telefone1DataGridViewTextBoxColumn,
            this.telefone2DataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.bairroDataGridViewTextBoxColumn,
            this.complementoDataGridViewTextBoxColumn,
            this.referenciaDataGridViewTextBoxColumn,
            this.historicoDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.entradaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbcustodiaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 391);
            this.dataGridView1.TabIndex = 5;
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
            this.rgDataGridViewTextBoxColumn.HeaderText = "Rg";
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
            this.nascimentoDataGridViewTextBoxColumn.HeaderText = "Nascimento";
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
            // qualificacoesDataGridViewTextBoxColumn
            // 
            this.qualificacoesDataGridViewTextBoxColumn.DataPropertyName = "qualificacoes";
            this.qualificacoesDataGridViewTextBoxColumn.HeaderText = "Qualificação";
            this.qualificacoesDataGridViewTextBoxColumn.Name = "qualificacoesDataGridViewTextBoxColumn";
            this.qualificacoesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estcivilDataGridViewTextBoxColumn
            // 
            this.estcivilDataGridViewTextBoxColumn.DataPropertyName = "estcivil";
            this.estcivilDataGridViewTextBoxColumn.HeaderText = "Estado Civil";
            this.estcivilDataGridViewTextBoxColumn.Name = "estcivilDataGridViewTextBoxColumn";
            this.estcivilDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefone1DataGridViewTextBoxColumn
            // 
            this.telefone1DataGridViewTextBoxColumn.DataPropertyName = "telefone1";
            this.telefone1DataGridViewTextBoxColumn.HeaderText = "Telefone 1";
            this.telefone1DataGridViewTextBoxColumn.Name = "telefone1DataGridViewTextBoxColumn";
            this.telefone1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefone2DataGridViewTextBoxColumn
            // 
            this.telefone2DataGridViewTextBoxColumn.DataPropertyName = "telefone2";
            this.telefone2DataGridViewTextBoxColumn.HeaderText = "Telefone 2";
            this.telefone2DataGridViewTextBoxColumn.Name = "telefone2DataGridViewTextBoxColumn";
            this.telefone2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            this.enderecoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Número";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bairroDataGridViewTextBoxColumn
            // 
            this.bairroDataGridViewTextBoxColumn.DataPropertyName = "bairro";
            this.bairroDataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            this.bairroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // complementoDataGridViewTextBoxColumn
            // 
            this.complementoDataGridViewTextBoxColumn.DataPropertyName = "complemento";
            this.complementoDataGridViewTextBoxColumn.HeaderText = "Complemento";
            this.complementoDataGridViewTextBoxColumn.Name = "complementoDataGridViewTextBoxColumn";
            this.complementoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // referenciaDataGridViewTextBoxColumn
            // 
            this.referenciaDataGridViewTextBoxColumn.DataPropertyName = "referencia";
            this.referenciaDataGridViewTextBoxColumn.HeaderText = "Referência";
            this.referenciaDataGridViewTextBoxColumn.Name = "referenciaDataGridViewTextBoxColumn";
            this.referenciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // historicoDataGridViewTextBoxColumn
            // 
            this.historicoDataGridViewTextBoxColumn.DataPropertyName = "historico";
            this.historicoDataGridViewTextBoxColumn.HeaderText = "Histórico";
            this.historicoDataGridViewTextBoxColumn.Name = "historicoDataGridViewTextBoxColumn";
            this.historicoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor Total";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // entradaDataGridViewTextBoxColumn
            // 
            this.entradaDataGridViewTextBoxColumn.DataPropertyName = "entrada";
            this.entradaDataGridViewTextBoxColumn.HeaderText = "Entrada";
            this.entradaDataGridViewTextBoxColumn.Name = "entradaDataGridViewTextBoxColumn";
            this.entradaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tbcustodiaBindingSource
            // 
            this.tbcustodiaBindingSource.DataMember = "tb_custodia";
            this.tbcustodiaBindingSource.DataSource = this.comandosoftDataSet1;
            // 
            // comandosoftDataSet1
            // 
            this.comandosoftDataSet1.DataSetName = "comandosoftDataSet1";
            this.comandosoftDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_custodiaTableAdapter
            // 
            this.tb_custodiaTableAdapter.ClearBeforeFill = true;
            // 
            // frmBuscarCustodia
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
            this.Name = "frmBuscarCustodia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADVBOX - BUSCAR CUSTÓDIA";
            this.Load += new System.EventHandler(this.frmBuscarCustodia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcustodiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comandosoftDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private comandosoftDataSet1 comandosoftDataSet1;
        private System.Windows.Forms.BindingSource tbcustodiaBindingSource;
        private comandosoftDataSet1TableAdapters.tb_custodiaTableAdapter tb_custodiaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualificacoesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estcivilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn complementoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn historicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entradaDataGridViewTextBoxColumn;
    }
}