using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Data.Entities.Orders;

namespace ECommerce.Data.Repository
{
    public interface ICustomerRepository
    {
        IList<ShoppingCartItem> GetByCustomerId(object id);
    }
}
