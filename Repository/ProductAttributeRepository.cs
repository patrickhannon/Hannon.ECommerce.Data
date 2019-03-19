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
    public class ProductAttributeRepository : IRepository<ProductAttribute>
    {
        private readonly string _connectionString;
        public ProductAttributeRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public ProductAttribute GetById(object id)
        {
            ProductAttribute productAttribute;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                productAttribute = connection.Query<ProductAttribute>("select * FROM ProductAttribute Where Id = @Id", new { id = id }).FirstOrDefault();
            }
            return productAttribute;
        }

        public ICollection<ProductAttribute> GetByProductId(int id)
        {
            throw new NotImplementedException();
        }

        public IList<ProductAttribute> Get()
        {
            IList<ProductAttribute> productAttribute;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                productAttribute = connection.Query<ProductAttribute>("select * FROM ProductAttribute").ToList();
            }
            return productAttribute;
        }

        public void Insert(ProductAttribute entity)
        {
            throw new NotImplementedException();
        }

        public void Insert(IEnumerable<ProductAttribute> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(ProductAttribute entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<ProductAttribute> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(ProductAttribute entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEnumerable<ProductAttribute> entities)
        {
            throw new NotImplementedException();
        }

        public IQueryable<ProductAttribute> Table { get; }

        public IQueryable<ProductAttribute> TableNoTracking { get; }
    }
}
