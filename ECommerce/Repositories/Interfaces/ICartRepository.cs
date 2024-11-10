using ECommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Repositories.Interfaces
{
    internal interface ICartRepository
    {
        public void AddProductAndUnitInCart((Product,int) productUnits, Guid userId);

        public void RemoveProductFromCart(Product product, Guid userId);

        public void UpdateProductInCart((Product, int) productUnits, Guid userId);
    }
}
