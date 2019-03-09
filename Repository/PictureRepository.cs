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
    public class PictureRepository : IRepository<Picture>
    {
        private readonly string _connectionString;
        public PictureRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public Picture GetById(object id)
        {
            Picture picture;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                picture = connection.Query<Picture>("select * FROM Picture Where Id = @Id", new { id = id }).FirstOrDefault();
            }
            return picture;
        }

        public IList<Picture> Get()
        {
            IList<Picture> picture;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                picture = connection.Query<Picture>("select * FROM Picture").ToList();
            }
            return picture;
        }

        public void Insert(Picture entity)
        {
            throw new NotImplementedException();
        }

        public void Insert(IEnumerable<Picture> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(Picture entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<Picture> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(Picture entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEnumerable<Picture> entities)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Picture> Table { get; }
        public IQueryable<Picture> TableNoTracking { get; }
    }
}
