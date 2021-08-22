using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RestringApp.DataAccess
{
    public class Contact
    {
        public int ContactId { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        public List<Restring> Restrings { get; } = new List<Restring>();
    }
}