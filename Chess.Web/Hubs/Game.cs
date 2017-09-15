using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chess.Web.Hubs
{
    public class Game : Hub
    {
        public void SendMessage(string message)
        {
            Clients.All.addMessage($"{ Context.User.Identity.Name }: {message}");
        }
    }
}