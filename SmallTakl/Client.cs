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
      connect.sendText += Connect_sendText;
    }


    private void sendButton_Click(object sender, EventArgs e)
    {
      try
      {
        string message = messageTextBox.Text;
        connect.Send(message);
        listMessage.Items.Add("Me: " + message);
        messageTextBox.Clear();
      }
      catch (Exception exp)
      {
        MessageBox.Show("Error: " + exp.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void Connect_sendText(string s)
    {
      if (InvokeRequired)
        listMessage.Invoke(connect.sendText, s);
      else
      {
        listMessage.Items.Add("Friend: " + s);
      }
    }

    private void startButon_Click(object sender, EventArgs e)
    {
      try
      {
        connect.Start(portClient1TextBox.Text, IPClient2TextBox.Text, portClient2TextBox.Text);

        startButon.Text = "Connected";
        startButon.Enabled = false;
        sendButton.Enabled = true;
        closeButton.Enabled = true;
        messageTextBox.Focus();
      }
      catch (Exception exp)
      {
        MessageBox.Show("Error: " + exp.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}
