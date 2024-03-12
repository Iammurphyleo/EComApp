using Domain.DTO;
using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Order : BaseEntity
    {
        public User User { get; set; }
        public Guid UserId { get; set; }
        public string OrderReference { get; set; }
        public Payment Payment { get; set; }
        public Guid? PaymentId { get; set; }
        public Status Status { get; set; }
        public decimal TotalPrice { get; set; }
        public ICollection<OrderProduct> OrderProducts  { get; set; } = new List<OrderProduct>();  
    }
}
