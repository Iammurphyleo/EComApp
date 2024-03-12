using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.DTO
{
    public class CartProduct : BaseEntity
    {
        public Guid CartId { get; set; }

        public Cart Cart { get; set; }

        public Guid ProductId { get; set; }

        public Product Product { get; set; }

        public int ProductQuantity { get; set; }
        public decimal UnitPrice { get; set; }


    }
}
