using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthPlusSport.Shared.Models
{
    public class Product
    {
        public string ProductId { get; set; }
        public string Title { get; set; }
        public int Quantity { get; set; } = 1;
        public string Url { get; set; }

    }
}
