using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Model
{
    internal class ProductReview
    {
        public Guid ProductReviewId { get; set; }
        public Guid ProductId { get; set; }
        public Guid ProductReviewUserId { get; set; }
        public int ProductReviewRating {  get; set; }
        public string ProductReviewDescription { get; set; }

    }
}
