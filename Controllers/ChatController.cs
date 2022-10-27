using Chattest.Hubs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace Chattest
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : Controller
    {
        private readonly IHubContext<Chat> _chatHubContext;

        public ChatController(IHubContext<Chat> ofertaHubContext)
        {
            _chatHubContext = ofertaHubContext;
        }
    }
}
