using System;
using System.IO;
using System.Net.Sockets;
using System.Net.Security;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private TcpClient client;
        private SslStream sslStream;

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            client = new TcpClient(txtHost.Text, int.Parse(txtPort.Text));
            var stream = client.GetStream();

            sslStream = new SslStream(stream, false, new RemoteCertificateValidationCallback(ValidateServerCertificate), null);
            sslStream.AuthenticateAsClient(txtHost.Text);

            // Handle server responses in another thread.
            Task.Run(() => HandleServerResponses());

            btnConnect.Enabled = false;
        }

        // The following method is invoked by the RemoteCertificateValidationDelegate.
        public static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            // Bypass all certificate validation. DO NOT DO THIS IN PRODUCTION CODE!
            return true;
        }


        private async void HandleServerResponses()
        {
            byte[] buffer = new byte[4096];
            int bytesRead = await sslStream.ReadAsync(buffer, 0, buffer.Length);
            string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);

            Invoke((MethodInvoker)delegate ()
            {
                txtStatus.Text += message;
            });
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (sslStream != null && sslStream.IsAuthenticated)
            {
                byte[] messageBytes = Encoding.UTF8.GetBytes(txtMessage.Text);
                sslStream.Write(messageBytes, 0, messageBytes.Length);
            }
            else
            {
                MessageBox.Show("Not connected to the server.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
