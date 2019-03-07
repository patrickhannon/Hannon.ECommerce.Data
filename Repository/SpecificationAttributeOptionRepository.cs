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
    public class SpecificationAttributeOptionRepository
    {
        private readonly string _connectionString;
        public SpecificationAttributeOptionRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public IList<SpecificationAttributeOption> GetCategories()
        {
            IList<SpecificationAttributeOption> specificationAttributeOption;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                specificationAttributeOption = connection.Query<SpecificationAttributeOption>("select * FROM SpecificationAttributeOption").ToList();
            }
            return specificationAttributeOption;
        }
    }
}
