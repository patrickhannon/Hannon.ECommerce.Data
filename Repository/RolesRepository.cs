using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using ECommerce.Data.Entities;

namespace ECommerce.Data.Repository
{
    public class RolesRepository
    {
        private readonly string _connectionString;
        public RolesRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public Task AddToRoleAsync(UserRole role)
        {
            if (role == null)
                throw new ArgumentNullException("role");
            var roles = GetRoles();
            var assignedRole = roles.Where(x => x.Name == role.Role).FirstOrDefault();
            role.RoleId = assignedRole.RoleId;

            return Task.Factory.StartNew(() => {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                    connection.Execute(@"insert into UserRole(UserId, UserRoleId) " +
                                       "select @userId, @roleId ", role);
            });
        }

        public IList<Role> GetRoles()
        {
            IList<Role> roles;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                roles = connection.Query<Role>("select RoleId, Name from Role ").ToList();
            }
            return roles;
        }

        public IList<string> GetRoles(UserRole role)
        {
            IList<string> roles;
            if (role == null)
                throw new ArgumentNullException("user");
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                roles =
                    connection.Query<string>(
                        "select r.Name from UserRole ur INNER JOIN Role r on ur.UserRoleId = r.RoleId where ur.UserId = @userId",
                        role).ToList();
            }
            return roles;
        }
    }
}
