using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using ECommerce.Data.Entities;

namespace ECommerce.Data.Repository
{
    public class ProductProductTagMappingRepository
    {
        private readonly string _connectionString;
        public ProductProductTagMappingRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public IList<ProductProductTagMapping> GetProductProductTagMappings()
        {
            IList<ProductProductTagMapping> productProductTagMapping;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                productProductTagMapping = connection.Query<ProductProductTagMapping>("select * FROM Product_ProductTag_Mapping").ToList();
            }
            return productProductTagMapping;
        }
    }
}
