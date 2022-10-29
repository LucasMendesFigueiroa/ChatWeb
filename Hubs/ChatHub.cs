using Microsoft.AspNetCore.SignalR;

namespace Chattest.Hubs
{
    public class ChatHub : Hub
    {
        public async Task NewMenssage(string nome, string menssage)
        {

            await Clients.All.SendAsync("NewMenssage", nome, menssage);

        }
    }
}
