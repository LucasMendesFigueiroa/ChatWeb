using Chattest.Hubs;
using ChatWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace Chattest
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : Controller
    {
        private readonly IHubContext<ChatHub> _chatHubContext;
        private static List<Chat> _chats = new List<Chat>();

        public ChatController(IHubContext<ChatHub> ofertaHubContext)
        {
            _chatHubContext = ofertaHubContext;
            
        }

        [HttpPost]
        public void Post([FromBody] Chat chat)
        {
            _chats.Add(chat);
            _chatHubContext.Clients.All.SendAsync("NovoChat",chat);
            
        }

        [HttpGet]
        public List<Chat> Get()
        {
            return _chats;
        }
    }
}
