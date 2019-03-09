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
    public class ProductCategoryMappingRepository : IRepository<ProductCategory>
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

        public ICollection<ProductCategory> GetByProductId(int id)
        {
            ICollection<ProductCategory> productCategories;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                productCategories = connection.Query<ProductCategory>("select * FROM Product_Category_Mapping Where ProductId = @Id", new { id = id }).ToList();
            }
            return productCategories;
        }

        public ProductCategory GetById(object id)
        {
            ProductCategory productCategories;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                productCategories = connection.Query<ProductCategory>("select * FROM ProductCategory Where Id = @Id", new { id = id }).FirstOrDefault();
            }
            return productCategories;
        }

        public IList<ProductCategory> Get()
        {
            throw new NotImplementedException();
        }

        public void Insert(ProductCategory entity)
        {
            throw new NotImplementedException();
        }

        public void Insert(IEnumerable<ProductCategory> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(ProductCategory entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<ProductCategory> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(ProductCategory entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEnumerable<ProductCategory> entities)
        {
            throw new NotImplementedException();
        }

        public IQueryable<ProductCategory> Table { get; }
        public IQueryable<ProductCategory> TableNoTracking { get; }

       
    }
}
