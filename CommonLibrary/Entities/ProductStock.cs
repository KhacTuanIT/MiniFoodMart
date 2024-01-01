using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary.Entities
{
    public class ProductStock
    {
        public Guid Id { get; set; }
        public decimal UnitInStock { get; set; } = 0;
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
    }
}
