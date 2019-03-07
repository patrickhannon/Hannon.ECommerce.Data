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
    public class ProductSpecificationAttributeRepository
    {
        private readonly string _connectionString;
        public ProductSpecificationAttributeRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public IList<ProductSpecificationAttribute> GetCategories()
        {
            IList<ProductSpecificationAttribute> productSpecificationAttribute;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                productSpecificationAttribute = 
                    connection.Query<ProductSpecificationAttribute>("select * FROM Product_SpecificationAttribute_Mapping").ToList();
            }
            return productSpecificationAttribute;
        }
    }
}
