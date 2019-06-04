namespace ADVBOX
{
    partial class frmCadastraSecret
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastraSecret));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPronto = new System.Windows.Forms.Button();
            this.cboNivel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUÁRIO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SENHA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CONFIRMAR SENHA:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(15, 41);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(257, 20);
            this.txtUser.TabIndex = 3;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(15, 92);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(257, 20);
            this.txtSenha.TabIndex = 4;
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.Location = new System.Drawing.Point(15, 146);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.Size = new System.Drawing.Size(257, 20);
            this.txtConfirmar.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "NIVEL:";
            // 
            // btnPronto
            // 
            this.btnPronto.Location = new System.Drawing.Point(15, 243);
            this.btnPronto.MaximumSize = new System.Drawing.Size(260, 33);
            this.btnPronto.MinimumSize = new System.Drawing.Size(260, 33);
            this.btnPronto.Name = "btnPronto";
            this.btnPronto.Size = new System.Drawing.Size(260, 33);
            this.btnPronto.TabIndex = 7;
            this.btnPronto.Text = "PRONTO";
            this.btnPronto.UseVisualStyleBackColor = true;
            this.btnPronto.Click += new System.EventHandler(this.btnPronto_Click);
            // 
            // cboNivel
            // 
            this.cboNivel.FormattingEnabled = true;
            this.cboNivel.Items.AddRange(new object[] {
            "SECRETARIO(A)",
            "ADMINISTRADOR"});
            this.cboNivel.Location = new System.Drawing.Point(15, 200);
            this.cboNivel.Name = "cboNivel";
            this.cboNivel.Size = new System.Drawing.Size(257, 21);
            this.cboNivel.TabIndex = 8;
            // 
            // frmCadastraSecret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 288);
            this.Controls.Add(this.cboNivel);
            this.Controls.Add(this.btnPronto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtConfirmar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(305, 327);
            this.MinimumSize = new System.Drawing.Size(305, 327);
            this.Name = "frmCadastraSecret";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRAR NOVO";
            this.Load += new System.EventHandler(this.frmCadastraSecret_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPronto;
        private System.Windows.Forms.ComboBox cboNivel;
    }
}