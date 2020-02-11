using chat_app.Models;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace chat_app.Hubs
{
    public class MessageHub : Hub
    {
        public async Task NewMessage(Message msg)
        {
            await Clients.All.SendAsync("MessageReceived", msg);
        }
    }
}