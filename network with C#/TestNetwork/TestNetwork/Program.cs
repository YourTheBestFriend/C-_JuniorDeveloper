using System.Net;

namespace TestNetwork
{
    public class Program
    {
        public static void Main(string[] args)
        {

            IPAddress ip = IPAddress.Parse("127.0.0.1"); // ip указывает на локальный адрес

            IPHostEntry host1 = Dns.GetHostEntry("www.microsoft.com");
            Console.WriteLine(host1.HostName);
            foreach (IPAddress ip_ in host1.AddressList)
            {
                Console.WriteLine(ip_.ToString());
            }
            Console.WriteLine();
            IPHostEntry host2 = Dns.GetHostEntry("google.com");
            Console.WriteLine(host2.HostName);
            foreach (IPAddress ip_ in host2.AddressList)
            {
                Console.WriteLine(ip_.ToString());
            }
                
        }
    }
}
