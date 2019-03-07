using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using ECommerce.Data.Entities;
using ECommerce.Data.Entities.Catalog;

namespace ECommerce.Data.Repository
{
    public class ProductAttributeValueRepository
    {
        private readonly string _connectionString;
        public ProductAttributeValueRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public IList<ProductAttributeValue> Get()
        {
            IList<ProductAttributeValue> productAttributeValue;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                productAttributeValue = connection.Query<ProductAttributeValue>("select * FROM ProductAttributeValue").ToList();
            }
            return productAttributeValue;
        }
    }
}
