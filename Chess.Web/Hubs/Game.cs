using Chess.Game.Figures.Abstracts;
using Chess.Game.Figures.Contracts;
using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Chess.Models.HubModels;

namespace Chess.Web.Hubs
{
    public class Game : Hub
    {
        public static List<UserHub> Users = new List<UserHub>();

        public void Invite(string username)
        {
            var host = Users.FirstOrDefault(x => x.ConnectionId == Context.ConnectionId);
            var joinUsers = Users.Where(x => x.Username == username).ToList();
            joinUsers.ToList().ForEach(x => 
            {
                Clients.Client(x.ConnectionId).recieveInvitation(host);
            });
        }

        public override Task OnConnected()
        {
            var user = new UserHub
            {
                Username = Context.User.Identity.Name,
                ConnectionId = Context.ConnectionId
            };

            Users.Add(user);
            Clients.All.listUsers(Users.Select(x => x.Username).Distinct());
            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            var userToRemove = Users.FirstOrDefault(u => u.ConnectionId == Context.ConnectionId);
            Users.Remove(userToRemove);
            Clients.All.listUsers(Users.Select(x => x.Username).Distinct());
            return base.OnDisconnected(stopCalled);
        }
    }
}