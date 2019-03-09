using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using ECommerce.Data.Core.Data;
using ECommerce.Data.Entities.Catalog;
using ECommerce.Data.Entities.Discounts;

namespace ECommerce.Data.Repository
{
    public class ProductWarehouseInventoryRepository : IRepository<ProductWarehouseInventory>
    {
        private readonly string _connectionString;

        public ProductWarehouseInventoryRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public ProductWarehouseInventory GetById(object id)
        {
            ProductWarehouseInventory productWarehouseInventory;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                productWarehouseInventory = connection.Query<ProductWarehouseInventory>("select * FROM ProductWarehouseInventory Where Id = @Id", new { id = id }).FirstOrDefault();
            }
            return productWarehouseInventory;
        }

        public ICollection<ProductWarehouseInventory> GetByProductId(int id)
        {
            ICollection<ProductWarehouseInventory> productWarehouseInventory;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                productWarehouseInventory = connection.Query<ProductWarehouseInventory>("select * FROM ProductWarehouseInventory Where ProductId = @Id", new { id = id }).ToList();
            }
            return productWarehouseInventory;
        }

        public IList<ProductWarehouseInventory> Get()
        {
            IList<ProductWarehouseInventory> productWarehouseInventory;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                productWarehouseInventory = connection.Query<ProductWarehouseInventory>("select * FROM ProductWarehouseInventory").ToList();
            }
            return productWarehouseInventory;
        }

        public void Insert(ProductWarehouseInventory entity)
        {
            throw new NotImplementedException();
        }

        public void Insert(IEnumerable<ProductWarehouseInventory> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(ProductWarehouseInventory entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<ProductWarehouseInventory> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(ProductWarehouseInventory entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEnumerable<ProductWarehouseInventory> entities)
        {
            throw new NotImplementedException();
        }

        public IQueryable<ProductWarehouseInventory> Table { get; }
        public IQueryable<ProductWarehouseInventory> TableNoTracking { get; }
    }
}
