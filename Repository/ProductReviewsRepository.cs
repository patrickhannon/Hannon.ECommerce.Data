using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using ECommerce.Data.Core.Data;
using ECommerce.Data.Entities.Catalog;

namespace ECommerce.Data.Repository
{
    public class ProductReviewsRepository : IRepository<ProductReview>
    {
        private readonly string _connectionString;

        public IQueryable<ProductReview> Table => throw new NotImplementedException();

        public IQueryable<ProductReview> TableNoTracking => throw new NotImplementedException();

        public ProductReviewsRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public ProductReview GetById(object id)
        {
            ProductReview productReview;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                productReview = connection.Query<ProductReview>("select * FROM ProductReview Where Id = @Id", new { id = id }).FirstOrDefault();
            }
            return productReview;
        }

        public ICollection<ProductReview> GetByProductId(int id)
        {
            ICollection<ProductReview> productReview;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                productReview = connection.Query<ProductReview>("select * FROM ProductReview Where ProductId = @Id", new { id = id }).ToList();
            }
            return productReview;
        }

        public IList<ProductReview> Get()
        {
            IList<ProductReview> productReview;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                productReview = connection.Query<ProductReview>("select * FROM ProductReview").ToList();
            }
            return productReview;
        }

        public void Insert(ProductReview entity)
        {
            throw new NotImplementedException();
        }

        public void Insert(IEnumerable<ProductReview> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(ProductReview entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<ProductReview> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(ProductReview entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEnumerable<ProductReview> entities)
        {
            throw new NotImplementedException();
        }
    }
}
