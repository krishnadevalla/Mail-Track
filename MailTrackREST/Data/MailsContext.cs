using Microsoft.EntityFrameworkCore;

namespace MailTrackREST.Models
{
    public class MailsContext : DbContext
    {
        public MailsContext(DbContextOptions<MailsContext> options)
            : base(options)
        {
        }

        public DbSet<Mail> Mail { get; set; }
    }
}