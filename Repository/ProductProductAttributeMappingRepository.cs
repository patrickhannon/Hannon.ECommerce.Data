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
    public class ProductProductAttributeMappingRepository : IRepository<ProductAttributeMapping>
    {
        private readonly string _connectionString;
        public ProductProductAttributeMappingRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public ICollection<ProductAttributeMapping> GetByProductId(int id)
        {
            throw new NotImplementedException();
        }

        public IList<ProductAttributeMapping> Get()
        {
            IList<ProductAttributeMapping> productAttributeMapping;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                productAttributeMapping = connection.Query<ProductAttributeMapping>("select * FROM Product_ProductAttribute_Mapping").ToList();
            }
            return productAttributeMapping;
        }

        public ProductAttributeMapping GetById(object id)
        {
            ProductAttributeMapping productAttributeMapping;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                productAttributeMapping = connection.Query<ProductAttributeMapping>("select * FROM Product_ProductAttribute_Mapping Where Id = @Id", new { id = id }).FirstOrDefault();
            }
            return productAttributeMapping;
        }

        public void Insert(ProductAttributeMapping entity)
        {
            throw new NotImplementedException();
        }

        public void Insert(IEnumerable<ProductAttributeMapping> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(ProductAttributeMapping entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<ProductAttributeMapping> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(ProductAttributeMapping entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEnumerable<ProductAttributeMapping> entities)
        {
            throw new NotImplementedException();
        }

        public IQueryable<ProductAttributeMapping> Table { get; }

        public IQueryable<ProductAttributeMapping> TableNoTracking { get; }
    }
}
