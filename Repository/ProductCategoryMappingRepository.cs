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
    public class ProductCategoryMappingRepository
    {
        private readonly string _connectionString;
        public ProductCategoryMappingRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public IList<ProductCategory> GetCategories()
        {
            IList<ProductCategory> productCategoryMapping;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                productCategoryMapping = connection.Query<ProductCategory>("select * FROM Product_Category_Mapping").ToList();
            }
            return productCategoryMapping;
        }
    }
}
