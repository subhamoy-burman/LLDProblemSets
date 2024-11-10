using ECommerce.Model;
using ECommerce.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Services
{
    internal class CartService
    {
        private readonly ICartRepository _cartRepository;
        public CartService(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public void AddItemToCart(Product product, int quantity, Guid userId)
        {
            _cartRepository.AddProductAndUnitInCart((product,quantity), userId);
        }

        public void UpdateItemToCart(Product product, int quantity, Guid userId) { 
          _cartRepository.UpdateProductInCart((product,quantity), userId);
        }

        public void RemoveItemFromCart(Product product, Guid userId) { 
            _cartRepository.RemoveProductFromCart(product, userId);
        }
    }
}
