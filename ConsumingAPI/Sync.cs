using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsumingAPI
{
    public class Sync
    {
        public class ConsumeAPI
        {
            public void GetAllEventData() //Get All Events Records  
            {
                using (var client = new WebClient()) //WebClient  
                {
                    while (true)
                    {
                    client.Headers.Add("Content-Type:application/json"); //Content-Type  
                    client.Headers.Add("Accept:application/json");
                    var result = client.DownloadString("http://localhost:63312/api/usuario/ConsultarUsuarios"); //URI
                    Console.WriteLine(Environment.NewLine + result);
                    Console.ReadLine();
                    }
                }
            }
        }
    }
}