using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Data.Entities.Catalog;

namespace ECommerce.Data.Repository
{
    public interface ISearchRepository
    {
        IList<Product> GetProductsByCategory(int categoryId);
        IList<Product> GetFeaturedProducts(bool isFeaturedProduct);
        IList<Product> GetWishList();
    }
}
