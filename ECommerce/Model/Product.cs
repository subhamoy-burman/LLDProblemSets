using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Model
{
    internal class Product
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public int UnitPrice { get; set; }
        public Inventory ProductInventory { get; set; }
    }
}
