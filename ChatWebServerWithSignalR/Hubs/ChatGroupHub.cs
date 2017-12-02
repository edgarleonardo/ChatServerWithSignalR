using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;

namespace ChatApplication.Hubs
{
    public class ChatGroupHub : Hub
    {
        public void SendMessage(string message, string group, string name)
        {
            Clients.Group(group).GetMessage(name, message);
        }

        public Task JoinGroup(string group)
        {
            return Groups.Add(Context.ConnectionId, group);
        }

        public Task LeaveGroup(string group)
        {
            return Groups.Remove(Context.ConnectionId, group);
        }
    }
}