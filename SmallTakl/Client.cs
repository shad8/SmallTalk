using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallTakl
{
  public partial class Client : UserControl
  {
    Connector connect;

    public Client()
    {
      InitializeComponent();

      connect = new Connector();
      IPClient1TextBox.Text = connect.LocalIP;

      try
      {
        listMessage.Items.Add("Friend: " + connect.ReceiveMessage);
      }
      catch (Exception exp)
      {
        MessageBox.Show("Error: " + exp.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }


    private void sendButton_Click(object sender, EventArgs e)
    {
    }

    private void startButon_Click(object sender, EventArgs e)
    {
      try
      {
        connect.Start(portClient1TextBox.Text, IPClient2TextBox.Text, portClient2TextBox.Text);

        startButon.Text = "Connected";
        startButon.Enabled = false;
        sendButton.Enabled = true;
        messageTextBox.Focus();
      }
      catch (Exception exp)
      {
        MessageBox.Show("Error: " + exp.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}
