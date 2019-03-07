﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using ECommerce.Data.Entities;
using ECommerce.Data.Entities.Catalog;

namespace ECommerce.Data.Repository
{
    public class ProductProductAttributeMappingRepository
    {
        private readonly string _connectionString;
        public ProductProductAttributeMappingRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public IList<ProductAttribute> GetProductProductAttributeMappings()
        {
            IList<ProductAttribute> productAttribute;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                productAttribute = connection.Query<ProductAttribute>("select * FROM ProductAttribute").ToList();
            }
            return productAttribute;
        }
    }
}