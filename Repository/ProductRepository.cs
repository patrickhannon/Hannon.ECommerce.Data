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
    public class ProductRepository : IRepository<Product>
    {
        private readonly string _connectionString;
        public ProductRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public ICollection<Product> GetByProductId(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Product> Get()
        {
            IList<Product> product;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                product = connection.Query<Product>("select * FROM Product").ToList();
            }
            return product;
        }

        public IList<Product> GetProductsByCategory(int categoryId)
        {
            IList<Product> product;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                product = connection.Query<Product>("Select " +
                                                "	[CategoryId] " +
                                                "	,p.* " +
                                                "FROM [Category] c (nolock) " +
                                                "INNER JOIN [Product_Category_Mapping] pcm (nolock) on "+                                      "pcm.CategoryId = c.Id " +
                                                "INNER JOIN [Product] p (nolock) on pcm.ProductId = p.Id " +
                                                "Where " +
                                                "pcm.[CategoryId] = @CategoryId ", new { CategoryId= categoryId })
                    .ToList();
            }
            return product;
        }

        public IList<Product> GetFeaturedProducts(bool isFeaturedProduct)
        {
            IList<Product> product;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                product = connection.Query<Product>("Select " +
                                                    "	[CategoryId] " +
                                                    "	,p.* " +
                                                    "FROM [Category] c (nolock) " +
                                                    "INNER JOIN [Product_Category_Mapping] pcm (nolock) on " +  "pcm.CategoryId = c.Id " +
                                                    "INNER JOIN [Product] p (nolock) on pcm.ProductId = p.Id " +
                                                    "Where " +
                                                    "pcm.[IsFeaturedProduct] = @IsFeaturedProduct ", new { IsFeaturedProduct = isFeaturedProduct }).ToList();
            }
            return product;
        }

        public IList<Product> GetWishList()
        {
            throw new NotImplementedException();
        }

        public Product GetById(object id)
        {
            Product product;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                product = connection.Query<Product>("select * FROM Product Where Id = @Id", new { id = id }).FirstOrDefault();
            }
            return product;
        }

        public void Insert(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Insert(IEnumerable<Product> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<Product> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEnumerable<Product> entities)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Product> Table { get; }

        public IQueryable<Product> TableNoTracking { get; }
        
    }
}
