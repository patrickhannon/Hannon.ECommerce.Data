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
    public class TierPricesRepository : IRepository<TierPrice>
    {
        private readonly string _connectionString;

        public TierPricesRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public TierPrice GetById(object id)
        {
            TierPrice tierPrice;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                tierPrice = connection.Query<TierPrice>("select * FROM TierPrice Where Id = @Id", new { id = id }).FirstOrDefault();
            }
            return tierPrice;
        }

        public ICollection<TierPrice> GetByProductId(int id)
        {
            ICollection<TierPrice> tierPrices;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                tierPrices = connection.Query<TierPrice>("select * FROM TierPrice Where ProductId = @Id", new { id = id }).ToList();
            }
            return tierPrices;
        }

        public IList<TierPrice> Get()
        {
            IList<TierPrice> tierPrice;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                tierPrice = connection.Query<TierPrice>("select * FROM TierPrice").ToList();
            }
            return tierPrice;
        }

        public void Insert(TierPrice entity)
        {
            throw new NotImplementedException();
        }

        public void Insert(IEnumerable<TierPrice> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(TierPrice entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<TierPrice> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(TierPrice entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEnumerable<TierPrice> entities)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TierPrice> Table { get; }
        public IQueryable<TierPrice> TableNoTracking { get; }
    }
}
