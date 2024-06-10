using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace Chat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private TcpListener listener;
        private SslStream sslStream;

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            listener = new TcpListener(IPAddress.Parse(txtHost.Text), int.Parse(txtPort.Text));
            listener.Start();

            // Handle clients in another thread.
            Task.Run(() => HandleClients());
        }

        private async void HandleClients()
        {
            while (true)
            {
                var client = await listener.AcceptTcpClientAsync();
                var stream = client.GetStream();

                sslStream = new SslStream(stream, false);
                try
                {
                    var serverCertificate = new X509Certificate2("C:\\Users\\loren\\Desktop\\certificate.pfx", "Ellanina1");
                    await sslStream.AuthenticateAsServerAsync(serverCertificate, clientCertificateRequired: false, checkCertificateRevocation: true);

                    // Handle this client in another thread.
                    Task.Run(() => HandleClient(sslStream));
                }
                catch (Exception e)
                {
                    // Authentication failed.
                    client.Dispose();
                }
            }
        }

        private async void HandleClient(SslStream stream)
        {
            byte[] buffer = new byte[4096];
            int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
            string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);

            Invoke((MethodInvoker)delegate ()
            {
                txtStatus.Text += message;
                var replyMessage = string.Format("You said: {0}", message);
                byte[] replyBytes = Encoding.UTF8.GetBytes(replyMessage);
                stream.Write(replyBytes, 0, replyBytes.Length);
            });
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            listener.Stop();
        }
    }
}
