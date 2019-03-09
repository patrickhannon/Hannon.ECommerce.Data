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

        public ProductCategory GetByProductId(int id)
        {
            ProductCategory productCategory;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                productCategory = connection.Query<ProductCategory>("select * FROM ProductCategory Where Id = @Id", new { productId = id }).FirstOrDefault();
            }
            return productCategory;
        }


        public ProductCategory GetById(object id)
        {
            throw new NotImplementedException();
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
