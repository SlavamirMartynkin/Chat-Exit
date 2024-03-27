using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ChatClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ip = args[1];
            string myNickName = args[0];

            UdpClient udpClient = new UdpClient();
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse(ip), 12345);

            while (true)
            {
                string messageTextOut;
                do
                {
                    //Console.Clear();
                    Console.WriteLine("Введите сообщение: ");
                    messageTextOut = Console.ReadLine();
                }
                while (string.IsNullOrEmpty(messageTextOut));

                Message message = new Message() { 
                    DateTime = DateTime.Now, 
                    NickNameFrom = myNickName, 
                    NickNameTo = "Server", 
                    Text = messageTextOut };
                string json = message.SerializeMessageToJson();

                byte[] data = Encoding.UTF8.GetBytes(json);
                udpClient.Send(data, data.Length, iPEndPoint);
                
                byte[] buffer = udpClient.Receive(ref iPEndPoint);  
                if (buffer != null)
                {
                    var messageTextIn = Encoding.UTF8.GetString(buffer);
                    Console.WriteLine(messageTextIn);
                    Console.WriteLine();
                }
                else Console.WriteLine("Сообщение не дошло(((");

            }
        }
    }
}
