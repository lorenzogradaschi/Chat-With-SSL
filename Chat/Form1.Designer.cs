namespace Chat
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
            btnStop = new Button();
            txtStatus = new TextBox();
            label1 = new Label();
            txtHost = new TextBox();
            label2 = new Label();
            txtPort = new TextBox();
            btnStart = new Button();
            SuspendLayout();
            // 
            // btnStop
            // 
            btnStop.Location = new Point(593, 41);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(154, 29);
            btnStop.TabIndex = 5;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(102, 96);
            txtStatus.Multiline = true;
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(645, 195);
            txtStatus.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 45);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 0;
            label1.Text = "Host:";
            label1.Click += label1_Click;
            // 
            // txtHost
            // 
            txtHost.Location = new Point(102, 43);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(151, 27);
            txtHost.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(277, 45);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 2;
            label2.Text = "Port:";
            // 
            // txtPort
            // 
            txtPort.Location = new Point(318, 42);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(89, 27);
            txtPort.TabIndex = 3;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(433, 41);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(154, 29);
            btnStart.TabIndex = 4;
            btnStart.Tag = "";
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 304);
            Controls.Add(txtStatus);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(txtPort);
            Controls.Add(label2);
            Controls.Add(txtHost);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Server";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        #endregion
        private Button btnStop;
        private TextBox txtStatus;
        private Label label1;
        private TextBox txtHost;
        private Label label2;
        private TextBox txtPort;
        private Button btnStart;
    }
}