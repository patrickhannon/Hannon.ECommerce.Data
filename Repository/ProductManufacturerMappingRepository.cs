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
    public class ProductManufacturerMappingRepository : IRepository<ProductManufacturer>
    {
        private readonly string _connectionString;

        public ProductManufacturerMappingRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public ProductManufacturer GetById(object id)
        {
            throw new NotImplementedException();
        }

        public ICollection<ProductManufacturer> GetByProductId(int id)
        {
            ICollection<ProductManufacturer> productManufacturers;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                productManufacturers = connection.Query<ProductManufacturer>("select * FROM Product_Manufacturer_Mapping Where ProductId = @Id", new { id = id }).ToList();
            }
            return productManufacturers;
        }

        public IList<ProductManufacturer> Get()
        {
            IList<ProductManufacturer> productManufacturers;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                productManufacturers = connection.Query<ProductManufacturer>("select * FROM Product_Manufacturer_Mapping").ToList();
            }
            return productManufacturers;
        }

        public void Insert(ProductManufacturer entity)
        {
            throw new NotImplementedException();
        }

        public void Insert(IEnumerable<ProductManufacturer> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(ProductManufacturer entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<ProductManufacturer> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(ProductManufacturer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEnumerable<ProductManufacturer> entities)
        {
            throw new NotImplementedException();
        }

        public IQueryable<ProductManufacturer> Table { get; }

        public IQueryable<ProductManufacturer> TableNoTracking { get; }
    }
}
