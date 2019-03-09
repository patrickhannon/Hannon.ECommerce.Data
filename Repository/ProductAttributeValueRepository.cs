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

namespace ECommerce.Data.Repository
{
    public class ProductAttributeValueRepository : IRepository<ProductAttributeValue>
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

        public ProductAttributeValue GetById(object id)
        {
            ProductAttributeValue productAttributeValue;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                productAttributeValue = connection.Query<ProductAttributeValue>("select * FROM ProductAttributeValue Where Id = @Id", new { id = id }).FirstOrDefault();
            }
            return productAttributeValue;
        }

        public ProductAttributeValue GetByProductId(int productId)
        {
            throw new NotImplementedException();
        }

        public void Insert(ProductAttributeValue entity)
        {
            throw new NotImplementedException();
        }

        public void Insert(IEnumerable<ProductAttributeValue> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(ProductAttributeValue entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<ProductAttributeValue> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(ProductAttributeValue entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEnumerable<ProductAttributeValue> entities)
        {
            throw new NotImplementedException();
        }

        public IQueryable<ProductAttributeValue> Table { get; }
        public IQueryable<ProductAttributeValue> TableNoTracking { get; }

        
    }
}
