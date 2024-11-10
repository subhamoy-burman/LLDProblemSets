using ECommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Repositories.Interfaces
{
    internal interface IProductReviewRepository
    {
        public void AddProductReview(Product product, UserAccount user, string reviewMessage);
        public void UpdateProductReview(Guid productReviewId);
        public void DeleteProductReview(Product product, UserAccount user, string reviewMessage);

    }
}
