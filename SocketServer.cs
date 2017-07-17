using System;
using System.Net;
using System.Text;
using System.Net.Sockets;

public class SocketServer1{
    public static void Main(string[] args){
        TcpListener listener = new TcpListener(IPAddress.Parse("127.0.0.1"),8888);
        listener.Start();

        Console.WriteLine(">> server listening at 8888");
        TcpClient client = listener.AcceptTcpClient();
        Console.WriteLine(">> conn accept");

        NetworkStream clientStream = client.GetStream();
        string response = "conn has been accepted";
        byte[] responseBytes = Encoding.ASCII.GetBytes(response);
        clientStream.Write(responseBytes,0,responseBytes.Length);

        client.Close();
        listener.Stop();
    }
}