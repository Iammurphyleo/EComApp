using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
 
        public ICollection<Order> Orders { get; set; } = new HashSet<Order>();

        public ICollection<Payment> Payments { get; set; } = new HashSet<Payment>();

        public ICollection<Cart> Carts { get; set; } = new HashSet<Cart>();
    }
}
