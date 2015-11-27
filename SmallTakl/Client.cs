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
      IPClient1TextBox.Text = connect.GetLocalIP();
    }


    private void sendButton_Click(object sender, EventArgs e)
    {
    }
  }
}
