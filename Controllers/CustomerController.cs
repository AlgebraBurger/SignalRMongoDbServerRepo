using Microsoft.AspNet.SignalR;
using SignalRMongoDbServer.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalRMongoDbServer.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public string Index(string message)
        {
            var hubContext = GlobalHost.ConnectionManager.GetHubContext<CustomerHub>();
            hubContext.Clients.All.receiveMessage(message);

            return message;
        }
    }
}