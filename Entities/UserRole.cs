using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Entities
{
    public class UserRole
    {
        public int RoleId { get; set; }
        public Guid UserId { get; set; }
        public string Role { get; set; }
    }
}
