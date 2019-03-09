using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using ECommerce.Data.Core.Data;
using ECommerce.Data.Entities;
using ECommerce.Data.Entities.Media;

namespace ECommerce.Data.Repository
{
    public class SpecificationAttributeRepository : IRepository<SpecificationAttribute>

    {
        private readonly string _connectionString;
        public SpecificationAttributeRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public SpecificationAttribute GetById(object id)
        {
            SpecificationAttribute specificationAttribute;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                specificationAttribute = connection.Query<SpecificationAttribute>("select * FROM SpecificationAttribute Where Id = @Id", new { id = id }).FirstOrDefault();
            }
            return specificationAttribute;
        }

        public IList<SpecificationAttribute> Get()
        {
            IList<SpecificationAttribute> specificationAttribute;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                specificationAttribute = connection.Query<SpecificationAttribute>("select * FROM SpecificationAttribute").ToList();
            }
            return specificationAttribute;
        }

        public void Insert(SpecificationAttribute entity)
        {
            throw new NotImplementedException();
        }

        public void Insert(IEnumerable<SpecificationAttribute> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(SpecificationAttribute entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<SpecificationAttribute> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(SpecificationAttribute entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEnumerable<SpecificationAttribute> entities)
        {
            throw new NotImplementedException();
        }

        public IQueryable<SpecificationAttribute> Table { get; }

        public IQueryable<SpecificationAttribute> TableNoTracking { get; }
    }
}
