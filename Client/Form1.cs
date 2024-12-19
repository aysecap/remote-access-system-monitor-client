using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace TCPClientWithUI
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private byte[] buffer;
        private const string serverIp = "127.0.0.1"; // Sunucu IP adresi
        private const int port = 8080;

        public Form1()
        {
            InitializeComponent();
            buffer = new byte[1024];
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                // Sunucuya ba�lan
                client = new TcpClient(serverIp, port);
                stream = client.GetStream();
                lblStatus1.Text = "Sunucuya ba�lan�ld�.";

                // Veriyi almak i�in ayr� bir thread ba�lat
                System.Threading.Thread receiveThread = new System.Threading.Thread(ReceiveData);
                receiveThread.Start();
            }
            catch (Exception ex)
            {
                lblStatus1.Text = "Ba�lant� hatas�: " + ex.Message;
            }
        }

        private void ReceiveData()
        {
            try
            {
                while (true)
                {
                    // Veriyi al ve ekranda g�ster
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string data = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    AppendDataToTextBox(data);
                    System.Threading.Thread.Sleep(5000); // Her 5 saniyede bir veri al
                }
            }
            catch (Exception ex)
            {
                AppendDataToTextBox("Sunucu ba�lant�s� kesildi: " + ex.Message);
            }
        }

        private void AppendDataToTextBox(string data)
        {
            // GUI elemanlar�na veri eklerken Invoke gereklidir
            if (txtReceivedData.InvokeRequired)
            {
                txtReceivedData.Invoke(new Action(() => txtReceivedData.AppendText(data + Environment.NewLine)));
            }
            else
            {
                txtReceivedData.AppendText(data + Environment.NewLine);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (client != null && client.Connected)
            {
                stream.Close();
                client.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

            try
            {
                // Ba�lant�y� kurmaya �al��
                if (client != null && client.Connected)
                {
                    lblStatus1.Text = "Ba�lant� ba�ar�l�!"; // Ba�lant� ba�ar�l� ise 
                }
                else
                {
                    // Ba�lant� sa�lanamazsa 
                    lblStatus1.Text = "Ba�lant� ba�ar�s�z!";
                }
            }
            catch (Exception ex)
            {
                // Hata olu�ursa mesaj� g�ster
                MessageBox.Show("Hata: " + ex.Message);
                lblStatus1.Text = "Ba�lant� hatas�!";
            }
        }

        private void lblStatus1_Click(object sender, EventArgs e)
        {

        }

        private void txtReceivedData_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
