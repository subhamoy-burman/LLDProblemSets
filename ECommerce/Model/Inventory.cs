using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Model
{
    internal class Inventory
    {
        public Guid ProductId { get; set; }
        public int InventoryCount { get; set; }
    }
}
