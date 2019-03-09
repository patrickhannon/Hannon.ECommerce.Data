using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using ECommerce.Data.Core.Data;
using ECommerce.Data.Entities.Catalog;
using ProductSpecificationAttribute = ECommerce.Data.Entities.Catalog.ProductSpecificationAttribute;

namespace ECommerce.Data.Repository
{
    public class ProductSpecificationAttributeRepository : IRepository<ProductSpecificationAttribute>
    {
        private readonly string _connectionString;
        public ProductSpecificationAttributeRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public ProductSpecificationAttribute GetById(object id)
        {
            ProductSpecificationAttribute _productSpecificationAttribute;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                _productSpecificationAttribute = connection.Query<ProductSpecificationAttribute>("select * FROM Product_SpecificationAttribute_Mapping Where Id = @Id", new { id = id }).FirstOrDefault();
            }
            return _productSpecificationAttribute;
        }

        public IList<ProductSpecificationAttribute> Get()
        {
            IList<ProductSpecificationAttribute> productSpecificationAttribute;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                productSpecificationAttribute = 
                    connection.Query<ProductSpecificationAttribute>("select * FROM Product_SpecificationAttribute_Mapping").ToList();
            }
            return productSpecificationAttribute;
        }

        public ICollection<ProductSpecificationAttribute> GetByProductId(int id)
        {
            ICollection<ProductSpecificationAttribute> productSpecificationAttributes;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                productSpecificationAttributes = connection.Query<ProductSpecificationAttribute>("select * FROM Product_SpecificationAttribute_Mapping Where ProductId = @Id", new { id = id }).ToList();
            }
            return productSpecificationAttributes;
        }

        public void Insert(ProductSpecificationAttribute entity)
        {
            throw new NotImplementedException();
        }

        public void Insert(IEnumerable<ProductSpecificationAttribute> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(ProductSpecificationAttribute entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<ProductSpecificationAttribute> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(ProductSpecificationAttribute entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEnumerable<ProductSpecificationAttribute> entities)
        {
            throw new NotImplementedException();
        }

        public IQueryable<ProductSpecificationAttribute> Table { get; }

        public IQueryable<ProductSpecificationAttribute> TableNoTracking { get; }
    }
}
