using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Payment : BaseEntity
    {
        public Order Order { get; set; }
        public Guid OrderId { get; set; }
        public decimal Amount { get; set; }
        public string PaymentReference { get; set; }   
        public Customer Customer { get; set; }
        public Guid CustomerId { get; set; }
        public Status Status { get; set; }

    }
}
