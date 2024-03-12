using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Brand : BaseEntity
    {
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public string Name { get; set; }
        public ICollection<Review>? Reviews { get; set; } = new HashSet<Review>();

    }
}
