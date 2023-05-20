using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteTCP
{
    public class ClienteTCP
    {
        public string mensagem;
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

        public void Conecta_Desconecta(string ip, int porta)
        {
            TcpClient tcpClient = new TcpClient();
            NetworkStream stream;

            if (tcpClient.Connected)
            {
                try
                {
                    tcpClient.Connect(ip, porta);
                    stream = tcpClient.GetStream();
                    mensagem = ("Conectado ao servidor.");

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    mensagem = "Não Conectado";
                }
            }
            else
            {
                try
                {
                    MessageBox.Show("Conexão será fechada");
                    tcpClient.Close();
                }
                catch (Exception ex)
                {
                    mensagem = "Não foi possivel fechar a conexão";
                    MessageBox.Show(ex.Message);
                }

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
