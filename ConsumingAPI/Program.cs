using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsumingAPI.Sync;

namespace ConsumingAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsumeAPI objsync = new ConsumeAPI();
            objsync.GetAllEventData(); //Adding Event
        }
    }
}
