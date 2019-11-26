using System;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Text;

public class SocketProgramm
{
    public static void Main(string[] args)
    {
        IPAddress localAddr = IPAddress.Parse("127.0.0.1");
        TcpListener serverSocket = new TcpListener(localAddr,7876);
        TcpClient clientSocket = default(TcpClient);
        int count = 0;
        serverSocket.Start();
        Console.WriteLine("Sever started");
        count = 0;
        while (true)
        {
            count += 1;
            clientSocket = serverSocket.AcceptTcpClient();
            Console.WriteLine("client no:" + Convert.ToString(count) + " started");
            handleClient client = new handleClient();
            client.startClient(clientSocket, Convert.ToString(count));
        }
        clientSocket.Close();
        serverSocket.Stop();
        Console.WriteLine("Exit");
        Console.ReadLine();
    }
}
public class handleClient
{
    TcpClient clientSocket;
    string clNo;
    public  void startClient(TcpClient inClientSocket, string clientNo)
    {
        this.clientSocket = inClientSocket;
        this.clNo = clientNo;
        Thread clTh = new Thread(doWork);
        clTh.Start();
    }
    private void doWork()
    {
        int requestCount = 0;
        byte[] bytesFrom = new byte[1024];
        string dataFromClient = null;
        Byte[] sendBytes = null;
        string serverResponse = null;
        string rCount = null;
        requestCount = 0;

        while (true)
        {
            try
            {
                requestCount = requestCount + 1;
                NetworkStream networkStream = clientSocket.GetStream();
                networkStream.Read(bytesFrom, 0, (int)clientSocket.ReceiveBufferSize);
                dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));
                Console.WriteLine("From client-" + clNo + dataFromClient);

                rCount = Convert.ToString(requestCount);
                serverResponse = "Server to clinet(" + clNo + ") " + rCount;
                sendBytes = Encoding.ASCII.GetBytes(serverResponse);
                networkStream.Write(sendBytes, 0, sendBytes.Length);
                networkStream.Flush();
                Console.WriteLine(serverResponse);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
