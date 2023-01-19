using Microsoft.AspNetCore.SignalR;

namespace BlazorServerSignalRApp.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message, string timestamp, string group,string messageId)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message, timestamp, group,messageId);
        }

        public async Task SendReaction(string reaction, string messageId, string user){
            await Clients.All.SendAsync("ReceiveReaction", reaction, messageId, user);
        }
    }

}