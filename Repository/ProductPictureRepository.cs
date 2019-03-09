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
    public class ProductPictureRepository : IRepository<ProductPicture>
    {
        private readonly string _connectionString;

        public ProductPictureRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        //todo this becomes a proc to join against mapping and actual table, key word is mapping
        public IList<ProductPicture> Get()
        {
            IList<ProductPicture> productPicture;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                productPicture = connection.Query<ProductPicture>("select * FROM Product_Picture_Mapping").ToList();
            }
            return productPicture;
        }

        public ProductPicture GetById(object id)
        {
            ProductPicture productPicture;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                productPicture = connection.Query<ProductPicture>("select * FROM Product_Picture_Mapping Where Id = @Id", new { id = id }).FirstOrDefault();
            }
            return productPicture;
        }

        public ICollection<ProductPicture> GetByProductId(int id)
        {
            ICollection<ProductPicture> productPicture;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                productPicture = connection.Query<ProductPicture>("select * FROM Product_Picture_Mapping Where ProductId = @Id", new { id = id }).ToList();
            }
            return productPicture;
        }

        public IQueryable<ProductPicture> Table => throw new NotImplementedException();

        public IQueryable<ProductPicture> TableNoTracking => throw new NotImplementedException();

        public void Delete(ProductPicture entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEnumerable<ProductPicture> entities)
        {
            throw new NotImplementedException();
        }

        public void Insert(ProductPicture entity)
        {
            throw new NotImplementedException();
        }

        public void Insert(IEnumerable<ProductPicture> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(ProductPicture entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<ProductPicture> entities)
        {
            throw new NotImplementedException();
        }
    }
}
