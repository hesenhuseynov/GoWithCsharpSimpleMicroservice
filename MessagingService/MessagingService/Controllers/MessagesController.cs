using MessagingService.Data;
using MessagingService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MessagingService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly MessagingDbContext _context;

        public MessagesController(MessagingDbContext context)
        {
            _context = context;
        }

        [HttpPost("send")]
        public async Task<IActionResult> SendMessage([FromBody] Message message) 
        {
             _context.Messages.Add(message);
            await _context.SaveChangesAsync();
            return Ok(new { message ="Message sent succeffuly " });

        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetMessages(int userId)
        {
            var message = await _context.Messages.Where(m => m.SenderId == userId || m.ReceiverId == userId)
                .ToListAsync();

            


            return Ok(message);

        }

            




    }
}
