namespace DEMO_SERIAL
{
    partial class FrmPrincipal
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
            this.btnOpenSerial = new System.Windows.Forms.Button();
            this.gpInfo = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.gpSerial = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtComando = new System.Windows.Forms.TextBox();
            this.btnSendCmd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxPorts = new System.Windows.Forms.ComboBox();
            this.gpInfo.SuspendLayout();
            this.gpSerial.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenSerial
            // 
            this.btnOpenSerial.Location = new System.Drawing.Point(7, 106);
            this.btnOpenSerial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpenSerial.Name = "btnOpenSerial";
            this.btnOpenSerial.Size = new System.Drawing.Size(165, 64);
            this.btnOpenSerial.TabIndex = 0;
            this.btnOpenSerial.Text = "OpenSerial";
            this.btnOpenSerial.UseVisualStyleBackColor = true;
            this.btnOpenSerial.Click += new System.EventHandler(this.btnOpenSerial_Click);
            // 
            // gpInfo
            // 
            this.gpInfo.Controls.Add(this.txtLog);
            this.gpInfo.Controls.Add(this.gpSerial);
            this.gpInfo.Location = new System.Drawing.Point(13, 18);
            this.gpInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpInfo.Name = "gpInfo";
            this.gpInfo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpInfo.Size = new System.Drawing.Size(881, 241);
            this.gpInfo.TabIndex = 1;
            this.gpInfo.TabStop = false;
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtLog.ForeColor = System.Drawing.Color.Lime;
            this.txtLog.Location = new System.Drawing.Point(8, 29);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(441, 196);
            this.txtLog.TabIndex = 2;
            this.txtLog.DoubleClick += new System.EventHandler(this.txtLog_DoubleClick);
            // 
            // gpSerial
            // 
            this.gpSerial.Controls.Add(this.label2);
            this.gpSerial.Controls.Add(this.txtComando);
            this.gpSerial.Controls.Add(this.btnSendCmd);
            this.gpSerial.Controls.Add(this.btnOpenSerial);
            this.gpSerial.Controls.Add(this.label1);
            this.gpSerial.Controls.Add(this.cbxPorts);
            this.gpSerial.Location = new System.Drawing.Point(466, 29);
            this.gpSerial.Name = "gpSerial";
            this.gpSerial.Size = new System.Drawing.Size(401, 196);
            this.gpSerial.TabIndex = 2;
            this.gpSerial.TabStop = false;
            this.gpSerial.Text = "Serial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Escreva o comando:";
            // 
            // txtComando
            // 
            this.txtComando.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComando.Location = new System.Drawing.Point(201, 68);
            this.txtComando.Name = "txtComando";
            this.txtComando.Size = new System.Drawing.Size(186, 22);
            this.txtComando.TabIndex = 3;
            // 
            // btnSendCmd
            // 
            this.btnSendCmd.Enabled = false;
            this.btnSendCmd.Location = new System.Drawing.Point(206, 106);
            this.btnSendCmd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSendCmd.Name = "btnSendCmd";
            this.btnSendCmd.Size = new System.Drawing.Size(165, 64);
            this.btnSendCmd.TabIndex = 2;
            this.btnSendCmd.Text = "Enviar";
            this.btnSendCmd.UseVisualStyleBackColor = true;
            this.btnSendCmd.Click += new System.EventHandler(this.btnSendCmd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione Porta Serial:";
            // 
            // cbxPorts
            // 
            this.cbxPorts.FormattingEnabled = true;
            this.cbxPorts.Location = new System.Drawing.Point(7, 68);
            this.cbxPorts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxPorts.Name = "cbxPorts";
            this.cbxPorts.Size = new System.Drawing.Size(164, 28);
            this.cbxPorts.TabIndex = 0;
            this.cbxPorts.DropDown += new System.EventHandler(this.cbxPorts_DropDown);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 265);
            this.Controls.Add(this.gpInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPrincipal";
            this.Text = "DEMO SERIAL";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.gpInfo.ResumeLayout(false);
            this.gpInfo.PerformLayout();
            this.gpSerial.ResumeLayout(false);
            this.gpSerial.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenSerial;
        private System.Windows.Forms.GroupBox gpInfo;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxPorts;
        private System.Windows.Forms.GroupBox gpSerial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtComando;
        private System.Windows.Forms.Button btnSendCmd;
    }
}

