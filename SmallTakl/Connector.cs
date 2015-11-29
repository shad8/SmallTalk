using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace SmallTakl
{
  class Connector:IDisposable
  {
    Socket socket;
    EndPoint epLocal, epRemote;

    string localIP;
    string receiveMessage = "";

    public delegate void MessageDel(string s);
    public MessageDel sendText = null;

    public Connector()
    {
      socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
      socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
      localIP = GetLocalIP();
  }

    public string ReceiveMessage { get { return receiveMessage;  } }
    public string LocalIP { get { return localIP; } }

    private string GetLocalIP()
    {
      IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
      foreach (IPAddress ip in host.AddressList)
      {
        if (ip.AddressFamily == AddressFamily.InterNetwork)
          return ip.ToString();
      }
      return "127.0.0.1";
    }

    public void Send(string text)
    {
      byte[] message = new byte[1500];
      message = new ASCIIEncoding().GetBytes(text);
      socket.Send(message);
    }

    public void Start(string localPort, string IP, string port)
    {
      epLocal = new IPEndPoint(IPAddress.Parse(localIP), Convert.ToInt32(localPort));
      socket.Bind(epLocal);

      epRemote = new IPEndPoint(IPAddress.Parse(IP), Convert.ToInt32(port));
      socket.Connect(epRemote);

      byte[] buffer = new byte[1500];
      socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
    }

    private void MessageCallBack(IAsyncResult aResult)
    {
      int size = socket.EndReceiveFrom(aResult, ref epRemote);
      if (size > 0)
      {
        byte[] receiveData = new byte[1462];
        receiveData = (byte[])aResult.AsyncState;
        ASCIIEncoding ascii = new ASCIIEncoding();
        receiveMessage = ascii.GetString(receiveData, 0, Array.IndexOf(receiveData, (byte)0)).ToString();
        Thread.Sleep(300);
        sendText.Invoke(receiveMessage);
      }
      byte[] buffer = new byte[1500];
      socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
    }

    public void Dispose()
    {
      socket.Close();
    }
  }
}
