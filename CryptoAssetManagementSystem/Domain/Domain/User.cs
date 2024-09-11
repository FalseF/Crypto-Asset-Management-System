using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public int ProfileId { get; set; }
        public Profile Profile { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
        public ICollection<Portfolio> Portfolios { get; set; }
    }
}
