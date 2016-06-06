using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace GameServer.Hubs
{
    public class GameHub : Hub
    {
        public void SendToServer(string msg)
        {
            Clients.All.serverNotify(DateTime.Now.ToString("yyyyMMdd-HH:mm:ss") + msg);
        }
    }
}