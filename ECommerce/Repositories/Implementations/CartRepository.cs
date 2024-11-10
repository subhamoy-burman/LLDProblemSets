using ECommerce.Model;
using ECommerce.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Repositories.Implementations
{
    internal class CartRepository : ICartRepository
    {
        public void AddProductAndUnitInCart((Product, int) productUnits, Guid userId)
        {
            throw new NotImplementedException();
        }

        public void RemoveProductFromCart(Product product, Guid userId)
        {
            throw new NotImplementedException();
        }

        public void UpdateProductInCart((Product, int) productUnits, Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
