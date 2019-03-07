using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using ECommerce.Data.Entities;

namespace ECommerce.Data.Repository
{
    public class SpecificationAttributeRepository
    {
        private readonly string _connectionString;
        public SpecificationAttributeRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public IList<SpecificationAttribute> GetSpecificationAttributes()
        {
            IList<SpecificationAttribute> specificationAttribute;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                specificationAttribute = connection.Query<SpecificationAttribute>("select * FROM SpecificationAttribute").ToList();
            }
            return specificationAttribute;
        }
    }
}
