using ECommerce.Model;
using ECommerce.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Repositories.Implementations
{
    internal class ProductReviewRepository : IProductReviewRepository
    {
        public void AddProductReview(Product product,UserAccount user, string reviewMessage)
        {
            throw new NotImplementedException();
        }

        public void DeleteProductReview(Guid productReviewId)
        {
            throw new NotImplementedException();
        }

        public void UpdateProductReview(Product product, UserAccount user, string reviewMessage)
        {
            throw new NotImplementedException();
        }
    }
}
