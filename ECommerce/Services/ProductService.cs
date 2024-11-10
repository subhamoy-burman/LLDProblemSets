using ECommerce.Model;
using ECommerce.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Services
{
    internal class ProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository) {

            _productRepository = productRepository;
        }

        public void AddProduct(Product product, SellerAccount seller)
        {
            _productRepository.AddProduct(product, seller);
        }

        public List<Product> GetListOfProducts(string searchString) { 
        
            return _productRepository.SearchProduct(searchString);
        }
    }
}
