using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Constant
{
    public static class ApplicationRoleName
    {
        public const string SuperAdmin = "SuperAdmin";
        public const string Admin = "Admin";
        public const string Customer = "Customer";
      
        public const string AllRole = "Admin,Customer,SuperAdmin";
    }
}
