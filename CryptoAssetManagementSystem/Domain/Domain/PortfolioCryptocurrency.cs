using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class PortfolioCryptocurrency
    {
        public int PortfolioId { get; set; }
        public Portfolio Portfolio { get; set; }
        public int CryptocurrencyId { get; set; }
        public Cryptocurrency Cryptocurrency { get; set; }
        public decimal Quantity { get; set; }
    }
}
