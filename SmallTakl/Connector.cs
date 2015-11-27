using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace SmallTakl
{
  class Connector
  {
    Socket socket;
    EndPoint epLocal, epRemote;

    string receiveMessage = "";

    public Connector()
    {
      socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
      socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
    }

    public string ReceiveMessage { get { return receiveMessage;  } }

    public string GetLocalIP()
    {
      IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
      foreach (IPAddress ip in host.AddressList)
      {
        if (ip.AddressFamily == AddressFamily.InterNetwork)
          return ip.ToString();
      }
      return "127.0.0.1";
    }

    private void MessageCallBack(IAsyncResult aResult)
    {
      int size = socket.EndReceiveFrom(aResult, ref epRemote);
      if (size > 0)
      {
        byte[] receiveData = new byte[1462];
        receiveData = (byte[])aResult.AsyncState;
        receiveMessage = new ASCIIEncoding().GetString(receiveData);
      }

      byte[] buffer = new byte[1500];
      socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
    }
  }
}
