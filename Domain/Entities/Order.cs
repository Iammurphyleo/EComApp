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
        public Cart Cart { get; set; }
        public Guid CartId { get; set; }
        public string OrderReference { get; set; }
        public Payment Payment { get; set; }
      
        public Status Status { get; set; }
    }
}
