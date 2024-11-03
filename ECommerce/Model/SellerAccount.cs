using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Model
{
    internal class SellerAccount : UserAccount
    {
        public string? GSTIN { get; set; }
    }
}
