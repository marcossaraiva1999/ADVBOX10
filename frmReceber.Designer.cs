namespace ADVBOX
{
    partial class frmReceber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReceber));
            this.receberDataSet = new ADVBOX.receberDataSet();
            this.tbclienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_clienteTableAdapter = new ADVBOX.receberDataSetTableAdapters.tb_clienteTableAdapter();
            this.txtReceber = new System.Windows.Forms.TextBox();
            this.txtComissao = new System.Windows.Forms.TextBox();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReceber = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIDE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtProcessos = new System.Windows.Forms.TextBox();
            this.txtPatual = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRestante = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.receberDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbclienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // receberDataSet
            // 
            this.receberDataSet.DataSetName = "receberDataSet";
            this.receberDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbclienteBindingSource
            // 
            this.tbclienteBindingSource.DataMember = "tb_cliente";
            this.tbclienteBindingSource.DataSource = this.receberDataSet;
            // 
            // tb_clienteTableAdapter
            // 
            this.tb_clienteTableAdapter.ClearBeforeFill = true;
            // 
            // txtReceber
            // 
            this.txtReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtReceber.Location = new System.Drawing.Point(358, 172);
            this.txtReceber.Name = "txtReceber";
            this.txtReceber.Size = new System.Drawing.Size(156, 29);
            this.txtReceber.TabIndex = 1;
            // 
            // txtComissao
            // 
            this.txtComissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComissao.Location = new System.Drawing.Point(191, 172);
            this.txtComissao.Name = "txtComissao";
            this.txtComissao.Size = new System.Drawing.Size(156, 29);
            this.txtComissao.TabIndex = 2;
            // 
            // txtEntrada
            // 
            this.txtEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntrada.Location = new System.Drawing.Point(23, 172);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(156, 29);
            this.txtEntrada.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ENTRADA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "COMISSÃO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Á RECEBER:";
            // 
            // btnReceber
            // 
            this.btnReceber.BackColor = System.Drawing.Color.SeaGreen;
            this.btnReceber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReceber.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReceber.Location = new System.Drawing.Point(358, 216);
            this.btnReceber.Name = "btnReceber";
            this.btnReceber.Size = new System.Drawing.Size(156, 40);
            this.btnReceber.TabIndex = 7;
            this.btnReceber.Text = "RECEBER";
            this.btnReceber.UseVisualStyleBackColor = false;
            this.btnReceber.Click += new System.EventHandler(this.btnReceber_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(128, 26);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(389, 20);
            this.txtNome.TabIndex = 8;
            // 
            // txtIDE
            // 
            this.txtIDE.Enabled = false;
            this.txtIDE.Location = new System.Drawing.Point(23, 26);
            this.txtIDE.Name = "txtIDE";
            this.txtIDE.Size = new System.Drawing.Size(99, 20);
            this.txtIDE.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "CLIENTE:";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(19, 442);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(156, 29);
            this.txtValor.TabIndex = 12;
            this.txtValor.Visible = false;
            // 
            // txtProcessos
            // 
            this.txtProcessos.Location = new System.Drawing.Point(23, 95);
            this.txtProcessos.Name = "txtProcessos";
            this.txtProcessos.Size = new System.Drawing.Size(236, 20);
            this.txtProcessos.TabIndex = 13;
            // 
            // txtPatual
            // 
            this.txtPatual.Location = new System.Drawing.Point(265, 95);
            this.txtPatual.Name = "txtPatual";
            this.txtPatual.Size = new System.Drawing.Size(144, 20);
            this.txtPatual.TabIndex = 14;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(415, 95);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(99, 20);
            this.txtValue.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "PROCESSOS:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "PROCESSO ATUAL:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(412, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "VALOR:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "DINHEIRO",
            "CARTÃO"});
            this.comboBox1.Location = new System.Drawing.Point(159, 227);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "PAGAMENTO EM:";
            // 
            // txtRestante
            // 
            this.txtRestante.Enabled = false;
            this.txtRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtRestante.Location = new System.Drawing.Point(23, 253);
            this.txtRestante.Name = "txtRestante";
            this.txtRestante.Size = new System.Drawing.Size(117, 20);
            this.txtRestante.TabIndex = 21;
            this.txtRestante.Visible = false;
            // 
            // frmReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 276);
            this.Controls.Add(this.txtRestante);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.txtPatual);
            this.Controls.Add(this.txtProcessos);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIDE);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnReceber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.txtComissao);
            this.Controls.Add(this.txtReceber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(566, 315);
            this.MinimumSize = new System.Drawing.Size(566, 315);
            this.Name = "frmReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RECEBER - ADVBOX";
            this.Load += new System.EventHandler(this.frmReceber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.receberDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbclienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private receberDataSet receberDataSet;
        private System.Windows.Forms.BindingSource tbclienteBindingSource;
        private receberDataSetTableAdapters.tb_clienteTableAdapter tb_clienteTableAdapter;
        private System.Windows.Forms.TextBox txtReceber;
        private System.Windows.Forms.TextBox txtComissao;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReceber;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtIDE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtProcessos;
        private System.Windows.Forms.TextBox txtPatual;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRestante;
    }
}