using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Model
{
    internal class Cart
    {
        public Guid UserId { get; set; }
        public Guid CarId { get; set; }
        public List<Product> CartProducts { get; set; }
    }
}
