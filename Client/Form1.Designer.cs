namespace Client
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnConnect = new Button();
            txtPort = new TextBox();
            label2 = new Label();
            txtHost = new TextBox();
            label1 = new Label();
            txtMessage = new TextBox();
            txtStatus = new TextBox();
            btnSend = new Button();
            SuspendLayout();
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(428, 22);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(154, 29);
            btnConnect.TabIndex = 9;
            btnConnect.Tag = "";
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // txtPort
            // 
            txtPort.Location = new Point(313, 23);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(89, 27);
            txtPort.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(272, 26);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 7;
            label2.Text = "Port:";
            // 
            // txtHost
            // 
            txtHost.Location = new Point(97, 24);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(151, 27);
            txtHost.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 26);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 5;
            label1.Text = "Host:";
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(97, 85);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(485, 73);
            txtMessage.TabIndex = 10;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(97, 226);
            txtStatus.Multiline = true;
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(485, 167);
            txtStatus.TabIndex = 11;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(428, 182);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(154, 29);
            btnSend.TabIndex = 12;
            btnSend.Tag = "";
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 405);
            Controls.Add(btnSend);
            Controls.Add(txtStatus);
            Controls.Add(txtMessage);
            Controls.Add(btnConnect);
            Controls.Add(txtPort);
            Controls.Add(label2);
            Controls.Add(txtHost);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Client";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConnect;
        private TextBox txtPort;
        private Label label2;
        private TextBox txtHost;
        private Label label1;
        private TextBox txtMessage;
        private TextBox txtStatus;
        private Button btnSend;
    }
}