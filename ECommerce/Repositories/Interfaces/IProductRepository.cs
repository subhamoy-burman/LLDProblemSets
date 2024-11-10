using ECommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Repositories.Interfaces
{
    internal interface IProductRepository
    {
        public void AddProduct(Product product, SellerAccount sellerInfo);
        public void RemoveProduct(Product product);
        public void UpdateProduct(Product product);
        public List<Product> SearchProduct(string searchString);
    }
}
