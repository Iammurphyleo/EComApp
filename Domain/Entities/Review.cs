using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Review: BaseEntity
    {
        public string Comment { get; set; }

        public Product Product { get; set; }

        public Guid ProductId { get; set; }

        public Guid BrandId { get; set; }
        public Brand Brand { get; set; }    

        public int? Ratings { get; set; }
      
        public int? Like { get; set; }
        public int? DisLike { get; set; }

    }
}
