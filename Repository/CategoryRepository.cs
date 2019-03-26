using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using ECommerce.Data.Core.Data;
using ECommerce.Data.Entities;
using ECommerce.Data.Entities.Catalog;

namespace ECommerce.Data.Repository
{
    public class CategoryRepository : IRepository<Category>
    {
        private readonly string _connectionString;
        public CategoryRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IQueryable<Category> Table { get; }

        public IQueryable<Category> TableNoTracking { get; }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEnumerable<Category> entities)
        {
            throw new NotImplementedException();
        }

        public Category GetById(object id)
        {

            Category category;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                category = connection.Query<Category>("select * FROM Category Where Id = @Id", new {id = id}).FirstOrDefault();
            }
            return category;
        }

        public ICollection<Category> GetByProductId(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Category> Get()
        {
            IList<Category> category;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                category = connection.Query<Category>("select * FROM Category").ToList();
            }
            return category;
        }

        public void Insert(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Insert(IEnumerable<Category> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<Category> entities)
        {
            throw new NotImplementedException();
        }
    }
}
