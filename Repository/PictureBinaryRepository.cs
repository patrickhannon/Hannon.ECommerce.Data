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
    public class PictureBinaryRepository : IRepository<PictureBinary>
    {
        private readonly string _connectionString;
        public PictureBinaryRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IQueryable<PictureBinary> Table => throw new NotImplementedException();

        public IQueryable<PictureBinary> TableNoTracking => throw new NotImplementedException();

        public void Delete(PictureBinary entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEnumerable<PictureBinary> entities)
        {
            throw new NotImplementedException();
        }

        public IList<PictureBinary> Get()
        {
            IList<PictureBinary> PictureBinary;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                PictureBinary = connection.Query<PictureBinary>("select * FROM PictureBinary").ToList();
            }
            return PictureBinary;
        }

        public PictureBinary GetById(object id)
        {
            PictureBinary pictureBinary;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                pictureBinary = connection.Query<PictureBinary>("select * FROM PictureBinary Where Id = @Id", new { id = id }).FirstOrDefault();
            }
            return pictureBinary;
        }

        public void Insert(PictureBinary entity)
        {
            throw new NotImplementedException();
        }

        public void Insert(IEnumerable<PictureBinary> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(PictureBinary entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<PictureBinary> entities)
        {
            throw new NotImplementedException();
        }
    }
}
