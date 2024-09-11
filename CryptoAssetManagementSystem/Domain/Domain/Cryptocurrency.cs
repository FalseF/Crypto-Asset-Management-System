using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class Cryptocurrency
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Symbol { get; set; }
        [DataType(DataType.Currency)]
        public decimal CurrentPrice { get; set; }
        public ICollection<PortfolioCryptocurrency> PortfolioCryptocurrencies { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }
}
