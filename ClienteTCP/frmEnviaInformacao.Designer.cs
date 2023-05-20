namespace ClienteTCP
{
    partial class frmEnviaInformacao
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtip = new System.Windows.Forms.TextBox();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConecta = new System.Windows.Forms.Button();
            this.btnPing = new System.Windows.Forms.Button();
            this.rLog = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtip
            // 
            this.txtip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtip.Location = new System.Drawing.Point(6, 47);
            this.txtip.Name = "txtip";
            this.txtip.Size = new System.Drawing.Size(100, 24);
            this.txtip.TabIndex = 0;
            // 
            // txtPorta
            // 
            this.txtPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtPorta.Location = new System.Drawing.Point(112, 47);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(100, 24);
            this.txtPorta.TabIndex = 1;
            this.txtPorta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorta_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(112, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Porta:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConecta);
            this.groupBox1.Controls.Add(this.btnPing);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtip);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPorta);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.groupBox1.Location = new System.Drawing.Point(270, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 117);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TCP";
            // 
            // btnConecta
            // 
            this.btnConecta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnConecta.Location = new System.Drawing.Point(110, 77);
            this.btnConecta.Name = "btnConecta";
            this.btnConecta.Size = new System.Drawing.Size(100, 30);
            this.btnConecta.TabIndex = 5;
            this.btnConecta.Text = "Conectar";
            this.btnConecta.UseVisualStyleBackColor = true;
            // 
            // btnPing
            // 
            this.btnPing.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnPing.Location = new System.Drawing.Point(6, 77);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(100, 30);
            this.btnPing.TabIndex = 4;
            this.btnPing.Text = "Ping";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // rLog
            // 
            this.rLog.Location = new System.Drawing.Point(270, 135);
            this.rLog.Name = "rLog";
            this.rLog.ReadOnly = true;
            this.rLog.Size = new System.Drawing.Size(216, 42);
            this.rLog.TabIndex = 5;
            this.rLog.Text = "";
            // 
            // frmEnviaInformacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 189);
            this.Controls.Add(this.rLog);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEnviaInformacao";
            this.Text = "Envio de Informação";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtip;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConecta;
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.RichTextBox rLog;
    }
}

