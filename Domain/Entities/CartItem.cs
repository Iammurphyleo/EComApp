using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CartItem : BaseEntity
    {
        public Guid CartId { get; set; }

        public Cart Cart { get; set; }

        public Guid ItemId { get; set; }

        public Item Item { get; set; }

        public int ItemQuantity { get; set; }
        public decimal UnitPrice { get; set; }


    }
}
