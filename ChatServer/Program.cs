using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ChatServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UdpClient udpClient = new UdpClient(12345);
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Any, 0);
            Console.WriteLine("Сервер ожидает сообщение от клиента... ");

            while (true)
            {
                byte[] buffer = udpClient.Receive(ref iPEndPoint);
                if (buffer == null) break;

                var messageText = Encoding.UTF8.GetString(buffer);
                Message? messageServer = Message.DeserializeFromJsonToMessage(messageText);

                Console.WriteLine(messageServer);    
                
                if (!string.IsNullOrEmpty(messageText))
                {     
                    Thread.Sleep(1000);
                    byte[] data = Encoding.UTF8.GetBytes("Сообщение доставлено.");
                    udpClient.Send(data, data.Length, iPEndPoint);
                }
            }
        }
    }
}
