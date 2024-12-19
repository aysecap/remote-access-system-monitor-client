using System;
using System.Windows.Forms;
using System.ComponentModel;


namespace TCPClientWithUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnConnect1;
        private System.Windows.Forms.Label lblStatus1;
        private System.Windows.Forms.TextBox txtReceivedData1;

        /// <summary>
        /// Temizleme işlemleri.
        /// </summary>
        /// <param name="disposing">Yönetilen kaynakların serbest bırakılması gerekiyorsa true, aksi halde false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        
        private void InitializeComponent()
        {
            btnConnect = new Button();
            lblStatus = new Label();
            txtReceivedData = new TextBox();
            lblStatus1 = new Label();
            SuspendLayout();
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(12, 24);
            btnConnect.Margin = new Padding(3, 4, 3, 4);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(127, 38);
            btnConnect.TabIndex = 0;
            btnConnect.Text = "Bağlan";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // lblStatus
            // 
            lblStatus.Location = new Point(0, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(100, 23);
            lblStatus.TabIndex = 3;
            // 
            // txtReceivedData
            // 
            txtReceivedData.Location = new Point(12, 100);
            txtReceivedData.Margin = new Padding(3, 4, 3, 4);
            txtReceivedData.Multiline = true;
            txtReceivedData.Name = "txtReceivedData";
            txtReceivedData.ReadOnly = true;
            txtReceivedData.ScrollBars = ScrollBars.Vertical;
            txtReceivedData.Size = new Size(399, 248);
            txtReceivedData.TabIndex = 2;
            txtReceivedData.TextChanged += txtReceivedData_TextChanged;
            // 
            // lblStatus1
            // 
            lblStatus1.Location = new Point(12, 66);
            lblStatus1.Name = "lblStatus1";
            lblStatus1.Size = new Size(200, 30);
            lblStatus1.TabIndex = 0;
            lblStatus1.Text = "Durum: Bekleniyor";
            lblStatus1.Click += lblStatus1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 414);
            Controls.Add(lblStatus1);
            Controls.Add(txtReceivedData);
            Controls.Add(lblStatus);
            Controls.Add(btnConnect);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TCP Client with UI";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtReceivedData;
    }
}
