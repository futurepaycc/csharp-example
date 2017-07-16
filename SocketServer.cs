using System;
using System.Net.Sockets;
using System.Text;
using System.Collections.Generic;

public class SocketServer1{
    public static void Main(){
        TcpListener serverSocket = new TcpListener(8888);
        int requestCount = 0;
        TcpClient clientScoket = default(TcpClient);
        serverSocket.Start();
        Console.WriteLine(">>server started");
        clientScoket = serverSocket.AcceptTcpClient();
        Console.WriteLine(">>accecpt conn from client");
        requestCount = 0;
        while(true){
            requestCount += 1;
            NetworkStream networkStream = clientScoket.GetStream();
            byte[] bytesFrom = new byte[10025];
            networkStream.Read(bytesFrom,0,clientScoket.ReceiveBufferSize);
            string dataFromClient = Encoding.ASCII.GetString(bytesFrom);
            dataFromClient = dataFromClient.Substring(0,dataFromClient.IndexOf("$"));
            Console.WriteLine(">>data froom client -"+dataFromClient);

            string serverResponse = "Last Message from client"+dataFromClient;
            byte[] sendBytes = Encoding.ASCII.GetBytes(serverResponse);
            networkStream.Write(sendBytes,0,sendBytes.Length);
            networkStream.Flush();
            Console.WriteLine(">>"+serverResponse);
        }
        clientScoket.Close();
        serverSocket.Stop();
        Console.WriteLine(">>exit");
    }
}