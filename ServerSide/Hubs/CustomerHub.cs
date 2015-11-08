using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Cors;

namespace SignalRMongoDbServer.Hubs
{
    [EnableCors(origins: "http://192.168.1.3:8086", headers: "*", methods: "*")]
    public class CustomerHub : Hub
    {
        public void PushMessage(string message)
        {
            Clients.All.receiveMessage(message);
        }
    }


}

