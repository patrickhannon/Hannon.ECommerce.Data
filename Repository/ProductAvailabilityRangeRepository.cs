using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using ECommerce.Data.Core.Data;
using ECommerce.Data.Entities;
using ECommerce.Data.Entities.Shipping;

namespace ECommerce.Data.Repository
{
    public class ProductAvailabilityRangeRepository : IRepository<ProductAvailabilityRange>
    {
        private readonly string _connectionString;
        public ProductAvailabilityRangeRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IQueryable<ProductAvailabilityRange> Table => throw new NotImplementedException();

        public IQueryable<ProductAvailabilityRange> TableNoTracking => throw new NotImplementedException();

        public void Delete(ProductAvailabilityRange entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEnumerable<ProductAvailabilityRange> entities)
        {
            throw new NotImplementedException();
        }

        public IList<ProductAvailabilityRange> Get()
        {
            IList<ProductAvailabilityRange> productAvailabilityRanges;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                productAvailabilityRanges = connection.Query<ProductAvailabilityRange>("select * FROM ProductAvailabilityRange").ToList();
            }
            return productAvailabilityRanges;
        }

        public ProductAvailabilityRange GetById(object id)
        {
            ProductAvailabilityRange productAvailabilityRange;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                productAvailabilityRange = connection.Query<ProductAvailabilityRange>("select * FROM ProductAvailabilityRange Where Id = @Id", new { id = id }).FirstOrDefault();
            }
            return productAvailabilityRange;
        }

        public void Insert(ProductAvailabilityRange entity)
        {
            throw new NotImplementedException();
        }

        public void Insert(IEnumerable<ProductAvailabilityRange> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(ProductAvailabilityRange entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<ProductAvailabilityRange> entities)
        {
            throw new NotImplementedException();
        }
    }
}
