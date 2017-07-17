using System;
using System.Net;
using System.Text;
using System.Net.Sockets;

public class SocketServer1{
    public static void Main(string[] args){
        int port = 8888;
        TcpListener listener = new TcpListener(port);
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