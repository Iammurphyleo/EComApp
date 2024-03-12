using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.DTO
{
    public class Cart : BaseEntity 
    {
        public User User { get; set; } 
        public Guid UserId { get; set; }
        public decimal TotalPrice { get; set; }
        public ICollection<CartProduct> CartItems { get; set; } = new HashSet<CartProduct>();

    }
}
