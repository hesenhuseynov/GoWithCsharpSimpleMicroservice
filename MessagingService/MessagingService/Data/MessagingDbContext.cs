using MessagingService.Models;
using Microsoft.EntityFrameworkCore;

namespace MessagingService.Data
{
    public class MessagingDbContext : DbContext
    {
        public MessagingDbContext(DbContextOptions<MessagingDbContext> options) : base(options)
        {
        }

        public DbSet<Message> Messages { get; set; }



    }
}
