using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using ECommerce.Data.Core.Data;
using ECommerce.Data.Entities;
using ECommerce.Data.Entities.Catalog;
using ECommerce.Data.Entities.Media;

namespace ECommerce.Data.Repository
{
    public class ProductAttributeCombinationRepository : IRepository<ProductAttributeCombination>
    {
        private readonly string _connectionString;
        public ProductAttributeCombinationRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public ProductAttributeCombination GetById(object id)
        {
            ProductAttributeCombination productAttributeCombination;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                productAttributeCombination = connection.Query<ProductAttributeCombination>("select * FROM ProductAttributeCombination Where Id = @Id", new { id = id }).FirstOrDefault();
            }
            return productAttributeCombination;
        }

        public IList<ProductAttributeCombination> Get()
        {
            IList<ProductAttributeCombination> productAttributeCombination;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                productAttributeCombination = connection.Query<ProductAttributeCombination>("select * FROM ProductAttributeCombination").ToList();
            }
            return productAttributeCombination;
        }

        public void Insert(ProductAttributeCombination entity)
        {
            throw new NotImplementedException();
        }

        public void Insert(IEnumerable<ProductAttributeCombination> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(ProductAttributeCombination entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<ProductAttributeCombination> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(ProductAttributeCombination entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEnumerable<ProductAttributeCombination> entities)
        {
            throw new NotImplementedException();
        }

        public IQueryable<ProductAttributeCombination> Table { get; }

        public IQueryable<ProductAttributeCombination> TableNoTracking { get; }
    }
}
