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
    public class ProductRepository
    {
        private readonly string _connectionString;
        public ProductRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public IList<Product> GetProducts()
        {
            IList<Product> product;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                product = connection.Query<Product>("select * FROM Product").ToList();
            }
            return product;
        }
    }
}
