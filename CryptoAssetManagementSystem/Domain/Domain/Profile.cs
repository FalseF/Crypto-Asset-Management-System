using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class Profile
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        [Required]
        public string FullName { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
    }
}
