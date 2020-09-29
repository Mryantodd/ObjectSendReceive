using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Common;
namespace ObjectStreamExample
{

    class DataSender
    {
        public static void Main()
        {
            bool SendAge = false;
            Person p = new Person("Tyler", "Durden", 30); // create my serializable object 
            FavoriteColor fC = new FavoriteColor("Mr.", "Anderson", "Black");

            string serverIp = "127.0.0.1";

            TcpClient client = new TcpClient(serverIp, 9050); // have my connection established with a Tcp Server 

            IFormatter formatter = new BinaryFormatter(); // the formatter that will serialize my object on my stream 

            NetworkStream strm = client.GetStream(); // the stream 

            if (SendAge)
            {
                formatter.Serialize(strm, p);
                Console.WriteLine($"Told the server my name is {p.FirstName} {p.LastName}, and that I'm {p.Age}");
            }
            else
            {
                formatter.Serialize(strm, fC);
                Console.WriteLine($"Told the server my name is {fC.FirstName} {fC.LastName}, and my favorite color is {fC.Color}");
            }

            strm.Close();
            client.Close();

            Console.Read();


        }
    }
}

