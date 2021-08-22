using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace RestringApp
{
    public class RestringAppContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Restring> Restrings { get; set; }

        public string DbPath { get; private set; }

        public RestringAppContext(DbContextOptions<RestringAppContext> options) : base (options) { }
    }

    public class Contact {
        public int ContactId {get;set;}

        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        public List<Restring> Restrings {get; } = new List<Restring>();
    }

    public class Restring {
        public int RestringId { get; set; }

        public string RacketBrand { get; set; }
        public string RacketModel { get; set; }
        public int Tension { get; set; }
        public string Description { get; set; }

        public int ContactId {get;set;}
        public Contact Contact { get; set; }
    }
}