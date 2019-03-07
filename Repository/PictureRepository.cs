using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using ECommerce.Data.Entities;
using ECommerce.Data.Entities.Media;

namespace ECommerce.Data.Repository
{
    public class PictureRepository
    {
        private readonly string _connectionString;
        public PictureRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public IList<Picture> GetPictures()
        {
            IList<Picture> picture;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                picture = connection.Query<Picture>("select * FROM Picture").ToList();
            }
            return picture;
        }
    }
}
