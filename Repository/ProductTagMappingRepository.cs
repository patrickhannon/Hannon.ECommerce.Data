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
    public class ProductTagMappingRepository : IRepository<ProductProductTagMapping>
    {
        private readonly string _connectionString;
        public ProductTagMappingRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public ProductProductTagMapping GetById(object id)
        {
            ProductProductTagMapping productProductTagMapping;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                productProductTagMapping = connection.Query<ProductProductTagMapping>("select * FROM ProductProductTagMapping Where Id = @Id", new { id = id }).FirstOrDefault();
            }
            return productProductTagMapping;
        }

        public IList<ProductProductTagMapping> Get()
        {
            IList<ProductProductTagMapping> productProductTagMapping;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                productProductTagMapping = connection.Query<ProductProductTagMapping>("select * FROM Product_ProductTag_Mapping").ToList();
            }
            return productProductTagMapping;
        }

        public void Insert(ProductProductTagMapping entity)
        {
            throw new NotImplementedException();
        }

        public void Insert(IEnumerable<ProductProductTagMapping> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(ProductProductTagMapping entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<ProductProductTagMapping> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(ProductProductTagMapping entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEnumerable<ProductProductTagMapping> entities)
        {
            throw new NotImplementedException();
        }

        public IQueryable<ProductProductTagMapping> Table { get; }

        public IQueryable<ProductProductTagMapping> TableNoTracking { get; }
    }
}
