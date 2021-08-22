using Microsoft.EntityFrameworkCore;

namespace RestringApp.DataAccess
{
    public class RestringAppContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Restring> Restrings { get; set; }

        public string DbPath { get; private set; }

        public RestringAppContext(DbContextOptions<RestringAppContext> options) : base(options) { }
    }
}