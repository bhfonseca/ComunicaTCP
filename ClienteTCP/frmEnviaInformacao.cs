using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteTCP
{
    public partial class frmEnviaInformacao : Form
    {
        ClienteTCP tcp = new ClienteTCP();
        public frmEnviaInformacao()
        {
            InitializeComponent();
        }

        private void txtPorta_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permite somente numero no textbox
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)

            {

                e.Handled = true;

            }
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            var result = tcp.VerificaPorta(txtip.Text, Convert.ToInt32(txtPorta.Text));
            if (result == true )
            {
                rLog.AppendText("Porta esta aberta\n");
            }
            else
            {
                rLog.AppendText("Porta não esta aberta\n");
            }
        }

        private void btnConecta_Click(object sender, EventArgs e)
        {
            tcp.Conecta_Desconecta(txtip.Text, Convert.ToInt32(txtPorta.Text));
            //rLog.AppendText(tcp.mensagem);
        }
    }
}
