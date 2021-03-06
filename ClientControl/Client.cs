﻿using System;
using System.Media;
using System.Net;
using System.Windows.Forms;

namespace SmallTalk
{
  public partial class Client : UserControl
  {
    Connector connect;

    public Client()
    {
      InitializeComponent();

      IPClient1TextBox.Text = Connector.GetLocalIP();
    }


    private void sendButton_Click(object sender, EventArgs e)
    {
      sendMessage();
    }

    private void sendMessage()
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
        SystemSounds.Beep.Play();
        listMessage.Items.Add("Friend: " + s);
      }
    }

    private void Connect_info(string s)
    {
      MessageBox.Show(s, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void startButon_Click(object sender, EventArgs e)
    {
      try
      {
        connect = new Connector();
        IPClient1TextBox.Text = connect.LocalIP;
        connect.sendText += Connect_sendText;
        connect.error += Connect_info;

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

    private void closeButton_Click(object sender, EventArgs e)
    {
      connect.Dispose();
      startButon.Enabled = true;
      startButon.Text = "Start";
      closeButton.Enabled = false;
    }

    private void messageTextBox_KeyUp(object sender, KeyEventArgs e)
    {
      if(e.KeyCode == Keys.Enter)
      {
        sendMessage();
      }
    }
  }
}
