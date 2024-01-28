using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Cart : BaseEntity
    {
        public Customer Customer { get; set; }
        public Guid CustomerId { get; set; }
        public ICollection<CartItem> CartItems { get; set; } = new HashSet<CartItem>();

    }
}
