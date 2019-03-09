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
    public class SpecificationAttributeOptionRepository : IRepository<SpecificationAttributeOption>

    {
        private readonly string _connectionString;
        public SpecificationAttributeOptionRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IList<SpecificationAttributeOption> Get()
        {
            IList<SpecificationAttributeOption> specificationAttributeOption;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                specificationAttributeOption = connection.Query<SpecificationAttributeOption>("select * FROM SpecificationAttributeOption").ToList();
            }
            return specificationAttributeOption;
        }

        public SpecificationAttributeOption GetById(object id)
        {
            SpecificationAttributeOption specificationAttributeOption;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                specificationAttributeOption = connection.Query<SpecificationAttributeOption>("select * FROM SpecificationAttributeOption Where Id = @Id", new { id = id }).FirstOrDefault();
            }
            return specificationAttributeOption;
        }

        public void Delete(IEnumerable<SpecificationAttributeOption> entities)
        {
            throw new NotImplementedException();
        }

        public IQueryable<SpecificationAttributeOption> Table => throw new NotImplementedException();

        public IQueryable<SpecificationAttributeOption> TableNoTracking => throw new NotImplementedException();

        public void Delete(SpecificationAttributeOption entity)
        {
            throw new NotImplementedException();
        }
        public void Insert(SpecificationAttributeOption entity)
        {
            throw new NotImplementedException();
        }

        public void Insert(IEnumerable<SpecificationAttributeOption> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(SpecificationAttributeOption entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<SpecificationAttributeOption> entities)
        {
            throw new NotImplementedException();
        }
    }
}
