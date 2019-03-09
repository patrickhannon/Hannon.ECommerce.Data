using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using ECommerce.Data.Core.Data;
using ECommerce.Data.Entities;
using ECommerce.Data.Entities.Discounts;

namespace ECommerce.Data.Repository
{
    public class DiscountProductMappingRepository : IRepository<DiscountProductMapping>
    {
        private readonly string _connectionString;
        public DiscountProductMappingRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public IList<DiscountProductMapping> Get()
        {
            IList<DiscountProductMapping> discountProductMapping;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                discountProductMapping = connection.Query<DiscountProductMapping>("select * FROM Discount_AppliedToProducts").ToList();
            }
            return discountProductMapping;
        }

        public void Insert(DiscountProductMapping entity)
        {
            throw new NotImplementedException();
        }

        public void Insert(IEnumerable<DiscountProductMapping> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(DiscountProductMapping entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<DiscountProductMapping> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(DiscountProductMapping entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEnumerable<DiscountProductMapping> entities)
        {
            throw new NotImplementedException();
        }

        public IQueryable<DiscountProductMapping> Table { get; }
        public IQueryable<DiscountProductMapping> TableNoTracking { get; }

        public ICollection<DiscountProductMapping> GetByProductId(int id)
        {
            ICollection<DiscountProductMapping> discountProductMappings;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                discountProductMappings = connection.Query<DiscountProductMapping>("select * FROM Discount_AppliedToProducts Where ProductId = @Id", new { productId = id }).ToList();
            }
            return discountProductMappings;
        }

        public DiscountProductMapping GetById(object id)
        {
            DiscountProductMapping discountProductMapping;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                discountProductMapping = connection.Query<DiscountProductMapping>("select * FROM Discount_AppliedToProducts Where Id = @Id", new { id = id }).FirstOrDefault();
            }
            return discountProductMapping;
        }
    }
}
