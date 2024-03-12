using Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string HashSalt { get; set; }
        public string PasswordHash { get; set; }
        public ICollection<Order> Orders { get; set; } = new HashSet<Order>();
        public ICollection<UserRole> UserRoles { get; set; } = new HashSet<UserRole>();
        public ICollection<Payment> Payments { get; set; } = new HashSet<Payment>();
    }
}
