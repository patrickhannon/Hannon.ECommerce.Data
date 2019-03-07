using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using ECommerce.Data.Entities;
using ECommerce.Data.Entities.Shipping;

namespace ECommerce.Data.Repository
{
    public class ProductAvailabilityRangeRepository
    {
        private readonly string _connectionString;
        public ProductAvailabilityRangeRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public IList<ProductAvailabilityRange> GetProductAvailabilityRanges()
        {
            IList<ProductAvailabilityRange> productAvailabilityRanges;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                productAvailabilityRanges = connection.Query<ProductAvailabilityRange>("select * FROM ProductAvailabilityRange").ToList();
            }
            return productAvailabilityRanges;
        }
    }
}
