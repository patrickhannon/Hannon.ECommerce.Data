using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Data.Repository;
using System.Diagnostics;

namespace ECommerce.Data
{
    public class Program
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;


        public void VerifyDataLayerRepositories()
        {
            var c = new CategoryRepository(connectionString);
            var count = c.Get().Count;
            Debug.WriteLine($"Total count for categories:{count}");

        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.VerifyDataLayerRepositories();
        }
    }
}
