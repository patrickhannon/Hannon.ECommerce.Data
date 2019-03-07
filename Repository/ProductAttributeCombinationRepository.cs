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
    public class ProductAttributeCombinationRepository
    {
        private readonly string _connectionString;
        public ProductAttributeCombinationRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public IList<ProductAttributeCombination> GetProductAttributeCombination()
        {
            IList<ProductAttributeCombination> productAttributeCombination;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                productAttributeCombination = connection.Query<ProductAttributeCombination>("select * FROM ProductAttributeCombination").ToList();
            }
            return productAttributeCombination;
        }
    }
}
