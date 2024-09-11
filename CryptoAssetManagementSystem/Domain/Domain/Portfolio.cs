using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class Portfolio
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<PortfolioCryptocurrency> PortfolioCryptocurrencies { get; set; }
    }
}
