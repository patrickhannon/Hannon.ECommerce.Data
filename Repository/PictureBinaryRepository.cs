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
    public class PictureBinaryRepository
    {
        private readonly string _connectionString;
        public PictureBinaryRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public IList<PictureBinary> GetCategories()
        {
            IList<PictureBinary> PictureBinary;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                PictureBinary = connection.Query<PictureBinary>("select * FROM PictureBinary").ToList();
            }
            return PictureBinary;
        }
    }
}
