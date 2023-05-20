using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteTCP
{
    public class ClienteTCP
    {
        public void EnviaInformacao(string ip, int porta, string informacao)
        {
            try
            {
                TcpClient tcpClient = new TcpClient(ip, porta);
                byte[] bytes = Encoding.ASCII.GetBytes(informacao);
                tcpClient.GetStream().Write(bytes, 0, bytes.Length);
                tcpClient.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível enviar informação\n" + erro);
            }
        }

        public bool VerificaPorta(string host, int porta)
        {
            try
            {
                using (var tcpClient = new TcpClient())
                {
                    tcpClient.Connect(host, porta);
                    return true;
                }
            }
            catch (SocketException)
            {
                return false;
            }
        }
    }
}
