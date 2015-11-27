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
    public Client()
    {
      InitializeComponent();
      Connector connect = new Connector();
    }


    private void sendButton_Click(object sender, EventArgs e)
    {

    }
  }
}
