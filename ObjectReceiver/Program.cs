using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Common;
namespace ObjectStreamExample
{

    class DataRcvr
    {
        public static void Main()
        {
            TcpListener server = new TcpListener(IPAddress.Any,9050);
            server.Start();
            TcpClient client = server.AcceptTcpClient();
            NetworkStream strm = client.GetStream();
            IFormatter formatter = new BinaryFormatter();
            object obj = (new BinaryFormatter()).Deserialize(strm);
            try {
                if (obj is Person)
                {

                    Person pp = obj as Person; // you have to cast the deserialized object 
                    Console.WriteLine("Hi, I'm " + pp.FirstName + " " + pp.LastName + " and I'm " + pp.Age + " years old!");
                }
                else if (obj is FavoriteColor)
                {
                    FavoriteColor fc = obj as FavoriteColor; // you have to cast the deserialized object 
                    Console.WriteLine("Hi, I'm " + fc.FirstName + " " + fc.LastName + " and my favorite color is " + fc.Color );
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }


                

            strm.Close();
            client.Close();
            server.Stop();
            Console.Read();
        }
    }
}
