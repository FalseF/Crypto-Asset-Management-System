using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class Transaction
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int CryptocurrencyId { get; set; }
        public Cryptocurrency Cryptocurrency { get; set; }
        [Required]
        public string TransactionType { get; set; } // Buy or Sell
        public decimal Quantity { get; set; }
        [DataType(DataType.Date)]
        public DateTime TransactionDate { get; set; }
    }
}
